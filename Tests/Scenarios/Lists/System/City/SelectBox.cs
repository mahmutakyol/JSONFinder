using Repositories.HTTP.Requests.Lists.System.City;
using Tests.Core;

namespace Tests.Scenarios.Lists.System.City
{
    class ListsSystemCitySelectBox : TestDecorator
    {

        public override string GetName()
        {
            return "namespace => " + this.GetType().Namespace + ", class => " + this.GetType().Name;
        }

        public override void Execute()
        {
            GetSelectBox get = new GetSelectBox()
            {
                regionId = 1
            };

            HTTP.Name("Lists System City GetSelectBox Testi")
                .Post("api/list/systems/cities/selectbox", get)
                .ShouldBeOk();
        }
    }
}
