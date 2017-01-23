using Repositories.HTTP.Requests.Lists.System.City;
using Tests.Core;

namespace Tests.Scenarios.Lists.System.City
{
    class ListsSystemCityDelete : TestDecorator
    {

        public override string GetName()
        {
            return "namespace => " + this.GetType().Namespace + ", class => " + this.GetType().Name;
        }

        public override void Execute()
        {
            Delete delete = new Delete()
            {
                id = 1
            };

            HTTP.Name("Lists System City Delete Testi")
                .Post("api/list/systems/cities/delete", delete)
                .ShouldBeOk();
        }
    }
}
