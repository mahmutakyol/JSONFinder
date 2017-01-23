using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tests.Core;

namespace Tests.Scenarios.Externals.Definitions
{
    class ServiceDefinitionsInit : TestDecorator
    {

        public override string GetName()
        {
            return "namespace => " + this.GetType().Namespace + ", class => " + this.GetType().Name;
        }

        public override void Execute()
        {
            HTTP.Name("External Definitions Init Testi")
                .Get("api/services/init")
                .ShouldBeOk();
        }

    }
}
