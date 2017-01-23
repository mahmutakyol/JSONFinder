using Repositories.HTTP.Requests.Table.Component;
using Tests.Core;

namespace Tests.Scenarios.Table.Component
{
    class TableComponentToggleRelatedField : TestDecorator
    {

        public override string GetName()
        {
            return "namespace => " + this.GetType().Namespace + ", class => " + this.GetType().Name;
        }

        public override void Execute()
        {
            ToggleRelatedField toggle = new ToggleRelatedField()
            {
                componentId = 1,
                tableId = 1
            };

            HTTP.Name("Table Component ToggleRelatedField Testi")
                .Post("api/table/components/toggleRelatedField", toggle)
                .ShouldBeOk();
        }
    }
}
