using Repositories.HTTP.Requests.Components;
using Tests.Core;

namespace Tests.Scenarios.Components.Creates
{
    class ComponentNameCreate : TestDecorator
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
                code = "name" + code,
                defaultValue = "0",
                description = "my_test_name_component",
                length = 50,
                name = "name",
                reference = Config.data["reference_id"],
                structure = "VARCHAR"
            };

            Config.data["name_component_id"] = HTTP.Name("Component Name Testi")
                .Post("api/components/create", create)
                .ShouldBeOk()
                .FetchAsInt("id");
        }
    }
}
