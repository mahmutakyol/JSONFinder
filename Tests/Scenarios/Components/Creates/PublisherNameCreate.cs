using Repositories.HTTP.Requests.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tests.Core;

namespace Tests.Scenarios.Components.Creates
{
    class ComponentPublisherNameCreate : TestDecorator
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
                code = "publisher_name" + code,
                defaultValue = "0",
                description = "my_test_publisher_name_component",
                length = 50,
                name = "publisher_name",
                reference = Config.data["reference_id"],
                structure = "VARCHAR"
            };

            Config.data["publisher_name_component_id"] = HTTP.Name("Component Publisher Name Testi")
                .Post("api/components/create", create)
                .ShouldBeOk()
                .FetchAsInt("id");

        }
    }
}
