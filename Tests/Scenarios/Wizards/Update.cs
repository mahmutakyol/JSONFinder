using Repositories.HTTP.Requests.Wizards;
using Tests.Core;

namespace Tests.Scenarios.Wizards
{
    class WizardsUpdate : TestDecorator
    {

        public override string GetName()
        {
            return "namespace => " + this.GetType().Namespace + ", class => " + this.GetType().Name;
        }

        public override void Execute()
        {

            Update update = new Update()
            {
                action_button = true,
                description = "description",
                id = 1,
                name = "name",
                tableIds =
                {
                    1
                },
                type = "type"
            };

            HTTP.Name("Wizard Update Testi")
                .Post("api/wizards/update", update)
                .ShouldBeOk();
        }
    }
}
