using Repositories.HTTP.Requests.Wizards;
using System.Collections.Generic;
using Tests.Core;

namespace Tests.Scenarios.Wizards.Posts
{
    class WizardPostAuthor : TestDecorator
    {

        public override string GetName()
        {
            return "namespace => " + this.GetType().Namespace + ", class => " + this.GetType().Name;
        }

        public override void Execute()
        {
            string code = GetCode();
            Create create = new Create()
            {
                action_button = false,
                code = code,
                description = "author registration",
                name = "my_author_registration_wizard",
                tableIds = new List<int>()
                {
                    (int)Config.data["authors_table_id"]
                },
                type = "classic"
            };

            Config.data["author_table_component_count"] = create.tableIds.Count;
            Config.data["author_registration_wizard_id"] = HTTP.Name("Wizard Author Registration Post Testi")
                .Post("api/wizards", create)
                .ShouldBeOk()
                .FetchAsInt("id");
        }
    }
}
