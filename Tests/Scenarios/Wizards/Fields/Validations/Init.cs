
using Repositories.HTTP.Requests.Wizards.Fields.Validators;
using Tests.Core;

namespace Tests.Scenarios.Wizards.Fields.Validations
{
    class WizardsFieldsValidationsInit : TestDecorator
    {

        public override string GetName()
        {
            return "namespace => " + this.GetType().Namespace + ", class => " + this.GetType().Name;
        }

        public override void Execute()
        {
            Init init = new Init()
            {
                countryId = 1,
                fieldId = 1,
                regionId = 1
            };

            HTTP.Name("Wizard Field Validations Init Testi")
                .Post("api/wizard_fields/validators/init", init)
                .ShouldBeOk();
        }
    }
}
