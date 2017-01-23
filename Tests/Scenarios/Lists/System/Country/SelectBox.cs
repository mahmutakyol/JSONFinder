using Tests.Core;

namespace Tests.Scenarios.Lists.System.Country
{
    class ListsSystemCountriesSelectBox : TestDecorator
    {

        public override string GetName()
        {
            return "namespace => " + this.GetType().Namespace + ", class => " + this.GetType().Name;
        }

        public override void Execute()
        {
            HTTP.Name("List System Countries SelectBox Testi")
                .Get("api/list/systems/countries/selectbox")
                .ShouldBeOk();
        }
    }
}
