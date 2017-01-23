using Tests.Core;

namespace Tests.Scenarios.References
{
    class ReferencesGet : TestDecorator
    {
        public override string GetName()
        {
            return "namespace => " + this.GetType().Namespace + ", class => " + this.GetType().Name;
        }


        public override void Execute()
        {

            HTTP.Name("Reference Get Testi")
                .Get("api/references")
                .ShouldBeOk();
        }
    }
}
