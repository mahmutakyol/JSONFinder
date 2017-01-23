using Repositories.HTTP.Requests.Table.Component;
using Tests.Core;

namespace Tests.Scenarios.Table.Component
{
    class TableComponentToggleUnique : TestDecorator
    {

        public override string GetName()
        {
            return "namespace => " + this.GetType().Namespace + ", class => " + this.GetType().Name;
        }

        public override void Execute()
        {
            ToggleUnique toggle = new ToggleUnique()
            {
                componentId = 1,
                tableId = 1
            };

            HTTP.Name("Table Component ToggleUnique Testi")
                .Post("api/table/components/toggleUnique", toggle)
                .ShouldBeOk();
        }
    }
}
