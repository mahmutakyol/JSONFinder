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
    class ComponentsStylesSave : TestDecorator
    {

        public override string GetName()
        {
            return "namespace => " + this.GetType().Namespace + ", class => " + this.GetType().Name;
        }

        public override void Execute()
        {
            string code = GetCode();
            Save save = new Save()
            {

                id = 0,
                name = "my_test_name",
                code = code,
                visualType = "Date"
            };

            Config.data["component_style_id"] = HTTP.Name("Styles Save testi")
                .Post("api/components/styles/save", save)
                .ShouldBeOk()
                .FetchAsInt("[L].id");
        }
    }
}
