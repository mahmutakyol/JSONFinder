using Tests.Core;

namespace Tests.Scenarios.Table
{
    class TablesDelete : TestDecorator
    {

        public override string GetName()
        {
            return "namespace => " + this.GetType().Namespace + ", class => " + this.GetType().Name;
        }

        public override void Execute()
        {
            HTTP.Name("Table Delete Testi")
                .Get("api/tables/delete/" + Config.data["table_id"])
                .ShouldBeOk();
        }
    }
}
