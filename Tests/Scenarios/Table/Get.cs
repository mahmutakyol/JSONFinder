using Tests.Core;

namespace Tests.Scenarios.Table
{
    class TablesGet : TestDecorator
    {

        public override string GetName()
        {
            return "namespace => " + this.GetType().Namespace + ", class => " + this.GetType().Name;
        }

        public override void Execute()
        {

            HTTP.Name("Table Get Testi")
                .Get("api/tables")
                .ShouldBeOk();
        }
    }
}
