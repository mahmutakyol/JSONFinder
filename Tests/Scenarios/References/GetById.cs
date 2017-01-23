using Tests.Core;

namespace Tests.Scenarios.References
{
    class ReferencesGetById : TestDecorator
    {

        public override string GetName()
        {
            return "namespace => " + this.GetType().Namespace + ", class => " + this.GetType().Name;
        }

        public override void Execute()
        {

            int id = 1;

            HTTP.Name("Reference GetById Testi")
                .Get("api/references/" + id, id)
                .ShouldBeOk();
        }
    }
}
