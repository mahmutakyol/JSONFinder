using Tests.Core;

namespace Tests.Scenarios.Table.Component.RefactorReports
{
    class TableRefactorReportsGetNotExistInLogTable : TestDecorator
    {

        public override string GetName()
        {
            return "namespace => " + this.GetType().Namespace + ", class => " + this.GetType().Name;
        }

        public override void Execute()
        {
            HTTP.Name("Table Refactor Reports GetNotExistInLogTable Testi")
                .Get("api/TableRefactorReport/GetNotExistInLogTable")
                .ShouldBeOk();
        }
    }
}
