using Tests.Core;

namespace Tests.Scenarios.Wizards.Fields
{
    class WizardsFieldsGet : TestDecorator
    {

        public override string GetName()
        {
            return "namespace => " + this.GetType().Namespace + ", class => " + this.GetType().Name;
        }

        public override void Execute()
        {
            int id = 1;
            HTTP.Name("Wizard Field Get Testi")
                .Get("api/wizard/fields/" + id, id)
                .ShouldBeOk();
        }
    }
}
