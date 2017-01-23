using Repositories.HTTP.Requests.Lists.System.Region;
using Tests.Core;

namespace Tests.Scenarios.Lists.System.Region
{
    class ListsSystemRegionUpdate : TestDecorator
    {

        public override string GetName()
        {
            return "namespace => " + this.GetType().Namespace + ", class => " + this.GetType().Name;
        }

        public override void Execute()
        {
            Update update = new Update()
            {
                countryId = 1,
                referenceId = 1,
                code = "code",
                name = "name"
            };

            HTTP.Name("List System Region Update Testi")
                .Post("api/list/systems/regions/update", update)
                .ShouldBeOk();
        }
    }
}
