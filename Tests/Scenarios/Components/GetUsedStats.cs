using Tests.Core;

namespace Tests.Scenarios.Components
{
    class ComponentsGetUsedStats : TestDecorator
    {

        public override string GetName()
        {
            return "namespace => " + this.GetType().Namespace + ", class => " + this.GetType().Name;
        }

        public override void Execute()
        {

            int id = 1;

            HTTP.Name("Component GetUsedStats Testi")
                .Get("api/components/getUsedStats/" + id, id)
                .ShouldBeOk();
        }
    }
}
