using Tests.Core;

namespace Tests.Scenarios.Table.Deletes
{
    class TableDeleteRent :  TestDecorator
    {

        public override string GetName()
        {
            return "namespace => " + this.GetType().Namespace + ", class => " + this.GetType().Name;
        }

        public override void Execute()
        {
            HTTP.Name("Table Delete Testi")
                .Get("api/tables/delete/" + Config.data["rents_table_id"])
                .ShouldBeOk();
        }
    }
}
