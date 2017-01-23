using Repositories.HTTP.Requests.Managers;
using Tests.Core;

namespace Tests.Scenarios.Managers
{
    class ManagersDelete : TestDecorator
    {

        public override string GetName()
        {
            return "namespace => " + this.GetType().Namespace + ", class => " + this.GetType().Name;
        }

        public override void Execute()
        {

            Delete delete = new Delete()
            {
                id = Config.data["admin_id"]
            };

            HTTP.Name("Managers Delete Test")
                .Post("api/managers/delete", delete)
                .ShouldBeOk();
        }
    }
}
