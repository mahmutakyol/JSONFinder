using Repositories.HTTP.Requests.LangValues.Components;
using Tests.Core;

namespace Tests.Scenarios.LangValues.Components
{
    class LangValuesComponentsComponent : TestDecorator
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

            HTTP.Name("Lang Values Components Component Testi")
                .Post("api/langValues/component", req)
                .ShouldBeOk();
        }
    }
}
