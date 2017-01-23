using Tests.Core;

namespace Tests.Scenarios.Menus
{
    class MenusGetAllMenus : TestDecorator
    {

        public override string GetName()
        {
            return "namespace => " + this.GetType().Namespace + ", class => " + this.GetType().Name;
        }

        public override void Execute()
        {
            HTTP.Name("Menus GetAllMenus Testi")
                .Get("api/menus/getAllMenus")
                .ShouldBeOk();
        }
    }
}
