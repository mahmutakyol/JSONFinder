using Repositories.HTTP.Requests.Components;
using Tests.Core;

namespace Tests.Scenarios.Components.Creates
{
    class ComponentBookIdCreate : TestDecorator
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
                code = "book_id" + code,
                defaultValue = "0",
                description = "my_book_id_component",
                length = 50,
                name = "name",
                reference = Config.data["reference_id"],
                structure = "VARCHAR"
            };

            Config.data["book_id_component_id"] = HTTP.Name("Component Book Id Testi")
                .Post("api/components/create", create)
                .ShouldBeOk()
                .FetchAsInt("id");
        }
    }
}
