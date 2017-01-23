using Repositories.HTTP.Requests.LangValues.Lists;
using Tests.Core;

namespace Tests.Scenarios.LangValues.Lists
{
    class LangValuesListsByLang : TestDecorator
    {

        public override string GetName()
        {
            return "namespace => " + this.GetType().Namespace + ", class => " + this.GetType().Name;
        }

        public override void Execute()
        {
            RequestAll req = new RequestAll()
            {
                langId = 1
            };

            Config.data["update_list_id"] = HTTP.Name("Lang Values Lists ByLang Testi")
                .Post("api/langValues/byLang", req)
                .ShouldBeOk()
                .FetchAsInt("[L].id");  
        }
    }
}
