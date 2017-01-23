using Repositories.HTTP.Requests.LangValues.Wizard;
using Tests.Core;

namespace Tests.Scenarios.LangValues.Wizards
{
    class LangValuesWizardsUpdate : TestDecorator
    {

        public override string GetName()
        {
            return "namespace => " + this.GetType().Namespace + ", class => " + this.GetType().Name;
        }

        public override void Execute()
        {
            RequestUpdate req = new RequestUpdate()
            {
                valueId = 1,
                wizardId = Config.data["wizard_id"],
                langId = 1,
                name = "my_test_name_updated",
                description = "my_test_description_updated"
            };

            HTTP.Name("Lang Values Wizards Update Testi")
                .Post("api/langValues/wizards/update", req)
                .ShouldBeOk()
                .FetchAsInt("id");
        }
    }
}
