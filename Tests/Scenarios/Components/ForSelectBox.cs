using Tests.Core;

namespace Tests.Scenarios.Components
{
    class ComponentsForSelectBox : TestDecorator
    {

        public override string GetName()
        {
            return "namespace => " + this.GetType().Namespace + ", class => " + this.GetType().Name;
        }

        public override void Execute()
        {

            HTTP.Name("Component GetForSelectBox Testi")
                .Get("api/components/forSelectBox")
                .ShouldBeOk();
        }
    }
}
