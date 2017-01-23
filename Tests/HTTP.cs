using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests
{
    class HTTP
    {
        public static Request Name(string name)
        {
            return new Request(Config.GetHeaders(), name);
        }

    }
}
