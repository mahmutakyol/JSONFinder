using Tests.Core;

namespace Tests.Scenarios.Menus
{
    class MenusGetFamilyTreeOfMenu : TestDecorator
    {
        public override string GetName()
        {
            return "namespace => " + this.GetType().Namespace + ", class => " + this.GetType().Name;
        }


        public override void Execute()
        {
            int menuId = 1;

            HTTP.Name("Menus GetFamilyTreeOfMenu Testi")
                .Get("api/menus/getfamilytreeofmenu?menuId=" + menuId, menuId)
                .ShouldBeOk();
        }
    }
}
