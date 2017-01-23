using Repositories.HTTP.Requests.Lists.System.Country;
using Tests.Core;

namespace Tests.Scenarios.Lists.System.Country
{
    class ListsSystemCountriesCreate : TestDecorator
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
                name = "name",
                referenceId = 1
            };

            HTTP.Name("Lists System Countries Create Testi")
                .Post("api/list/systems/countries/create", create)
                .ShouldBeOk();
        }
    }
}
