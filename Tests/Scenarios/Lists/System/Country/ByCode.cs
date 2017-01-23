using Tests.Core;

namespace Tests.Scenarios.Lists.System.Country
{
    class ListsSystemCountriesByCode : TestDecorator
    {

        public override string GetName()
        {
            return "namespace => " + this.GetType().Namespace + ", class => " + this.GetType().Name;
        }

        public override void Execute()
        {
            int code = 1;

            HTTP.Name("List System Counteries ByCode testi")
                .Get("api/list/systems/countries/" + code)
                .ShouldBeOk();
        }
    }
}
