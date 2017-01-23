using Repositories.HTTP.Requests.Table;
using Tests.Core;

namespace Tests.Scenarios.Table
{
    class TablesUpdateName : TestDecorator
    {

        public override string GetName()
        {
            return "namespace => " + this.GetType().Namespace + ", class => " + this.GetType().Name;
        }

        public override void Execute()
        {

            UpdateName updateName = new UpdateName()
            {
                id = 1,
                value = "value"
            };

            HTTP.Name("Table UpdateName Testi")
                .Post("api/tables/update/name", updateName)
                .ShouldBeOk();
        }
    }
}
