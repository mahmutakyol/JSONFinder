using Repositories.HTTP.Requests.Lists.System.Region;
using Tests.Core;

namespace Tests.Scenarios.Lists.System.Region
{
    class ListsSystemRegionDelete : TestDecorator
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

            HTTP.Name("List System Region Delete Testi")
                .Post("api/list/systems/regions/delete", delete)
                .ShouldBeOk();
        }
    }
}
