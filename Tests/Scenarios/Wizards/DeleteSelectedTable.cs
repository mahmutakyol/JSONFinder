
using Tests.Core;

namespace Tests.Scenarios.Wizards
{
    class WizardsDeleteSelectedTable : TestDecorator
    {

        public override string GetName()
        {
            return "namespace => " + this.GetType().Namespace + ", class => " + this.GetType().Name;
        }

        public override void Execute()
        {
            int id = 1;

            HTTP.Name("Wizard DeleteSelectedTable Testi")
                .Get("api/wizards/deleteSelectedTable/" + id, id)
                .ShouldBeOk();
        }
    }
}
