using Repositories.HTTP.Requests.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tests.Core;

namespace Tests.Scenarios.Components.Creates
{
    class ComponentEditionCreate : TestDecorator
    {
        public override string GetName()
        {
            return "namespace => " + this.GetType().Namespace + ", class => " + this.GetType().Name;
        }

        public override void Execute()
        {
            string code = GetCode();
            RequestCreate create = new RequestCreate()
            {
                code = "edition" + code,
                defaultValue = "0",
                description = "my_test_edition_component",
                length = 50,
                name = "name",
                reference = Config.data["reference_id"],
                structure = "VARCHAR"
            };

            Config.data["edition_component_id"] = HTTP.Name("Component Edition Testi")
                .Post("api/components/create", create)
                .ShouldBeOk()
                .FetchAsInt("id");
        }
    }
}
