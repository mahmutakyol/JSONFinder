using Tests.Core;

namespace Tests.Scenarios.Wizards.Deletes
{
    class WizardDeleteBooks : TestDecorator
    {

        public override string GetName()
        {
            return "namespace => " + this.GetType().Namespace + ", class => " + this.GetType().Name;
        }

        public override void Execute()
        {
            HTTP.Name("Wizard Delete Testi")
                .Get("api/wizards/delete/" + Config.data["book_registration_wizard_id"])
                .ShouldBeOk();
        }
    }
}
