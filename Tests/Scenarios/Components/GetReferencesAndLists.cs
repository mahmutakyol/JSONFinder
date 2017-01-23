using Tests.Core;

namespace Tests.Scenarios.Components
{
    class ComponentsGetReferencesAndLists : TestDecorator
    {

        public override string GetName()
        {
            return "namespace => " + this.GetType().Namespace + ", class => " + this.GetType().Name;
        }

        public override void Execute()
        {

            HTTP.Name("Component GetReferencesAndLists")
                .Get("api/getReferencesAndLists")
                .ShouldBeOk();
        }
    }
}
