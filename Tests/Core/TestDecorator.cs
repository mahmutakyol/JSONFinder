using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using Tests.Interfaces;

namespace Tests.Core
{
    class TestDecorator: ITest
    {

        public virtual void Execute()
        {
            throw new Exception("İmplemente edilmemiş test sınıfı!");
        }

        public virtual string GetName()
        {
            return "";
        }

        protected string GetCode()
        {
            return "my_secret_code_" + GetHashString(DateTime.Now.ToString()).Substring(0, 10);
        }

        private byte[] GetHash(string inputString)
        {
            HashAlgorithm algorithm = MD5.Create();  //or use SHA1.Create();
            return algorithm.ComputeHash(Encoding.UTF8.GetBytes(inputString));
        }

        private string GetHashString(string inputString)
        {
            StringBuilder sb = new StringBuilder();
            foreach (byte b in GetHash(inputString))
                sb.Append(b.ToString("X2"));

            return sb.ToString();
        }

        public void AssertEqual(string firstValue, string secondValue)
        {
            if (firstValue != secondValue)
            {
                throw new Exception("'" + firstValue + "' değeri '" + secondValue + "' değerine eşit değil");
            }
            Config.IncraseAssertCount();
        }

    }
}
