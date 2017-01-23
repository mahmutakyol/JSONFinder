using Repositories.HTTP.Requests.Forms.Design;
using Tests.Core;

namespace Tests.Scenarios.Forms.Design.RemoveWizards
{
    class FormDesignRemoveBookWizard : TestDecorator
    {

        public override string GetName()
        {
            return "namespace => " + this.GetType().Namespace + ", class => " + this.GetType().Name;
        }

        public override void Execute()
        {
            RemoveWizard remove = new RemoveWizard()
            {
                formWizardId = Config.data["form_book_wizard_id"],
                formId = Config.data["book_registration_form_id"],
                wizardId = Config.data["book_registration_wizard_id"],
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
