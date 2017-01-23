using Repositories.HTTP.Requests.LangValues.Components;
using Tests.Core;

namespace Tests.Scenarios.LangValues.Components
{
    class LangValuesComponentsUpdate : TestDecorator
    {

        public override string GetName()
        {
            return "namespace => " + this.GetType().Namespace + ", class => " + this.GetType().Name;
        }

        public override void Execute()
        {
            RequestUpdate req = new RequestUpdate()
            {
                valueId = -11,
                componentId = Config.data["component_id"],
                langId = 1,
                name = "my_test_updated_name",
                description = "my_test_updated_description"
            };

            HTTP.Name("Lang Values Components Update Testi")
                .Post("api/langValues/component/update", req)
                .ShouldBeOk()
                .ShouldEqual("name", "my_test_updated_name")
                .ShouldEqual("description", "my_test_updated_description");
        }
    }
}
