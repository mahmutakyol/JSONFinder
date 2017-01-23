using Repositories.HTTP.Requests.Lists.System.City;
using Tests.Core;

namespace Tests.Scenarios.Lists.System.City
{
    class ListsSystemCityCreate : TestDecorator
    {

        public override string GetName()
        {
            return "namespace => " + this.GetType().Namespace + ", class => " + this.GetType().Name;
        }

        public override void Execute()
        {
            Create create = new Create()
            {
                regionId = 1,
                referenceId = 1,
                code = "code",
                name = "name"
            };

            HTTP.Name("List System City Create Testi")
                .Post("api/list/systems/cities/create", create)
                .ShouldBeOk();

        }
    }
}
