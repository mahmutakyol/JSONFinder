using Repositories.HTTP.Requests.Lists.System.Region;
using Tests.Core;

namespace Tests.Scenarios.Lists.System.Region
{
    class ListsSystemRegionSelectBox : TestDecorator
    {

        public override string GetName()
        {
            return "namespace => " + this.GetType().Namespace + ", class => " + this.GetType().Name;
        }

        public override void Execute()
        {
            GetSelectBox gsb = new GetSelectBox()
            {
                countryId = 1
            };

            HTTP.Name("List System Region SelectBox Testi")
                .Post("api/list/systems/regions/selectbox", gsb)
                .ShouldBeOk();
        }
    }
}
