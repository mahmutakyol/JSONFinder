using Repositories.HTTP.Requests.Managers;
using Tests.Core;

namespace Tests.Scenarios.Managers
{
    class ManagersUpdate : TestDecorator
    {

        public override string GetName()
        {
            return "namespace => " + this.GetType().Namespace + ", class => " + this.GetType().Name;
        }

        public override void Execute()
        {
            Update update = new Update()
            {
                email = "email",
                id = 1,
                name = "name",
                password = "password",
                surname = "surname",
                username = "username"
            };

            HTTP.Name("Managers Update Testi")
                .Post("api/managers/edit", update)
                .ShouldBeOk();
        }
    }
}
