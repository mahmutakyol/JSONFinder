using Tests.Core;

namespace Tests.Scenarios.Lists.System.District
{
    class ListsSystemDistrictInit : TestDecorator
    {

        public override string GetName()
        {
            return "namespace => " + this.GetType().Namespace + ", class => " + this.GetType().Name;
        }

        public override void Execute()
        {
            HTTP.Name("List System District Init Testi")
                .Get("api/list/systems/district/init")
                .ShouldBeOk();
        }
    }
}
