

using Repositories.Models;
using Tests.Core;

namespace Tests.Scenarios.Menus
{
    class MenusUpdateMenu : TestDecorator
    {

        public override string GetName()
        {
            return "namespace => " + this.GetType().Namespace + ", class => " + this.GetType().Name;
        }

        public override void Execute()
        {
            sys_menus entity = new sys_menus();

            HTTP.Name("Menus Update Menu Testi")
                .Post("api/menus/updateMenu", entity)
                .ShouldBeOk();
        }
    }
}
