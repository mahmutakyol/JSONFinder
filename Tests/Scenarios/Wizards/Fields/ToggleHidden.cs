using Repositories.HTTP.Requests.Wizards.Fields;
using Tests.Core;

namespace Tests.Scenarios.Wizards.Fields
{
    class WizardsFieldsToggleHidden : TestDecorator
    {

        public override string GetName()
        {
            return "namespace => " + this.GetType().Namespace + ", class => " + this.GetType().Name;
        }

        public override void Execute()
        {
            ToggleHidden toggleHidden = new ToggleHidden()
            {
                countryId = 1,
                fieldId = 1,
                langId = 1,
                regionId = 1,
                wizardId = 1
            };

            HTTP.Name("Wizard Field ToggleHidden Testi")
                .Post("api/wizard/fields/toggleHidden", toggleHidden)
                .ShouldBeOk();
        }
    }
}
