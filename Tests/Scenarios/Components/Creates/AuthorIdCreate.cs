using Repositories.HTTP.Requests.Components;
using Tests.Core;

namespace Tests.Scenarios.Components.Creates
{
    class ComponentAuthorIdCreate : TestDecorator
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
                code = "author_id" + code,
                defaultValue = "0",
                description = "my_author_id_component",
                length = 50,
                name = "author_id",
                reference = Config.data["reference_id"],
                structure = "VARCHAR"
            };

            Config.data["author_id_component_id"] = HTTP.Name("Component Author Id Testi")
                .Post("api/components/create", create)
                .ShouldBeOk()
                .FetchAsInt("id");
        }
    }
}
