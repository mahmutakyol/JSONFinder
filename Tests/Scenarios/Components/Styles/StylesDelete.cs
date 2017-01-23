using Repositories.Components;
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
    class ComponentsStylesDelete : TestDecorator
    {

        public override string GetName()
        {
            return "namespace => " + this.GetType().Namespace + ", class => " + this.GetType().Name;
        }

        public override void Execute()
        {
            Delete delete = new Delete()
            {
                id = Config.data["component_style_id"],
                visualType = "Date"
            };
            HTTP.Name("Styles Delete Testi")
                .Post("api/components/styles/delete", delete)
                .ShouldBeOk();
        }
    }
}
