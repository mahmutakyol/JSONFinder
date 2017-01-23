using Repositories.HTTP.Requests.Wizards.Fields.Conditions;
using Tests.Core;

namespace Tests.Scenarios.Wizards.Fields.Conditions
{
    class WizardFieldsConditionsToggle : TestDecorator
    {

        public override string GetName()
        {
            return "namespace => " + this.GetType().Namespace + ", class => " + this.GetType().Name;
        }

        public override void Execute()
        {
            Toggle toggle = new Toggle()
            {
                action = "action",
                countryId = 1,
                fieldId = 1,
                regionId = 1,
                ruleId = 1
            };

            HTTP.Name("Wizard Fields Contiditons Toggle Testi")
                .Post("api/wizard_fields/conditions/toggle", toggle)
                .ShouldBeOk();
        }
    }
}
