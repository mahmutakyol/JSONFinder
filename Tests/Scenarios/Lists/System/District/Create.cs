using Repositories.HTTP.Requests.Lists.System.District;
using Tests.Core;

namespace Tests.Scenarios.Lists.System.District
{
    class ListsSystemDistrictCreate : TestDecorator
    {

        public override string GetName()
        {
            return "namespace => " + this.GetType().Namespace + ", class => " + this.GetType().Name;
        }

        public override void Execute()
        {
            Create create = new Create()
            {
                cityId = 1,
                referenceId = 1,
                code = "code",
                name = "name"
            };

            HTTP.Name("List System District Create Testi")
                .Post("api/list/systems/district/create", create)
                .ShouldBeOk();
        }
    }
}
