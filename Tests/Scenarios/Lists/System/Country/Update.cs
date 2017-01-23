using Repositories.HTTP.Requests.Lists.System.Country;
using Tests.Core;

namespace Tests.Scenarios.Lists.System.Country
{
    class ListsSystemCountriesUpdate : TestDecorator
    {

        public override string GetName()
        {
            return "namespace => " + this.GetType().Namespace + ", class => " + this.GetType().Name;
        }

        public override void Execute()
        {
            Update up = new Update()
            {
                code = "code",
                name = "name",
                referenceId = 1
            };

            HTTP.Name("List System Countries Update Testi")
                .Post("api/list/systems/countries/update", up)
                .ShouldBeOk();
        }
    }
}
