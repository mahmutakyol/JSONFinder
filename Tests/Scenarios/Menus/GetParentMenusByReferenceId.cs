using Tests.Core;

namespace Tests.Scenarios.Menus
{
    class MenusGetParentMenusByReferenceId : TestDecorator
    {

        public override string GetName()
        {
            return "namespace => " + this.GetType().Namespace + ", class => " + this.GetType().Name;
        }

        public override void Execute()
        {
            int id = 1;

            HTTP.Name("Menus GetParentMenusByReferenceId Testi")
                .Get("api/menus/getparentmenusbyreferanceid?id=" + id, id)
                .ShouldBeOk();

        }
    }
}
