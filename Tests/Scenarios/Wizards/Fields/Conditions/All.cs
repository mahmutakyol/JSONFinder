using Repositories.HTTP.Requests.Wizards.Fields.Conditions;
using Tests.Core;

namespace Tests.Scenarios.Wizards.Fields.Conditions
{
    class WizardFieldsConditionsAll : TestDecorator
    {

        public override string GetName()
        {
            return "namespace => " + this.GetType().Namespace + ", class => " + this.GetType().Name;
        }

        public override void Execute()
        {
            All all = new All()
            {
                action = "action",
                countryId = 1,
                fieldId = 1,
                formId = 1,
                regionId = 1
            };

            HTTP.Name("Wizard Field Conditions All Testi")
                .Post("api/wizard_fields/conditions/all", all)
                .ShouldBeOk();
        }
    }
}
