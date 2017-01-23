using Repositories.Wizard.Field.Validations;
using System.Collections.Generic;
using Tests.Core;

namespace Tests.Scenarios.Wizards.Fields.Validations
{
    class WizardsFieldsValidationsSave : TestDecorator
    {

        public override string GetName()
        {
            return "namespace => " + this.GetType().Namespace + ", class => " + this.GetType().Name;
        }

        public override void Execute()
        {
            Repositories.HTTP.Requests.Wizards.Fields.Validators.Save save = new Repositories.HTTP.Requests.Wizards.Fields.Validators.Save()
            {
                countryId = 0,
                fieldId = Config.data["wizard_field_id"],
                regionId = 0,
                visualStyle = 7,
                langId = 1,
                title = "",
                visualType = "SelectList",
                properties = new List<Property>()
                {
                    new Property()
                    {
                        parameter = "",
                        type = "ListSelect"
                    },
                    new Property()
                    {
                        parameter = "",
                        type = "ShowTitle"
                    }
                }
            };

            HTTP.Name("Wizard Field Validations Save Testi")
                .Post("api/wizard_fields/validators/save", save)
                .ShouldBeOk();
        }
    }
}
