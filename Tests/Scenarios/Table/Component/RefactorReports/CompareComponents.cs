using Tests.Core;

namespace Tests.Scenarios.Table.Component.RefactorReports
{
    class TableComponentRefactorReportCompareComponents : TestDecorator
    {
        public override string GetName()
        {
            return "namespace => " + this.GetType().Namespace + ", class => " + this.GetType().Name;
        }


        public override void Execute()
        {

            int tableId = 1;
            HTTP.Name("Table Component CompareComponents Testi")
                .Get("api/ComponentRefactorReport/CompareComponents?tableId=" + tableId)
                .ShouldBeOk();
        }
    }
}
