using Repositories.HTTP.Requests.Lists.System.District;
using Tests.Core;

namespace Tests.Scenarios.Lists.System.District
{
    class ListsSystemDistrictDistrict : TestDecorator
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
                cityId = 1,
                regionId = 1,
                referenceId = 1
            };

            HTTP.Name("List System District District Testi")
                .Post("api/list/systems/district", get)
                .ShouldBeOk();
        }
    }
}
