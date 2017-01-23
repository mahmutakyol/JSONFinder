using Helpers;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using Tests.Core;
using Tests.Scenarios.Auth;

namespace Tests
{
    public class Request
    {
        #region Request

        #region Veriables
        private Dictionary<string, string> headers;
        private string name;
        private Dictionary<string, dynamic> response;
        #endregion

        #region Constructors
        public Request(Dictionary<string, string> _headers, string _name)
        {
            headers = _headers;
            name = _name;
        }
        #endregion

        #region Method Functions

        public Request Get(string url, dynamic arguments = null)
        {
            return Send("GET", url, headers);
        }

        public Request Post(string url, dynamic arguments = null)
        {
            return Send("POST", url, headers, arguments);
        }

        #endregion

        #region Asserts
        public Request ShouldBeOk()
        {
            return ShouldResponseCode(200);
        }

        public Request ShouldContains(List<string> paths)
        {
            for (int i = 0; i < paths.Count; i++)
            {
                ShouldContain(paths[i]);
            }
            return this;
        }

        public Request ShouldHaveAtLeast(string path, int value)
        {
            Config.data["assert_count"] = Config.data["assert_count"] + 1;
            var jsonResult = JsonConvert.DeserializeObject<dynamic>(this.response["response"]);
            bool isArray = jsonResult.Type == JTokenType.Array;
            if (isArray)
            {
                if ((int)jsonResult.Count != value)
                {
                    Exception("'" + path + "' yolunda belirttiğiniz miktarda eleman bulunmuyor.");
                }
            }
            else
            {
                Exception("'" + path + "' yolunda bir dizgi(Array) bulunmuyor.");
            }
            return this;
        }

        public Request ShouldEqual(string path, dynamic value)
        {
            Config.data["assert_count"] = Config.data["assert_count"] + 1;
            var jsonResult = JsonConvert.DeserializeObject<dynamic>(this.response["response"]);
            jsonResult = PathFinder(path, jsonResult);
            if (jsonResult != value)
            {
                Exception("Sonuç 'eşit' değil: " + path);
            }
            return this;
        }

        public Request ShouldFalse(string path)
        {
            Config.data["assert_count"] = Config.data["assert_count"] + 1;
            var jsonResult = JsonConvert.DeserializeObject<dynamic>(this.response["response"]);
            jsonResult = PathFinder(path, jsonResult);
            if ((bool)jsonResult)
            {
                Exception("Sonuç 'false' değil: " + path);
            }
            return this;
        }

        public Request ShouldTrue(string path)
        {
            Config.data["assert_count"] = Config.data["assert_count"] + 1;
            var jsonResult = JsonConvert.DeserializeObject<dynamic>(this.response["response"]);
            jsonResult = PathFinder(path, jsonResult);
            if (!(bool)jsonResult)
            {
                Exception("Sonuç 'true' değil: " + path);
            }
            return this;
        }

        public Request ShouldContain(string path)
        {
            Config.data["assert_count"] = Config.data["assert_count"] + 1;
            var jsonResult = JsonConvert.DeserializeObject<dynamic>(this.response["response"]);

            var value = PathFinder(path, jsonResult);
            return this;
        }

        public Request ShouldGreaterThan(string path, double value)
        {
            Config.data["assert_count"] = Config.data["assert_count"] + 1;
            var jsonResult = JsonConvert.DeserializeObject<dynamic>(this.response["response"]);
            jsonResult = PathFinder(path, jsonResult);
            if (jsonResult <= value)
            {
                Exception("Girdiğiniz değer büyük ya da eşit: " + path);
            }
            return this;
        }

        public Request ShouldLessThan(string path, double value)
        {
            Config.data["assert_count"] = Config.data["assert_count"] + 1;
            var jsonResult = JsonConvert.DeserializeObject<dynamic>(this.response["response"]);
            jsonResult = PathFinder(path, jsonResult);
            if (jsonResult >= value)
            {
                Exception("Girdiğiniz değer küçük ya da eşit: " + path);
            }
            return this;
        }

