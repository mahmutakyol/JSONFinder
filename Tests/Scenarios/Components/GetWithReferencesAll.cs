using Tests.Core;

namespace Tests.Scenarios.Components
{
    class ComponentsGetWithReferencesAll : TestDecorator
    {

        public override string GetName()
        {
            return "namespace => " + this.GetType().Namespace + ", class => " + this.GetType().Name;
        }

        public override void Execute()
        {

            HTTP.Name("Component GetWithReferencesAll")
                .Get("api/componentsWithReferences")
                .ShouldBeOk();
        }
    }
}
