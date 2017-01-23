using Tests.Core;

namespace Tests.Scenarios.Menus
{
    class MenusGetMenusByParentId : TestDecorator
    {
        public override string GetName()
        {
            return "namespace => " + this.GetType().Namespace + ", class => " + this.GetType().Name;
        }

        public override void Execute()
        {
            int id = 1;

            HTTP.Name("Menus GetMenusByParentId Testi")
                .Get("api/menus/getmenusbyparentId?id=" + id)
                .ShouldBeOk();
        }
    }
}
