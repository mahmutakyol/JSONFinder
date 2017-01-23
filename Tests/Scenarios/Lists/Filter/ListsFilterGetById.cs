using Repositories.HTTP.Requests.Lists.Filter;
using Tests.Core;

namespace Tests.Scenarios.Lists.Filter
{
    class ListsFilterGetById : TestDecorator
    {

        public override string GetName()
        {
            return "namespace => " + this.GetType().Namespace + ", class => " + this.GetType().Name;
        }

        public override void Execute()
        {
            GetById id = new GetById()
            {
                id = 1
            };

            HTTP.Name("List Filter GetById Testi")
                .Post("api/lists/filters/getById", id)
                .ShouldBeOk();
        }
    }
}
