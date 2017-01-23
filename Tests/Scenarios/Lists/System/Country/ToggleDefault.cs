using Repositories.HTTP.Requests.Lists.System.Country;
using Tests.Core;

namespace Tests.Scenarios.Lists.System.Country
{
    class ListsSystemCountriesToggleDefault : TestDecorator
    {

        public override string GetName()
        {
            return "namespace => " + this.GetType().Namespace + ", class => " + this.GetType().Name;
        }

        public override void Execute()
        {
            ToggleDefault toggle = new ToggleDefault()
            {
                id = 1
            };

            HTTP.Name("List System Countries ToggleDefault Testi")
                .Post("api/list/systems/countries/toggleDefault", toggle)
                .ShouldBeOk();
        }
    }
}
