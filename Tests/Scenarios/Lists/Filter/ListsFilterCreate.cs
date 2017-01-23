using Repositories.HTTP.Requests.Lists.Filter;
using Tests.Core;

namespace Tests.Scenarios.Lists.Filter
{
    class ListsFilterCreate : TestDecorator
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
                name = "name",
                referenceListId = 1,
                targetListId = 1,
                targetListType = "type"
            };

            HTTP.Name("List Filter Create Testi")
                .Post("api/lists/filters/create", create)
                .ShouldBeOk();
        }
    }
}
