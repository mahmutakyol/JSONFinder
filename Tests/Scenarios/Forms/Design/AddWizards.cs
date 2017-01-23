using Repositories.HTTP.Requests.Forms.Design;
using System.Collections.Generic;
using Tests.Core;

namespace Tests.Scenarios.Forms.Design
{
    class FormDesignAddWizards : TestDecorator
    {

        public override string GetName()
        {
            return "namespace => " + this.GetType().Namespace + ", class => " + this.GetType().Name;
        }

        public override void Execute()
        {

            AddWizard wizard = new AddWizard();
            List<int> wizardIds = new List<int>();

            wizardIds.Add(Config.data["wizard_id"]);
            wizard.formId = Config.data["form_id"];
            wizard.wizardIds = wizardIds; 

            Config.data["form_wizard_id"] = HTTP.Name("Form Design Add Wizard Test")
                .Post("api/forms/design/addWizards", wizard)
                .ShouldBeOk()
                .FetchAsInt("[L].id");
        }
    }
}
