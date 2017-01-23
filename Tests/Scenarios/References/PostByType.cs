using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tests.Core;

namespace Tests.Scenarios.References
{
    class ReferencesPostByType : TestDecorator
    {

        public override void Execute()
        {

            string type = "type";

            HTTP.Name("Reference PostByType Testi")
                .Get("api/references/byType/" + type, type)
                .ShouldBeOk();
        }
    }
}
