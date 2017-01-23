using Tests.Core;

namespace Tests.Scenarios.Lists.System.District
{
    class ListsSystemDistrictById : TestDecorator
    {

        public override string GetName()
        {
            return "namespace => " + this.GetType().Namespace + ", class => " + this.GetType().Name;
        }
        public override void Execute()
        {

            int id = 1;

            HTTP.Name("List System District ById Testi")
                .Get("api/list/systems/district/" + id)
                .ShouldBeOk();
        }
    }
}
