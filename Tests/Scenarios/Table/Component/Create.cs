using Repositories.HTTP.Requests.Table.Component;
using System.Collections.Generic;
using Tests.Core;

namespace Tests.Scenarios.Table.Component
{
    class TableComponentCreate : TestDecorator
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
                    Config.data["component_id"]
                },
                tableId = Config.data["table_id"]
            };

            Config.data["table_component_id"] = HTTP.Name("Table Component Create(component) Testi")
                .Post("api/table/component", collection)
                .ShouldBeOk()
                .ShouldEqual("component_id", Config.data["component_id"])
                .FetchAsInt("id");
        }
    }
}
