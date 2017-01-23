using Tests.Core;

namespace Tests.Scenarios.Lists.System.District
{
    class ListsSystemDistrictSelectBox : TestDecorator
    {

        public override string GetName()
        {
            return "namespace => " + this.GetType().Namespace + ", class => " + this.GetType().Name;
        }

        public override void Execute()
        {
            HTTP.Name("List System District Select Box Testi")
                .Get("api/list/systems/district/selectbox")
                .ShouldBeOk();
        }
    }
}
