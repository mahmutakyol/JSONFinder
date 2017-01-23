using Tests.Core;

namespace Tests.Scenarios.Menus
{
    class MenusGetParentMenusX : TestDecorator
    {

        public override string GetName()
        {
            return "namespace => " + this.GetType().Namespace + ", class => " + this.GetType().Name;
        }

        public override void Execute()
        {

            HTTP.Name("Menus GetParentMenusX Testi")
                .Get("api/menus/getParentMenusx")
                .ShouldBeOk();
        }

    }
}
