using Repositories.HTTP.Requests.Components;
using Tests.Core;

namespace Tests.Scenarios.Components.Creates
{
    class ComponentSurnameCreate : TestDecorator
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
                code = "surname" + code,
                defaultValue = "0",
                description = "my_test_surname_component",
                length = 50,
                name = "name",
                reference = Config.data["reference_id"],
                structure = "VARCHAR"
            };

            Config.data["surname_component_id"] = HTTP.Name("Component Surname Testi")
                .Post("api/components/create", create)
                .ShouldBeOk()
                .FetchAsInt("id");
        }
    }
}
