using Tests.Core;
using Repositories.HTTP.Requests.LangValues.ListValues;

namespace Tests.Scenarios.LangValues.ListValues
{
    class LangValuesListValuesUpdate : TestDecorator
    {

        public override string GetName()
        {
            return "namespace => " + this.GetType().Namespace + ", class => " + this.GetType().Name;
        }

        public override void Execute()
        {
            RequestUpdate req = new RequestUpdate()
            {
                id = Config.data["list_value_id"],
                langId = 1,
                listId = Config.data["list_id"],
                listType = "User",
                valueId = null,
                value = "my_test_updated_value"
            };

            HTTP.Name("Lang Values List Values Update Testi")
                .Post("api/langValues/list_values/update", req)
                .ShouldBeOk();
        }
    }
}
