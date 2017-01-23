using Tests.Core;

namespace Tests.Scenarios.Lists.System.City
{
    class ListsSystemCityCitiesById : TestDecorator
    {

        public override string GetName()
        {
            return "namespace => " + this.GetType().Namespace + ", class => " + this.GetType().Name;
        }

        public override void Execute()
        {

            int id = 1;

            HTTP.Name("Lists System City Cities ByID testi")
                .Get("api/list/systems/cities/" + id)
                .ShouldBeOk();
        }
    }
}
