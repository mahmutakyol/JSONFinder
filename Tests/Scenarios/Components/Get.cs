using Tests.Core;

namespace Tests.Scenarios.Components
{
    class ComponentsGet : TestDecorator
    {

        public override string GetName()
        {
            return "namespace => " + this.GetType().Namespace + ", class => " + this.GetType().Name;
        }

        public override void Execute()
        {

            HTTP.Name("Component Get Testi")
                .Get("api/components")
                .ShouldBeOk();
        }
    }
}
