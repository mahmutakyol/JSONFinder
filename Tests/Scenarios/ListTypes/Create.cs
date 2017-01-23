using Repositories.HTTP.Requests.ListTypes;
using Tests.Core;

namespace Tests.Scenarios.ListTypes
{
    class ListTypesCreate : TestDecorator
    {

        public override string GetName()
        {
            return "namespace => " + this.GetType().Namespace + ", class => " + this.GetType().Name;
        }

        public override void Execute()
        {
            string code = GetCode();
            Create create = new Create()
            {
                code = code,
                description = "my_test_description",
                name = "my_test_list",
                parentId = -1
            };

            Config.data["list_id"] = HTTP.Name("ListType Create Testi")
                .Post("api/listTypes", create)
                .ShouldBeOk()
                .ShouldEqual("code", code)
                .ShouldEqual("description", "my_test_description")
                .ShouldEqual("name", "my_test_list")
                .FetchAsInt("id");
        }
    }
}
