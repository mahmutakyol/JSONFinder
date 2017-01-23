using Repositories.HTTP.Requests.Components;
using Tests.Core;

namespace Tests.Scenarios.Components.Creates
{
    class ComponentUserIdCreate : TestDecorator
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
                code = "user_id" + code,
                defaultValue = "0",
                description = "my_user_id_component",
                length = 50,
                name = "user_id",
                reference = Config.data["reference_id"],
                structure = "VARCHAR"
            };

            Config.data["user_id_component_id"] = HTTP.Name("Component Name Testi")
                .Post("api/components/create", create)
                .ShouldBeOk()
                .FetchAsInt("id");
        }
    }
}
