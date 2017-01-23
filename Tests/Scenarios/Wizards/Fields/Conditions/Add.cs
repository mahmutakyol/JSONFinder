using Repositories.HTTP.Requests.Wizards.Fields.Conditions;
using Tests.Core;

namespace Tests.Scenarios.Wizards.Fields.Conditions
{
    class WizardFiledsConditionsAdd : TestDecorator
    {

        public override string GetName()
        {
            return "namespace => " + this.GetType().Namespace + ", class => " + this.GetType().Name;
        }

        public override void Execute()
        {
            Add add = new Add()
            {
                action = "action",
                control = "control",
                countryId = 1,
                fieldId = 1,
                groupId = 1,
                referenceFieldId = 1,
                regionId = 1,
                ruleType = "ruleType",
                sourceFieldId = 1,
                value = "value"
            };

            HTTP.Name("Wizard Field Conditions Add Testi")
                .Post("api/wizard_fields/conditions/add", add)
                .ShouldBeOk();
        }
    }
}
