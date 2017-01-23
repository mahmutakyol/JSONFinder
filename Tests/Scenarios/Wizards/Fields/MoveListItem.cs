using Repositories.HTTP.Requests.Wizards.Fields;
using Tests.Core;

namespace Tests.Scenarios.Wizards.Fields
{
    class WizardsFieldsMoveListItem : TestDecorator
    {

        public override string GetName()
        {
            return "namespace => " + this.GetType().Namespace + ", class => " + this.GetType().Name;
        }

        public override void Execute()
        {

            Move move = new Move()
            {
                countryId = 1,
                direction = "direction",
                fieldId = 1,
                langId = 1,
                regionId = 1,
                wizardId = 1
            };

            HTTP.Name("Wizard Field MoveListItem Testi")
                .Post("api/wizard/fields/moveListItem", move)
                .ShouldBeOk();
        }
    }
}
