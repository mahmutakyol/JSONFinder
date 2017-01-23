using Repositories.Models;
using Tests.Core;

namespace Tests.Scenarios.Menus
{
    class MenusDeleteMenu : TestDecorator
    {

        public override string GetName()
        {
            return "namespace => " + this.GetType().Namespace + ", class => " + this.GetType().Name;
        }

        public override void Execute()
        {
            sys_menus menu = new sys_menus();

            HTTP.Name("Menus DeleteMenu Testi")
                .Post("api/menus/deleteMenu", menu)
                .ShouldBeOk();
        }
    }
}
