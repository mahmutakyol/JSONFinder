using Repositories.HTTP.Requests.Table;
using System.Collections.Generic;
using Tests.Core;

namespace Tests.Scenarios.Table.Posts
{
    class TablePostRent : TestDecorator
    {

        public override string GetName()
        {
            return "namespace => " + this.GetType().Namespace + ", class => " + this.GetType().Name;
        }

        public override void Execute()
        {
            string name = "test_rents";

            Create create = new Create()
            {
                description = "rents table",
                name = name
            };

            List<string> paths = new List<string>()
            {
                "id",
                "is_related_table"
            };

            Dictionary<string, dynamic> value = HTTP.Name("Rents Table Testi")
                .Post("api/tables", create)
                .ShouldBeOk()
                .FetchAsDictionary(paths);

            Config.data["rents_table_id"] = value["id"];
            Config.data["rents_table_is_related_table"] = value["is_related_table"];
        }
    }
}
