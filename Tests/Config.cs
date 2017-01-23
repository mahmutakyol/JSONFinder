using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests
{
    
    class Config
    {
        private static Dictionary<string, string> headers = new Dictionary<string, string>();
        public static Dictionary<string, dynamic> data = new Dictionary<string, dynamic>();

        public static void SetHeader(string key, string value)
        {
            headers[key] = value;
        }

        public static Dictionary<string, string> GetHeaders()
        {
            return headers;
        }

        public static void IncraseAssertCount()
        {
            data["assert_count"] = data["assert_count"] + 1;
        }

    }

}