        public Request ShouldGreaterThanOrEqual(string path, double value)
        {
            Config.data["assert_count"] = Config.data["assert_count"] + 1;
            var jsonResult = JsonConvert.DeserializeObject<dynamic>(this.response["response"]);
            jsonResult = PathFinder(path, jsonResult);
            if (jsonResult < value)
            {
                Exception("Girdiğiniz değer büyük: " + path);
            }
            return this;
        }

        public Request ShouldLessThanOrEqual(string path, double value)
        {
            Config.data["assert_count"] = Config.data["assert_count"] + 1;
            var jsonResult = JsonConvert.DeserializeObject<dynamic>(this.response["response"]);
            jsonResult = PathFinder(path, jsonResult);
            if (jsonResult > value)
            {
                Exception("Girdiğiniz değer küçük: " + path);
            }
            return this;
        }

        public Request ShouldNull(string path)
        {
            Config.data["assert_count"] = Config.data["assert_count"] + 1;
            var jsonResult = JsonConvert.DeserializeObject<dynamic>(this.response["response"]);
            jsonResult = PathFinder(path, jsonResult);
            if (jsonResult == null)
            {
                Exception("Sonuç 'null' değil: " + path);
            }
            return this;
        }

        public Request ShouldHaveHeader(string key)
        {
            Config.data["assert_count"] = Config.data["assert_count"] + 1;
            bool isHaveKey = false;
            foreach (dynamic item in this.response["headers"])
            {
                if ((string)item == key)
                {
                    isHaveKey = true;
                    break;
                }
            }
            if (!isHaveKey)
            {
                Exception("Header '" + key + "' parametresini içermiyor.");
            }
            return this;
        }

        public Request ShouldResponseCode(int code)
        {
            Config.data["assert_count"] = Config.data["assert_count"] + 1;
            if (this.response["statusCode"] == code)
            {
                return this;
            }
            else
            {
                Exception("Response should be " + code);
                return this;
            }
        }

        public Request ShouldBeContain(string value)
        {
            Config.data["assert_count"] = Config.data["assert_count"] + 1;
            var jsonResult = JsonConvert.DeserializeObject<dynamic>(this.response["response"]);
            var response = PathFinder(value, jsonResult);
            if (response == null)
            {
                Exception("İçerik bulunamadı: " + value);
            }
            return this;
        }

        public dynamic Fetch(string path)
        {
            Config.data["assert_count"] = Config.data["assert_count"] + 1;
            var jsonResult = JsonConvert.DeserializeObject<dynamic>(this.response["response"]);

            var value = PathFinder(path, jsonResult);
            return value;
        }

        public bool FetchAsBool(string path)
        {
            dynamic value = Fetch(path);
            try
            {
                return Convert.ToBoolean(value);
            }
            catch (Exception)
            {
                throw new Exception("Bu değer boolean türünde değil: " + value.ToString());
            }
        }

        public string FetchAsString(string path)
        {
            dynamic value = Fetch(path);
            try
            {
                return Convert.ToString(value);
            }
            catch (Exception)
            {
                throw new Exception("Bu değer string türünde değil: " + value.ToString());
            }
        }

        public int FetchAsInt(string path)
        {
            dynamic value = Fetch(path);
            try
            {
                return Convert.ToInt32(value);
            }
            catch (Exception)
            {
                throw new Exception("Bu değer integer türünde değil: " + value.ToString());
            }                 
        }

        public Dictionary<string, dynamic> FetchAsDictionary(List<string> paths)
        {
            Dictionary<string, dynamic> response = new Dictionary<string, dynamic>();

            try
            {
                foreach (string path in paths)
                {
                    response[path] = Fetch(path);
                }
            }
            catch (Exception)
            {

                throw;
            }

            return response;
        }

