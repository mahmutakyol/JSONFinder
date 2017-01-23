using Repositories.HTTP.Requests.Wizards.Fields.Validators;
using Tests.Core;

namespace Tests.Scenarios.Wizards.Fields.Validations
{
    class WizardsFieldsValidationsGetValidators : TestDecorator
    {

        public override string GetName()
        {
            return "namespace => " + this.GetType().Namespace + ", class => " + this.GetType().Name;
        }

        public override void Execute()
        {
            GetValidators validators = new GetValidators()
            {
                countryId = 1,
                fieldId = 1,
                regionId = 1,
                visualType = "visualType"
            };

            HTTP.Name("Wizard Field Validators GetValidators Testi")
                .Post("api/wizard_fields/validators/getValidators", validators)
                .ShouldBeOk();
        }
    }
}
