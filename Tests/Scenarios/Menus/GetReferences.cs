using Tests.Core;

namespace Tests.Scenarios.Menus
{
    class MenusGetReferences : TestDecorator
    {

        public override string GetName()
        {
            return "namespace => " + this.GetType().Namespace + ", class => " + this.GetType().Name;
        }

        public override void Execute()
        {

            int id = 1;

            HTTP.Name("Menus GetReferences Testi")
                .Get("api/menus/getreferences?id=" + id, id)
                .ShouldBeOk();
        }
    }
}
