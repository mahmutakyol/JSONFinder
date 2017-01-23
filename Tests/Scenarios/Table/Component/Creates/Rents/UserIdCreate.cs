using Repositories.HTTP.Requests.Table.Component;
using System.Collections.Generic;
using Tests.Core;

namespace Tests.Scenarios.Table.Component.Creates.Rents
{
    class TableComponentRentsUserIdCreate : TestDecorator
    {

        public override string GetName()
        {
            return "namespace => " + this.GetType().Namespace + ", class => " + this.GetType().Name;
        }

        public override void Execute()
        {
            Collection collection = new Collection()
            {
                ids = new List<int>()
                {
                    Config.data["user_id_component_id"]
                },
                tableId = Config.data["rents_table_id"]
            };
            
            Config.data["rents_table_user_id_component_id"] = HTTP.Name("Table Add Component Testi")
                .Post("api/table/component", collection)
                .ShouldBeOk()
                .FetchAsInt("id");
        }
    }
}
