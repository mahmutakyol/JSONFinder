using Repositories.HTTP.Requests.Lists.System.Region;
using Tests.Core;

namespace Tests.Scenarios.Lists.System.Region
{
    class ListsSystemRegionRegions : TestDecorator
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
                referenceId = 1
            };

            HTTP.Name("List System Region Regions Testi")
                .Post("api/list/systems/regions", get)
                .ShouldBeOk();
        }
    }
}
