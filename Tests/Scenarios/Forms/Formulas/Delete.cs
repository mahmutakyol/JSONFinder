using Repositories.HTTP.Requests.Forms.Formulas;
using Tests.Core;

namespace Tests.Scenarios.Forms.Formulas
{
    class FormFormulasDelete : TestDecorator
    {

        public override string GetName()
        {
            return "namespace => " + this.GetType().Namespace + ", class => " + this.GetType().Name;
        }

        public override void Execute()
        {
            Delete delete = new Delete()
            {
                commandId = 369,
                formWizardId = 78,
                wizardFieldId = 188
            };

            HTTP.Name("Form Formulas Delete Testi")
                .Post("api/forms/formulas/delete", delete)
                .ShouldBeOk();
        }
    }
}
