using System;
using Tests.Core;

namespace Tests.Scenarios.Auth
{
    class Login: TestDecorator
    {

        public override string GetName()
        {
            return "namespace => " + this.GetType().Namespace + ", class => " + this.GetType().Name;
        }

        public override void Execute()
        {
            Repositories.HTTP.Requests.Auth.Auth login = new Repositories.HTTP.Requests.Auth.Auth();

            if (Config.data.ContainsKey("admin_id"))
            {
                login.password = Config.data["admin_password"];
                login.username = Config.data["admin_username"];
            }
            else
            {
                login.password = "poli1234";
                login.username = "kontrol";
            }

            string token = HTTP.Name("Login testi")
                .Post("api/auth/login", login)
                .ShouldBeOk()
                .ShouldContain("token")
                .GetToken();

            Config.SetHeader("Authorization", token);
            
        }

    }
    class LoginResponse
    {
        public string token { get; set; }
    }
}
