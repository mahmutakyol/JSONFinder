using Repositories.HTTP.Requests.Lists.System.Region;
using Tests.Core;

namespace Tests.Scenarios.Lists.System.Region
{
    class ListsSystemRegionToggleDefault : TestDecorator
    {

        public override string GetName()
        {
            return "namespace => " + this.GetType().Namespace + ", class => " + this.GetType().Name;
        }

        public override void Execute()
        {
            ToggleDefault toggle = new ToggleDefault()
            {
                countryId = 1,
                referenceId = 1,
                regionId = 1
            };

            HTTP.Name("List System Region ToggleDefault Testi")
                .Post("api/list/systems/regions/toggleDefault", toggle)
                .ShouldBeOk();
        }
    }
}
