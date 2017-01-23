using Repositories.HTTP.Requests.Lists.System.Country;
using Tests.Core;

namespace Tests.Scenarios.Lists.System.Country
{
    class ListsSystemCountriesDelete : TestDecorator
    {

        public override string GetName()
        {
            return "namespace => " + this.GetType().Namespace + ", class => " + this.GetType().Name;
        }

        public override void Execute()
        {
            Delete delete = new Delete()
            {
                code = "code"
            };

            HTTP.Name("List System Countries Delete Testi")
                .Post("api/list/systems/countries/delete", delete)
                .ShouldBeOk();
        }
    }
}
