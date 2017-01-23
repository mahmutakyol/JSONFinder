using Tests.Core;
using Repositories.HTTP.Requests.LangValues.System;

namespace Tests.Scenarios.LangValues.SystemDates
{
    class LangValuesSystemDatesUpdate : TestDecorator
    {

        public override string GetName()
        {
            return "namespace => " + this.GetType().Namespace + ", class => " + this.GetType().Name;
        }

        public override void Execute()
        {
            RequestUpdate req = new RequestUpdate()
            {
                parameterId = 1,
                langId = 1,
                valueId = 1,
                value = "value"
            };

            HTTP.Name("Lang Values System Dates Update Testi")
                .Post("api/langValues/systemDates/update", req)
                .ShouldBeOk();
        }
    }
}
