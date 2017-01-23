using Repositories.HTTP.Requests.Lists.Filter.Connections;
using Tests.Core;

namespace Tests.Scenarios.Lists.FilterConnections
{
    class ListsFilterConnectionsInit : TestDecorator
    {

        public override string GetName()
        {
            return "namespace => " + this.GetType().Namespace + ", class => " + this.GetType().Name;
        }

        public override void Execute()
        {
            GetDetail detail = new GetDetail()
            {
                filterId = 1
            };

            HTTP.Name("List Filter Connection Init Testi")
                .Post("api/lists/filterConnections/init", detail)
                .ShouldBeOk();
        }
    }
}
