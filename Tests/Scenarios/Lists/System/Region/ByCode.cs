using Tests.Core;

namespace Tests.Scenarios.Lists.System.Region
{
    class ListsSystemRegionByCode : TestDecorator
    {

        public override string GetName()
        {
            return "namespace => " + this.GetType().Namespace + ", class => " + this.GetType().Name;
        }

        public override void Execute()
        {
            string code = "code";
            HTTP.Name("List System Region By Code Testi")
                .Get("api/list/systems/regions/" + code)
                .ShouldBeOk();
        }
    }
}
