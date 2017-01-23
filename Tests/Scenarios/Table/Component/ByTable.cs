using Repositories.HTTP.Requests.Table.Component;
using Repositories.Models;
using System;
using System.Collections.Generic;
using Tests.Core;

namespace Tests.Scenarios.Table.Component
{
    class TableComponentByTable : TestDecorator
    {

        public override string GetName()
        {
            return "namespace => " + this.GetType().Namespace + ", class => " + this.GetType().Name;
        }

        public override void Execute()
        {
            Get get = new Get()
            {
                tableId = Config.data["authors_table_id"]
            };

            dynamic components = HTTP.Name("Table Component ByTable Testsi")
                .Post("api/table/components/byTable", get)
                .ShouldBeOk()
                .Fetch("");
        }
    }
}
