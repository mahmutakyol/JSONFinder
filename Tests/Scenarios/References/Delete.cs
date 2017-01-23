using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tests.Core;

namespace Tests.Scenarios.References
{
    class ReferencesDelete : TestDecorator
    {

        public override string GetName()
        {
            return "namespace => " + this.GetType().Namespace + ", class => " + this.GetType().Name;
        }

        public override void Execute()
        {
            HTTP.Name("Reference Delete Testi")
                .Get("api/references/delete/" + Config.data["reference_id"])
                .ShouldBeOk();
        }
    }
}
