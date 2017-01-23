using Tests.Core;

namespace Tests.Scenarios.Lists.System.Country
{
    class ListsSystemCountriesCountries : TestDecorator
    {

        public override string GetName()
        {
            return "namespace => " + this.GetType().Namespace + ", class => " + this.GetType().Name;
        }

        public override void Execute()
        {
            HTTP.Name("Lists System Countries Countries Testii")
                .Post("api/list/systems/countries")
                .ShouldBeOk();
        }
    }
}
