using Tests.Core;

namespace Tests.Scenarios.ListTypes
{
    class ListTypesRepair : TestDecorator
    {

        public override string GetName()
        {
            return "namespace => " + this.GetType().Namespace + ", class => " + this.GetType().Name;
        }

        public override void Execute()
        {

            HTTP.Name("ListType Repair Testi")
                .Get("api/listTypes/repair")
                .ShouldBeOk();
        }
    }
}
