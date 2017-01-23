using Repositories.HTTP.Requests.Table;
using System.Collections.Generic;
using Tests.Core;

namespace Tests.Scenarios.Table.Posts
{
    class TablePostBooks : TestDecorator
    {

        public override string GetName()
        {
            return "namespace => " + this.GetType().Namespace + ", class => " + this.GetType().Name;
        }

        public override void Execute()
        {
            string name = "test_books";

            Create create = new Create()
            {
                description = "books table",
                name = name
            };

            List<string> paths = new List<string>()
            {
                "id",
                "is_related_table"
            };

            Dictionary<string, dynamic> value = HTTP.Name("Books Table Testi")
                .Post("api/tables", create)
                .ShouldBeOk()
                .FetchAsDictionary(paths);

            Config.data["books_table_id"] = value["id"];
            Config.data["books_table_is_related_table"] = value["is_related_table"];
        }
    }
}
