using Repositories.HTTP.Requests.Table.Component;
using Tests.Core;

namespace Tests.Scenarios.Table.Component
{
    class TableComponentRemoveIndex : TestDecorator
    {

        public override string GetName()
        {
            return "namespace => " + this.GetType().Namespace + ", class => " + this.GetType().Name;
        }

        public override void Execute()
        {
            AddIndex add = new AddIndex()
            {
                componentId = 1,
                tableId = 1
            };

            HTTP.Name("Table Component RemoveIndex Testi")
                .Post("api/table/components/removeIndex", add)
                .ShouldBeOk();
        }
    }
}
