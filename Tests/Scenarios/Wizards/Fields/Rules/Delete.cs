using Repositories.HTTP.Requests.Wizards.Fields.Conditions.Group;
using Tests.Core;

namespace Tests.Scenarios.Wizards.Fields.Rules
{
    class WizardsFieldsRulesDelete : TestDecorator
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

            HTTP.Name("Wizard Field Rules Delete Testi")
                .Post("api/wizard_fields/ruleGroup/delete", delete)
                .ShouldBeOk();
        }
    }
}
