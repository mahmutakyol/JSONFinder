using Repositories.HTTP.Requests.LangValues.System;
using Tests.Core;

namespace Tests.Scenarios.LangValues.SystemDates
{
    class LangValuesSystemDatesByLang : TestDecorator
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

            HTTP.Name("Lang Values System Date ByLang Testi")
                .Post("api/langValues/systemDates/byLang", req)
                .ShouldBeOk();
        }
    }
}
