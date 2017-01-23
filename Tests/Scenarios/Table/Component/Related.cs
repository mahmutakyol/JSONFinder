using Repositories.HTTP.Requests.Table.Component;
using Tests.Core;

namespace Tests.Scenarios.Table.Component
{
    class TableComponentRelated : TestDecorator
    {

        public override string GetName()
        {
            return "namespace => " + this.GetType().Namespace + ", class => " + this.GetType().Name;
        }
        public override void Execute()
        {

            Get get = new Get()
            {
                tableId = 1
            };

            HTTP.Name("Table Component Related Testi")
                .Post("api/table/components/related", get)
                .ShouldBeOk();

        }
    }
}
