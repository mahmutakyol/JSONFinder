using Repositories.HTTP.Requests.Lists.Filter;
using Tests.Core;

namespace Tests.Scenarios.Lists.Filter
{
    class ListsFilterUpdate : TestDecorator
    {

        public override string GetName()
        {
            return "namespace => " + this.GetType().Namespace + ", class => " + this.GetType().Name;
        }

        public override void Execute()
        {
            Update update = new Update()
            {
                code = "code",
                id = 1,
                name = "name",
                referenceListId = 1,
                targetListId = 1,
                targetListType = "type"
            };

            HTTP.Name("List Filter Update Testi")
                .Post("api/lists/filters/update", update)
                .ShouldBeOk();
        }
    }
}
