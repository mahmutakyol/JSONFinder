using Repositories.HTTP.Requests.Forms.Design;
using Tests.Core;

namespace Tests.Scenarios.Forms.Design
{
    class FormDesignRemoveWizards : TestDecorator
    {

        public override string GetName()
        {
            return "namespace => " + this.GetType().Namespace + ", class => " + this.GetType().Name;
        }

        public override void Execute()
        {
            RemoveWizard remove = new RemoveWizard()
            {
                formWizardId = Config.data["form_wizard_id"],
                formId = Config.data["form_id"],
                wizardId = Config.data["wizard_id"],
                langId = 1,
                countryId = 1,
                regionId = 0
            };

            HTTP.Name("Form Design RemoveWizard Testi")
                .Post("api/forms/design/removeWizards", remove)
                .ShouldBeOk();
        }
    }
}
