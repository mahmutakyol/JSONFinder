using Tests.Core;

namespace Tests.Scenarios.ListTypes
{
    class ListTypesDelete : TestDecorator
    {

        public override string GetName()
        {
            return "namespace => " + this.GetType().Namespace + ", class => " + this.GetType().Name;
        }

        public override void Execute()
        {
            HTTP.Name("ListType Delete Testi")
                .Get("api/listTypes/delete/" + Config.data["list_id"])
                .ShouldBeOk();
        }
    }
}
