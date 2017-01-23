using Repositories.HTTP.Requests.LangValues.Wizard;
using Tests.Core;

namespace Tests.Scenarios.LangValues.Wizards
{
    class LangValuesWizardsWizards : TestDecorator
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

            Config.data["update_wizard_lang_id"] = HTTP.Name("Lang Values Wizards Wizard Testi")
                .Post("api/langValues/wizards", req)
                .ShouldBeOk()
                .FetchAsInt("[L].id");
        }

    }
}
