using Tests.Core;

namespace Tests.Scenarios.Wizards
{
    class WizardsGetById : TestDecorator
    {

        public override string GetName()
        {
            return "namespace => " + this.GetType().Namespace + ", class => " + this.GetType().Name;
        }

        public override void Execute()
        {

            int id = 1;

            HTTP.Name("Wizard GetById Testi")
                .Get("api/wizards/" + id, id)
                .ShouldBeOk();
        }
    }
}
