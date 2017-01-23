using Repositories.HTTP.Requests.Wizards.Fields.Conditions.Group;
using Tests.Core;

namespace Tests.Scenarios.Wizards.Fields.Rules
{
    class WizardsFieldsRulesToggle : TestDecorator
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
                groupId = 1,
                regionId = 1
            };

            HTTP.Name("Wizard Filed Rule Toggle Testi")
                .Post("api/wizard_fields/ruleGroup/toggle", toggle)
                .ShouldBeOk();
        }
    }
}
