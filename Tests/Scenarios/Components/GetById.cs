using Tests.Core;

namespace Tests.Scenarios.Components
{
    class ComponentsGetById : TestDecorator
    {

        public override string GetName()
        {
            return "namespace => " + this.GetType().Namespace + ", class => " + this.GetType().Name;
        }

        public override void Execute()
        {

            int id = 1;

            HTTP.Name("Component GetById Testi")
                .Get("api/components/" + id, id)
                .ShouldBeOk();

        }
    }
}
