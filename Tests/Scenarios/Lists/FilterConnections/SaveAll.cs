using Repositories.HTTP.Requests.Lists.Filter.Connections;
using Tests.Core;

namespace Tests.Scenarios.Lists.FilterConnections
{
    class ListsFilterConnectionsSaveAll : TestDecorator
    {

        public override string GetName()
        {
            return "namespace => " + this.GetType().Namespace + ", class => " + this.GetType().Name;
        }

        public override void Execute()
        {
            FilterConnectionItem reference = new FilterConnectionItem()
            {
                id = 1,
                isDefault = false 
            };
            SaveAll saveAll = new SaveAll()
            {
                filterId = 1,
                targetValueId = 1,
                referenceIds = { reference }
            };

            HTTP.Name("List Filter Connections SaveAll Testi")
                .Post("api/lists/filterConnections/saveAll", saveAll)
                .ShouldBeOk();
        }
    }
}
