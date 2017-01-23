using Tests.Core;

namespace Tests.Scenarios.ListTypes
{
    class ListTypesGet : TestDecorator
    {

        public override string GetName()
        {
            return "namespace => " + this.GetType().Namespace + ", class => " + this.GetType().Name;
        }

        public override void Execute()
        {

            HTTP.Name("ListType Get Testi")
                .Get("api/listTypes")
                .ShouldBeOk();
        }
    }
}