        public string GetToken()
        {
            LoginResponse loginResponse = JsonConvert.DeserializeObject<LoginResponse>(this.response["response"]);

            return loginResponse.token;
        }

        public dynamic PathFinder(string path, dynamic jsonResult)
        {
            string[] words = null;

            words = SplitPath(path, words);

            for (int i = 0; i < words.Length; i++)
            {
                if (words[i].Count(f => f == '[') > 0)
                {
                    int pFrom = words[i].IndexOf("[") + "[".Length;
                    int pTo = words[i].LastIndexOf("]");
                    words[i] = words[i].Substring(pFrom, pTo - pFrom);
                }
            }

            for (int i = 0; i < words.Length; i++)
            {
                if (words[i] != "" && words[i] != null)
                {
                    if (words[i] == "F")
                    {
                        try
                        {
                            jsonResult = FirstIndexOf(jsonResult, path);
                        }
                        catch (Exception)
                        {
                            throw;
                        }
                    }
                    else if (words[i] == "L")
                    {
                        try
                        {
                            jsonResult = LastIndexOf(jsonResult, path);
                        }
                        catch (Exception)
                        {

                            throw;
                        }
                    }
                    else
                    {
                        try
                        {
                            jsonResult = IsJDictionary(i, jsonResult, words, path);
                        }
                        catch (Exception)
                        {

                            throw;
                        }
                    }
                }
            }
            return jsonResult;
        }
        #endregion

        #region Private Functions
        private dynamic IsJDictionary(int index, dynamic result, dynamic words, string path)
        {
            try
            {
                foreach (KeyValuePair<string, dynamic> item in result)
                {
                    if (item.Key == words[index])
                    {
                        result = item.Value;
                    }
                }
            }
            catch (Exception)
            {
                result = IsJList(index, result, words, path);
            }
            return result;
        }

        private dynamic IsJList(int index, dynamic result, dynamic words, string path)
        {
            try
            {
                result = result[Int32.Parse(words[index])];
            }
            catch (Exception)
            {
                result = IsJObject(index, result, words, path);
            }
            return result;
        }

        private dynamic IsJObject(int index, dynamic result, dynamic words, string path)
        {
            try
            {
                result = result[words[index]];
            }
            catch (Exception)
            {
                result = IsJArray(index, result, words, path);
            }
            return result;
        }

        private dynamic IsJArray(dynamic index, dynamic result, dynamic words, string path)
        {
            string temp = words[index];
            try
            {
                foreach (dynamic item in result)
                {
                    result = item[temp];
                }
            }
            catch (Exception ex)
            {
                Exception("Yol bulunamadı: " + path);
                throw;
            }
            return result;
        }

        private dynamic FirstIndexOf(JArray result, string path)
        {
            dynamic response = null;
            try
            {
                response = result.First();
            }
            catch (Exception)
            {
                Exception("Yol bulunamadı: " + path);
                throw;
            }

            return response;
        }

        private dynamic LastIndexOf(JArray result, string path)
        {
            dynamic response = null;
            try
            {
                response = result.Last();
            }
            catch (Exception)
            {
                Exception("Yol bulunamadı: " + path);
                throw;
            }

            return response;
        }

        private string[] SplitPath(string path, string[] wordsArray)
        {
            path = path.Replace("[", ".[");

            wordsArray = path.Split('.');

            return wordsArray;
        }

        private void Exception(string message)
        {

            throw new Exception(String.Format("[{0}] {1}", name, message));
        }

        private Request Send(string type, string url, Dictionary<string, string> headers, dynamic arguments = null)
        {
            Connection cs = new Connection();
            string jsonContent = JsonConvert.SerializeObject(arguments, Formatting.Indented);

            if (type == "GET")
            {
                this.response = cs.GET("http://localhost:9191/" + url, headers);
            }
            else if (type == "POST")
            {
                this.response = cs.POST("http://localhost:9191/" + url, jsonContent, headers);
            }

            return this;
        }
        #endregion 

        #endregion
    }
}
