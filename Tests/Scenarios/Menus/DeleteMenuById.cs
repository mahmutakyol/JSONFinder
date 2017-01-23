using Tests.Core;

namespace Tests.Scenarios.Menus
{
    class MenusDeleteMenuById : TestDecorator
    {

        public override string GetName()
        {
            return "namespace => " + this.GetType().Namespace + ", class => " + this.GetType().Name;
        }

        public override void Execute()
        {
            int id = 1;

            HTTP.Name("Menus DeleteMenuById Testi")
                .Get("api/menus/deletemenubyid?id=" + id, id)
                .ShouldBeOk();
        }
    }
}
