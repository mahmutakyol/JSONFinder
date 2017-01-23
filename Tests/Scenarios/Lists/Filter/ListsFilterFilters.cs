using Tests.Core;

namespace Tests.Scenarios.Lists.Filter
{
    class ListsFilterFilters : TestDecorator
    {

        public override string GetName()
        {
            return "namespace => " + this.GetType().Namespace + ", class => " + this.GetType().Name;
        }

        public override void Execute()
        {
            HTTP.Name("List Filter Filters Testi ")
                .Get("api/lists/filters")
                .ShouldBeOk();
        }
    }
}
