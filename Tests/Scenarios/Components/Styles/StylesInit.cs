using Repositories.HTTP.Requests.Components.Styles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tests.Core;

namespace Tests.Scenarios.Components.Styles
{
    class ComponentsStylesInit : TestDecorator
    {

        public override string GetName()
        {
            return "namespace => " + this.GetType().Namespace + ", class => " + this.GetType().Name;
        }

        public override void Execute()
        {

            Get init = new Get()
            {
                id = 1
            };

            HTTP.Name("Styles Init testi")
                .Post("api/components/styles/init", init)
                .ShouldBeOk();
        }
    }
}
