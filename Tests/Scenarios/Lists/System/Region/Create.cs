using Repositories.HTTP.Requests.Lists.System.Region;
using Tests.Core;

namespace Tests.Scenarios.Lists.System.Region
{
    class ListsSystemRegionCreate : TestDecorator
    {

        public override string GetName()
        {
            return "namespace => " + this.GetType().Namespace + ", class => " + this.GetType().Name;
        }

        public override void Execute()
        {
            Create create = new Create()
            {
                code = "code",
                countryId = 1,
                name = "name",
                referenceId = 1
            };

            HTTP.Name("List System Region Create Testi")
                .Post("api/list/systems/regions/create", create)
                .ShouldBeOk();
        }

    }
}
