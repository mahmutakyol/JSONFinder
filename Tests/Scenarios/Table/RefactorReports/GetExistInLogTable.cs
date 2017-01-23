using Tests.Core;

namespace Tests.Scenarios.Table.RefactorReports
{
    class TableRefactorReportsGetExistInLogTable : TestDecorator
    {

        public override string GetName()
        {
            return "namespace => " + this.GetType().Namespace + ", class => " + this.GetType().Name;
        }

        public override void Execute()
        {
            HTTP.Name("Table Refactor Reports GetExistInLogTable Testi")
                .Get("api/TableRefactorReport/GetExistInLogTable")
                .ShouldBeOk();
        }
    }
}
