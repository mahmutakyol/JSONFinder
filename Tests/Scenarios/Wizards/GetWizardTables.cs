using Repositories.HTTP.Requests.Wizards;
using Tests.Core;

namespace Tests.Scenarios.Wizards
{
    class WizardsGetWizardTables : TestDecorator
    {

        public override string GetName()
        {
            return "namespace => " + this.GetType().Namespace + ", class => " + this.GetType().Name;
        }

        public override void Execute()
        {
            GetWizardTables wizardTables = new GetWizardTables()
            {
                wizardId = 1
            };

            HTTP.Name("Wizard GetWizardTables Testi")
                .Post("api/wizards/tables", wizardTables)
                .ShouldBeOk();
        }
    }
}
