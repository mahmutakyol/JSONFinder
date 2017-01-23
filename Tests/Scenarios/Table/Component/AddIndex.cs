using Repositories.HTTP.Requests.Table.Component;
using Tests.Core;

namespace Tests.Scenarios.Table.Component
{
    class TableComponentAddIndex : TestDecorator
    {

        public override string GetName()
        {
            return "namespace => " + this.GetType().Namespace + ", class => " + this.GetType().Name;
        }

        public override void Execute()
        {
            AddIndex add = new AddIndex()
            {
                componentId = Config.data["table_component_id"],
                tableId = Config.data["table_id"]
            };

            Config.data["table_component_index_id"] = HTTP.Name("Table Component AddIndex Testi")
                .Post("api/table/components/addIndex", add)
                .ShouldBeOk()
                .FetchAsInt("[L].id");
        }
    }
}
