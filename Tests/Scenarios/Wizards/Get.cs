using Tests.Core;

namespace Tests.Scenarios.Wizards
{
    class WizardsGet : TestDecorator
    {

        public override string GetName()
        {
            return "namespace => " + this.GetType().Namespace + ", class => " + this.GetType().Name;
        }

        public override void Execute()
        {
            HTTP.Name("Wizard Get Testi")
                .Get("api/wizards")
                .ShouldBeOk();
        }
    }
}
