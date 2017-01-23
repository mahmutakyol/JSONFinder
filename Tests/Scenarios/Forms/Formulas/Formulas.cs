using Repositories.HTTP.Requests.Forms.Formulas;
using Tests.Core;

namespace Tests.Scenarios.Forms.Formulas
{
    class FormFormulasFormulas : TestDecorator
    {

        public override string GetName()
        {
            return "namespace => " + this.GetType().Namespace + ", class => " + this.GetType().Name;
        }

        public override void Execute()
        {
            All all = new All()
            {
                formWizardId = 78,
                wizardFieldId = 188
            };

            HTTP.Name("Form Formulas Testi")
                .Post("api/forms/formulas", all)
                .ShouldBeOk();
        }
    }
}
