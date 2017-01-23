using Repositories.HTTP.Requests.Wizards.Fields.Conditions.Group;
using Tests.Core;

namespace Tests.Scenarios.Wizards.Fields.Rules
{
    class WizardsFieldsRulesUpdate : TestDecorator
    {

        public override string GetName()
        {
            return "namespace => " + this.GetType().Namespace + ", class => " + this.GetType().Name;
        }

        public override void Execute()
        {

            Update update = new Update()
            {
                action = "action",
                countryId = 1,
                fieldId = 1,
                groupId = 1,
                name = "name",
                regionId = 1
            };

            HTTP.Name("Wizard Field Rule Update Testi")
                .Post("api/wizard_fields/ruleGroup/update", update)
                .ShouldBeOk();
        }
    }
}
