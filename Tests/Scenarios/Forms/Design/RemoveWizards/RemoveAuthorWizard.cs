using Repositories.HTTP.Requests.Forms.Design;
using Tests.Core;

namespace Tests.Scenarios.Forms.Design.RemoveWizards
{
    class FormDesignRemoveAuthorWizard : TestDecorator
    {

        public override string GetName()
        {
            return "namespace => " + this.GetType().Namespace + ", class => " + this.GetType().Name;
        }

        public override void Execute()
        {
            RemoveWizard remove = new RemoveWizard()
            {
                formWizardId = Config.data["form_author_wizard_id"],
                formId = Config.data["author_register_form_id"],
                wizardId = Config.data["author_registration_wizard_id"],
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
