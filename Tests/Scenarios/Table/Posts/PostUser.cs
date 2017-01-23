using Repositories.HTTP.Requests.Table;
using System.Collections.Generic;
using Tests.Core;

namespace Tests.Scenarios.Table.Posts
{ 
    class TablePostUser : TestDecorator
    {

        public override string GetName()
        {
            return "namespace => " + this.GetType().Namespace + ", class => " + this.GetType().Name;
        }

        public override void Execute()
        {

            string name = "test_users";

            Create create = new Create()
            {
                description = "user table",
                name = name
            };

            List<string> paths = new List<string>()
            {
                "id",
                "is_related_table"
            };

            Dictionary<string, dynamic> value = HTTP.Name("User Table Post Testi")
                .Post("api/tables", create)
                .ShouldBeOk()
                .FetchAsDictionary(paths);

            Config.data["user_table_id"] = value["id"];
            Config.data["user_table_is_related_table"] = value["is_related_table"];
        }
    }
}
