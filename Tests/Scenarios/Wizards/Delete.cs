using Tests.Core;

namespace Tests.Scenarios.Wizards
{
    class WizardsDelete : TestDecorator
    {

        public override string GetName()
        {
            return "namespace => " + this.GetType().Namespace + ", class => " + this.GetType().Name;
        }

        public override void Execute()
        {
            HTTP.Name("Wizard Delete Testi")
                .Get("api/wizards/delete/" + Config.data["wizard_id"])
                .ShouldBeOk();
        }
    }
}
