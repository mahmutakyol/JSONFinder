using Repositories.HTTP.Requests.Table;
using System.Collections.Generic;
using Tests.Core;

namespace Tests.Scenarios.Table
{
    class TablesPost : TestDecorator
    {
        public override string GetName()
        {
            return "namespace => " + this.GetType().Namespace + ", class => " + this.GetType().Name;
        }

        public override void Execute()
        {
            string name = GetCode();
            Create create = new Create()
            {
                description = "description",
                name = name
            };

            List<string> paths = new List<string>()
            {
                "id",
                "is_related_table"
            };

            Dictionary<string, dynamic> value = HTTP.Name("Table Post Testi")
                .Post("api/tables", create)
                .ShouldBeOk()
                .ShouldEqual("table_name", "usr_" + name)
                .ShouldEqual("description", "description")
                .FetchAsDictionary(paths);

            Config.data["table_id"] = value["id"];
            Config.data["is_related_table"] = value["is_related_table"];
        }
    }
}
