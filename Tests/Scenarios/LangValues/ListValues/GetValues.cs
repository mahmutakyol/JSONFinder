using Repositories.HTTP.Requests.LangValues.ListValues;
using Tests.Core;

namespace Tests.Scenarios.LangValues.ListValues
{
    class LangValuesListValuesGetValues : TestDecorator
    {

        public override string GetName()
        {
            return "namespace => " + this.GetType().Namespace + ", class => " + this.GetType().Name;
        }

        public override void Execute()
        {
            RequestAll req = new RequestAll()
            {
                listId = Config.data["list_id"],
                listType = "User",
                langId = 1
            };

            Config.data["list_value_id"] = HTTP.Name("Lang Values List Values Get Values Testi")
                .Post("api/langValues/getValues", req)
                .ShouldBeOk()
                .FetchAsInt("[L].id");
        }
    }
}
