using Repositories.HTTP.Requests.Wizards.Fields.Conditions;
using Tests.Core;

namespace Tests.Scenarios.Wizards.Fields.Conditions
{
    class WizardFiledsConditionsGetListValues : TestDecorator
    {

        public override string GetName()
        {
            return "namespace => " + this.GetType().Namespace + ", class => " + this.GetType().Name;
        }

        public override void Execute()
        {
            GetListValues values = new GetListValues()
            {
                listId = 1,
                listType = "listType"
            };

            HTTP.Name("Wizard Filed Conditions GetListValues Testi")
                .Post("api/wizard_fields/conditions/getListValues", values)
                .ShouldBeOk();
        }
    }
}
