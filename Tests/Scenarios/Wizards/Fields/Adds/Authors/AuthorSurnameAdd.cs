using Repositories.HTTP.Requests.Wizards.Fields;
using System.Collections.Generic;
using Tests.Core;

namespace Tests.Scenarios.Wizards.Fields.Adds.Authors
{
    class WizardFieldAuthorSurnameAdd : TestDecorator
    {

        public override string GetName()
        {
            return "namespace => " + this.GetType().Namespace + ", class => " + this.GetType().Name;
        }

        public override void Execute()
        {

            Create create = new Create()
            {
                ids = new System.Collections.Generic.List<TableComponentInput>() 
                {
                    new TableComponentInput() {
                        id = Config.data["authors_table_surname_component_id"],
                        isUserTable = false,
                        userTableType = null
                    }
                },
                wizardId = Config.data["author_registration_wizard_id"]
            };

            Config.data["author_wizard_surname_field_id"] = HTTP.Name("Wizard Field Add Testi")
                .Post("api/wizard/fields/add", create)
                .ShouldBeOk()
                .FetchAsInt("id");
        }
    }
}
