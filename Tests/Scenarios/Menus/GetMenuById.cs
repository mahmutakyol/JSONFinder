using Tests.Core;

namespace Tests.Scenarios.Menus
{
    class MenusGetMenuById : TestDecorator
    {

        public override string GetName()
        {
            return "namespace => " + this.GetType().Namespace + ", class => " + this.GetType().Name;
        }

        public override void Execute()
        {
            int id = 1;

            HTTP.Name("Menus GetMenuById Testi")
                .Get("api/menus/getmenubyid?id=" + id, id)
                .ShouldBeOk();
        }
    }
}
