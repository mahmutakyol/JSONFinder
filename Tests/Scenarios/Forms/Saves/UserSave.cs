using Repositories.HTTP.Requests.Forms;
using System.Collections.Generic;
using Tests.Core;

namespace Tests.Scenarios.Forms.Saves
{
    class FormserSave : TestDecorator
    {

        public override string GetName()
        {
            return "namespace => " + this.GetType().Namespace + ", class => " + this.GetType().Name;
        }

        public override void Execute()
        {
            string code = GetCode();
            Locale locale = new Locale()
            {
                countryId = 0,
                langId = 1,
                regionId = 0
            };

            WizardInput input = new WizardInput()
            {
                code = code,
                components = new List<ComponentInput>()
                {
                    new ComponentInput()
                    {
                        fieldId = Config.data["wizard_field_id"],
                        listValueType = "ID",
                        value = "70",
                        valueArray = new List<int>()
                        {

                        }
                    }
                },
                id = Config.data["wizard_id"],
                locale = locale
            };

            Save save = new Save()
            {
                data = new List<List<WizardInput>>()
                {
                    new List<WizardInput>()
                    {
                        input
                    }
                },
                formId = Config.data["form_id"],
                locale = locale
            };

            HTTP.Name("Form Save Testi")
                .Post("api/forms/save", save)
                .ShouldBeOk();
        }
    }
}
