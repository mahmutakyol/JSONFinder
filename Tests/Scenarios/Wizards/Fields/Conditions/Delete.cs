using Repositories.HTTP.Requests.Wizards.Fields.Conditions;
using Tests.Core;

namespace Tests.Scenarios.Wizards.Fields.Conditions
{
    class WizardFieldsConditionsDelete : TestDecorator
    {

        public override string GetName()
        {
            return "namespace => " + this.GetType().Namespace + ", class => " + this.GetType().Name;
        }

        public override void Execute()
        {
            Delete delete = new Delete()
            {
                action = "action",
                countryId = 1,
                fieldId = 1,
                id = 1,
                regionId = 1
            };

            HTTP.Name("Wizard Filed Conditions Delete Testi")
                .Post("api/wizard_fields/conditions/delete", delete)
                .ShouldBeOk();
        }
    }
}
