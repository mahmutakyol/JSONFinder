using Repositories.HTTP.Requests.Components.Styles;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tests.Core;

namespace Tests.Scenarios.Components.Styles
{
    class ComponentsStylesAll : TestDecorator
    {

        public override string GetName()
        {
            return "namespace => " + this.GetType().Namespace + ", class => " + this.GetType().Name;
        }

        public override void Execute()
        {

            All all = new All()
            {
                visualType = "Date"
            };

            HTTP.Name("Styles All testi")
                .Post("api/components/styles/all", all)
                .ShouldBeOk();
        }

    }
}
