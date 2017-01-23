using Repositories.HTTP.Requests.Lists.Filter;
using Tests.Core;

namespace Tests.Scenarios.Lists.Filter
{
    class ListsFilterDelete : TestDecorator
    {
        public override string GetName()
        {
            return "namespace => " + this.GetType().Namespace + ", class => " + this.GetType().Name;
        }

        public override void Execute()
        {
            Delete delete = new Delete()
            {
                id = 1
            };

            HTTP.Name("List Filter Delete Testi ")
                .Post("api/lists/filters/delete", delete)
                .ShouldBeOk();
        }
    }
}
