using Tests.Core;

namespace Tests.Scenarios.ListTypes
{
    class ListTypesGetById : TestDecorator
    {

        public override string GetName()
        {
            return "namespace => " + this.GetType().Namespace + ", class => " + this.GetType().Name;
        }

        public override void Execute()
        {

            int id = 1;

            HTTP.Name("ListType GetById Testi")
                .Get("api/listTypes/" + id, id)
                .ShouldBeOk();
        }
    }
}
