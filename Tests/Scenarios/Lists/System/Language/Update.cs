using Repositories.HTTP.Requests.Lists.System.Language;
using Tests.Core;

namespace Tests.Scenarios.Lists.System.Language
{
    class ListsSystemLanguageUpdate : TestDecorator
    {

        public override string GetName()
        {
            return "namespace => " + this.GetType().Namespace + ", class => " + this.GetType().Name;
        }

        public override void Execute()
        {
            Update update = new Update()
            {
                id = 1,
                name = "name"
            };

            HTTP.Name("List System Language Update Testi")
                .Post("api/list/systems/languages/update", update)
                .ShouldBeOk();
        }

    }
}
