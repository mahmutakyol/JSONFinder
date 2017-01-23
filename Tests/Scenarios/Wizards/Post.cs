using Repositories.HTTP.Requests.Wizards;
using System.Collections.Generic;
using Tests.Core;

namespace Tests.Scenarios.Wizards
{
    class WizardsPost : TestDecorator
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
                description = "my_test_description",
                name = "my_test_wizard",
                tableIds = new List<int>()
                {
                    (int)Config.data["table_id"]
                },
                type = "classic"
            };

            Config.data["wizard_id"] = HTTP.Name("Wizard Post Testi")
                .Post("api/wizards", create)
                .ShouldBeOk()
                .FetchAsInt("id");
        }
    }
}
