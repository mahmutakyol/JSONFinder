using Tests.Core;

namespace Tests.Scenarios.Wizards.Fields
{
    class WizardsFieldsInit : TestDecorator
    {

        public override string GetName()
        {
            return "namespace => " + this.GetType().Namespace + ", class => " + this.GetType().Name;
        }

        public override void Execute()
        {
            int wizardId = 1;

            HTTP.Name("Wizard Field Init Testi")
                .Get("api/wizard/fields/init/" + wizardId, wizardId)
                .ShouldBeOk();
        }
    }
}
