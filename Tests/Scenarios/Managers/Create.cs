using Repositories.HTTP.Requests.Managers;
using System.Collections.Generic;
using Tests.Core;

namespace Tests.Scenarios.Managers
{
    class ManagersCreate : TestDecorator
    {

        public override string GetName()
        {
            return "namespace => " + this.GetType().Namespace + ", class => " + this.GetType().Name;
        }

        public override void Execute()
        {
            string email = GetCode();
            string username = GetCode();
            Create create = new Create()
            {
                email = email + "@test.com",
                name = "my_test_name",
                password = "my_test_password",
                surname = "my_test_surname",
                username = "my_test_username_" + username
            };

            List<string> paths = new List<string>()
            {
                "id",
                "username",
                "password"
            };

            Dictionary<string, dynamic> adminValues = HTTP.Name("Managers Create Testi")
                .Post("api/managers/create", create)
                .ShouldBeOk()
                .FetchAsDictionary(paths);

            Config.data["admin_id"] = adminValues["id"];
            //Config.data["admin_username"] = adminValues["username"];
            //Config.data["admin_password"] = adminValues["password"];
        }
    }
}
