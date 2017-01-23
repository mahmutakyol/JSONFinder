using Repositories.HTTP.Requests.Lists.System.District;
using Tests.Core;

namespace Tests.Scenarios.Lists.System.District
{
    class ListsSystemDistrictDelete : TestDecorator
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

            HTTP.Name("List System District Delete Testi ")
                .Post("api/list/systems/district/delete", delete)
                .ShouldBeOk();
        }
    }
}
