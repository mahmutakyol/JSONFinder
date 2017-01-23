using Repositories.HTTP.Requests.Table.Component;
using Tests.Core;

namespace Tests.Scenarios.Table.Component
{
    class TableComponentTableComponentDelete : TestDecorator
    {

        public override string GetName()
        {
            return "namespace => " + this.GetType().Namespace + ", class => " + this.GetType().Name;
        }

        public override void Execute()
        {
            Delete delete = new Delete()
            {
                id = 1,
                tableId = 1
            };

            HTTP.Name("Table Component Delete Testi")
                .Post("api/table/components/delete", delete)
                .ShouldBeOk();
        }
    }
}
