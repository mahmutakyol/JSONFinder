using Repositories.HTTP.Requests.Lists.System.City;
using Tests.Core;

namespace Tests.Scenarios.Lists.System.City
{
    class ListsSystemCityCities : TestDecorator
    {

        public override string GetName()
        {
            return "namespace => " + this.GetType().Namespace + ", class => " + this.GetType().Name;
        }

        public override void Execute()
        {
            Get get = new Get()
            {
                countryId = 1,
                regionId = 1,
                referenceId = 1
            };

            HTTP.Name("List Ststem City Cities Testi")
                .Post("api/list/systems/cities", get)
                .ShouldBeOk();
        }
    }
}
