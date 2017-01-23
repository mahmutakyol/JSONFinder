using Repositories.HTTP.Requests.Wizards.Fields;
using Tests.Core;

namespace Tests.Scenarios.Wizards.Fields
{
    class WizardsFieldChangeOption : TestDecorator
    {

        public override string GetName()
        {
            return "namespace => " + this.GetType().Namespace + ", class => " + this.GetType().Name;
        }

        public override void Execute()
        {
            ChangeOption changeOption = new ChangeOption()
            {
                formWizardId = 1,
                key = "key",
                langId = 1,
                countryId = 1,
                regionId = 1,
                value = "value",
                wizardId = 1
            };

            HTTP.Name("Wizard Filed ChangeOption Testi")
                .Post("api/wizard/fields/changeOption", changeOption)
                .ShouldBeOk();
        }
    }
}
