using Repositories.HTTP.Requests.Wizards;
using System.Collections.Generic;
using Tests.Core;

namespace Tests.Scenarios.Wizards.Posts
{
    class WizardPostUser : TestDecorator
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
                description = "user registration wizard",
                name = "my_user_registration_wizard",
                tableIds = new List<int>()
                {
                    (int)Config.data["user_table_id"]
                },
                type = "classic"
            };

            Config.data["user_registration_wizard_id"] = HTTP.Name("Wizard User Registration Post Testi")
                .Post("api/wizards", create)
                .ShouldBeOk()
                .FetchAsInt("id");
        }
    }
}
