using Tests.Core;

namespace Tests.Scenarios.Table
{
    class TablesGetRelated : TestDecorator
    {

        public override string GetName()
        {
            return "namespace => " + this.GetType().Namespace + ", class => " + this.GetType().Name;
        }

        public override void Execute()
        {

            var test = HTTP.Name("Table GetRelated Testi")
                .Get("api/tables/related")
                .ShouldBeOk()
                .Fetch("");

            foreach (var item in test)
            {
                var name = item.table_name;
            }
        }
    }
}
