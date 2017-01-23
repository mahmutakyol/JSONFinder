using Repositories.HTTP.Requests.Table.Component;
using Tests.Core;

namespace Tests.Scenarios.Table.Component
{
    class TableComponentByWizard : TestDecorator
    {

        public override string GetName()
        {
            return "namespace => " + this.GetType().Namespace + ", class => " + this.GetType().Name;
        }

        public override void Execute()
        {
            GetByWizard get = new GetByWizard()
            {
                tableId = 1,
                wizardId = 1
            };

            HTTP.Name("Table Component ByWizard Testi")
                .Post("api/table/components/byWizard", get)
                .ShouldBeOk();
        }
    }
}
