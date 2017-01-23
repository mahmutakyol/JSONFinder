using Repositories.HTTP.Requests.Forms.Design;
using System.Collections.Generic;
using Tests.Core;

namespace Tests.Scenarios.Forms.Design.AddWizards
{
    class FormDesignAddAuthorWizard : TestDecorator
    {

        public override string GetName()
        {
            return "namespace => " + this.GetType().Namespace + ", class => " + this.GetType().Name;
        }

        public override void Execute()
        {

            AddWizard wizard = new AddWizard();
            List<int> wizardIds = new List<int>();

            wizardIds.Add(Config.data["author_registration_wizard_id"]);
            wizard.formId = Config.data["author_register_form_id"];
            wizard.wizardIds = wizardIds;

            Config.data["form_author_wizard_id"] = HTTP.Name("Form Design Add Wizard Test")
                .Post("api/forms/design/addWizards", wizard)
                .ShouldBeOk()
                .FetchAsInt("[L].id");
        }
    }
}
