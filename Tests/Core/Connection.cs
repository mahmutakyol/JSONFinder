using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;

namespace Tests.Core
{
    class Connection
    {
        public Dictionary<string, dynamic> GET(string url, Dictionary<string, string> header)
        {
            Dictionary<string, dynamic> result = new Dictionary<string, dynamic>();
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            if (header.Count > 0)
            {
                request.Headers.Add(header.Keys.First(), header.Values.First());
                request.ContentType = "application/json";
            }
            ServicePointManager.ServerCertificateValidationCallback += (sender, cert, chain, sslPolicyErrors) => true;
            try
            {
                HttpWebResponse response = (HttpWebResponse)request.GetResponse();
                
                using (Stream responseStream = response.GetResponseStream())
                {
                    result["statusCode"] = (int)response.StatusCode;
                    result["headers"] = response.Headers;
                    StreamReader reader = new StreamReader(responseStream, Encoding.UTF8);
                    result["response"] = reader.ReadToEnd();
                    return result;
                }
            }
            catch (WebException ex)
            {
                WebResponse errorResponse = ex.Response;
                result["errorResponse"] = errorResponse;
                using (Stream responseStream = errorResponse.GetResponseStream())
                {
                    StreamReader reader = new StreamReader(responseStream, Encoding.GetEncoding("utf-8"));
                    String errorText = reader.ReadToEnd();
                    result["errorMessage"] = errorText;
                }
                throw;
                return result;
            }
        }

        public Dictionary<string, dynamic> POST(string url, string jsonContent, Dictionary<string, string> header)
        {
            Dictionary<string, dynamic> result = new Dictionary<string, dynamic>();
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            ServicePointManager.ServerCertificateValidationCallback += (sender, cert, chain, sslPolicyErrors) => true;
            request.Method = "POST";
            
            System.Text.UTF8Encoding encoding = new System.Text.UTF8Encoding();
            Byte[] byteArray = encoding.GetBytes(jsonContent);

            if (header.Count > 0)
            {
                request.Headers.Add(header.Keys.First(), header.Values.First());
                request.ContentType = "application/x-www-form-urlencoded";
            } 
            request.ContentLength = byteArray.Length;
            request.ContentType = @"application/json";

            using (Stream dataStream = request.GetRequestStream())
            {
                dataStream.Write(byteArray, 0, byteArray.Length);
            }
            HttpWebResponse response;
            try
            {

                response = (HttpWebResponse)request.GetResponse();
                using (Stream stream = response.GetResponseStream())
                {
                    result["statusCode"] = (int)response.StatusCode;
                    result["headers"] = response.Headers;
                    StreamReader reader = new StreamReader(stream, Encoding.UTF8);
                    result["response"] = reader.ReadToEnd();
                }

            }
            catch (WebException ex)
            {
                result["errorMessage"] = ex.Message;
                throw;
                // Log exception and throw as for GET example above
            }
            return result;
        }
    }
}
