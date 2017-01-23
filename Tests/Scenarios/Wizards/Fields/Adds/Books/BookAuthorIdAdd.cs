using Repositories.HTTP.Requests.Wizards.Fields;
using System.Collections.Generic;
using Tests.Core;

namespace Tests.Scenarios.Wizards.Fields.Adds.Books
{
    class WizardFieldBookAuthorIdAdd : TestDecorator
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
                        id = Config.data["books_table_author_id_component_id"],
                        isUserTable = false,
                        userTableType = null
                    }
                },
                wizardId = Config.data["book_registration_wizard_id"]
            };

            Config.data["book_wizard_author_id_field_id"] = HTTP.Name("Wizard Field Add Testi")
                .Post("api/wizard/fields/add", create)
                .ShouldBeOk()
                .FetchAsInt("id");
        }
    }
}
