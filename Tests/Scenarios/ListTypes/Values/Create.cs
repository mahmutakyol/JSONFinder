using Repositories.HTTP.Requests.ListTypes.Values;
using Tests.Core;

namespace Tests.Scenarios.ListTypes.Values
{
    class ListTypeValuesCreate : TestDecorator
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
                current = 0,
                list_id = Config.data["list_id"],
                parentId = 0,
                title = code,
                value = "my_test_value"
            };

            Config.data["list_value_id"] = HTTP.Name("List Type Values Create Testi")
                .Post("api/listType/values/create", create)
                .ShouldBeOk()
                .FetchAsInt("items[F].id");
        }
    }
}
