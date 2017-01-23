using Repositories.HTTP.Requests.Lists.System.Language;
using Tests.Core;

namespace Tests.Scenarios.Lists.System.Language
{
    class ListsSystemLanguageCreate : TestDecorator
    {

        public override string GetName()
        {
            return "namespace => " + this.GetType().Namespace + ", class => " + this.GetType().Name;
        }

        public override void Execute()
        {
            Create create = new Create()
            {
                code = "code",
                name = "name"
            };

            HTTP.Name("List System Language Create Testi")
                .Post("api/list/systems/languages/create", create)
                .ShouldBeOk();
        }
    }
}
