using Repositories.Models;
using Tests.Core;

namespace Tests.Scenarios.Menus
{
    class MenusCreate : TestDecorator
    {

        public override string GetName()
        {
            return "namespace => " + this.GetType().Namespace + ", class => " + this.GetType().Name;
        }

        public override void Execute()
        {
            sys_menus menu = new sys_menus();

            HTTP.Name("Menus Create Testi")
                .Post("api/menus/create", menu)
                .ShouldBeOk();
        }
    }
}
