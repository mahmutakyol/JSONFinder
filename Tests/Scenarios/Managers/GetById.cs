using Repositories.HTTP.Requests.Managers;
using Tests.Core;

namespace Tests.Scenarios.Managers
{
    class ManagersGetById : TestDecorator
    {

        public override string GetName()
        {
            return "namespace => " + this.GetType().Namespace + ", class => " + this.GetType().Name;
        }

        public override void Execute()
        {
            GetById id = new GetById()
            {
                id = 1
            };

            HTTP.Name("Managers GetById Testi")
                .Post("api/managers/getById", id)
                .ShouldBeOk();
        }
    }
}
