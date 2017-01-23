using Repositories.HTTP.Requests.Components;
using Tests.Core;

namespace Tests.Scenarios.Components
{
    class ComponentsCreate : TestDecorator
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
                code = code,
                defaultValue = "0",
                description = "my_test_desc",
                length = 50,
                name = "my_test_component",
                reference = Config.data["reference_id"],
                structure = "VARCHAR"
            };

            Config.data["component_id"] = HTTP.Name("Component Create Testi")
                .Post("api/components/create", create)
                .ShouldBeOk()
                .FetchAsInt("id");
        }
    }
}
