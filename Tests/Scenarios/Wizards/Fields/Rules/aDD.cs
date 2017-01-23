using Repositories.HTTP.Requests.Wizards.Fields.Conditions.Group;
using Tests.Core;

namespace Tests.Scenarios.Wizards.Fields.Rules
{
    class WizardsFieldsRulesAdd : TestDecorator
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
                countryId = 1,
                fieldId = 1,
                name = "name", 
                regionId = 1
            };

            HTTP.Name("Wizard Field Rules Add Testi")
                .Post("api/wizard_fields/ruleGroup/add", add)
                .ShouldBeOk();
        }
    }
}
