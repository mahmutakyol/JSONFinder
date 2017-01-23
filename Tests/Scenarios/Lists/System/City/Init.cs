using Tests.Core;

namespace Tests.Scenarios.Lists.System.City
{
    class ListsSystemCityInit : TestDecorator
    {

        public override string GetName()
        {
            return "namespace => " + this.GetType().Namespace + ", class => " + this.GetType().Name;
        }

        public override void Execute()
        {
            HTTP.Name("Lists System City Init Testi")
                .Get("api/list/systems/cities/init")
                .ShouldBeOk();
        }
    }
}
