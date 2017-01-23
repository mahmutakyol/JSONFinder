using Tests.Core;

namespace Tests.Scenarios.Menus
{
    class MenusIsExistMenu : TestDecorator
    {

        public override string GetName()
        {
            return "namespace => " + this.GetType().Namespace + ", class => " + this.GetType().Name;
        }

        public override void Execute()
        {
            int id = 1;

            HTTP.Name("Menus IsExistMenu Testi")
                .Get("api/menus/isexistmenu?id=" + id, id)
                .ShouldBeOk();
        }
    }
}
