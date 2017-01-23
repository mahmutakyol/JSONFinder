using Repositories.HTTP.Requests.Lists.System.District;
using Tests.Core;

namespace Tests.Scenarios.Lists.System.District
{
    class ListsSystemDistrictUpdate : TestDecorator
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
                cityId = 1,
                referenceId = 1,
                name = "name"
            };

            HTTP.Name("List System District Update Testi")
                .Post("api/list/systems/district/update", up)
                .ShouldBeOk();
        }
    }
}
