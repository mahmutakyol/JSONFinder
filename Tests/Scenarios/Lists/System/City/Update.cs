using Repositories.HTTP.Requests.Lists.System.City;
using Tests.Core;

namespace Tests.Scenarios.Lists.System.City
{
    class ListsSystemCityUpdate : TestDecorator
    {

        public override string GetName()
        {
            return "namespace => " + this.GetType().Namespace + ", class => " + this.GetType().Name;
        }

        public override void Execute()
        {
            Update up = new Update()
            {
                id = 1,
                regionId = 1,
                referenceId = 1,
                name = "name"
            };

            HTTP.Name("Lists System City Update Testi")
                .Post("api/list/systems/cities/update", up)
                .ShouldBeOk();
        }
    }
}
