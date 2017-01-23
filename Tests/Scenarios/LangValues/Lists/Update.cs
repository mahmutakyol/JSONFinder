using Repositories.HTTP.Requests.LangValues.Lists;
using Tests.Core;

namespace Tests.Scenarios.LangValues.Lists
{
    class LangValuesListsUpdate : TestDecorator
    {

        public override string GetName()
        {
            return "namespace => " + this.GetType().Namespace + ", class => " + this.GetType().Name;
        }

        public override void Execute()
        {
            RequestUpdate req = new RequestUpdate()
            {
                type = "User",
                valueId = 1,
                listId = Config.data["update_list_id"],
                langId = 1,
                name = "my_test_updated_name",
                description = "my_test_updated_description"
            };

            Config.data["updated_list_id"] = HTTP.Name("Lang Values List Update Testi")
                .Post("api/langValues/list/update", req)
                .ShouldBeOk()
                .FetchAsInt("");
        }
    }
}
