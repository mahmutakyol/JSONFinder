using Repositories.HTTP.Requests.Wizards;
using System.Collections.Generic;
using Tests.Core;

namespace Tests.Scenarios.Wizards.Posts
{
    class WizardPostBook : TestDecorator
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
                description = "Book registration",
                name = "my_book_registration_wizard",
                tableIds = new List<int>()
                {
                    (int)Config.data["books_table_id"]
                },
                type = "classic"
            };

            Config.data["book_registration_wizard_id"] = HTTP.Name("Wizard Book Registration Post Testi")
                .Post("api/wizards", create)
                .ShouldBeOk()
                .FetchAsInt("id");
        }
    }
}
