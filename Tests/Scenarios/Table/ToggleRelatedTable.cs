using Repositories.HTTP.Requests.Table;
using Tests.Core;

namespace Tests.Scenarios.Table
{
    class TablesToggleRelatedTable : TestDecorator
    {

        public override string GetName()
        {
            return "namespace => " + this.GetType().Namespace + ", class => " + this.GetType().Name;
        }

        public override void Execute()
        {

            ToggleRelatedTable toggle = new ToggleRelatedTable()
            {
                tableId = Config.data["table_id"]
            };

            Config.data["is_related_table"] = HTTP.Name("Table ToggleRelatedTable Testi")
                .Post("api/tables/toggleRelatedTable", toggle)
                .ShouldBeOk()
                .FetchAsBool("is_related_table");
        }
    }
}
