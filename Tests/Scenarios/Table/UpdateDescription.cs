using Repositories.HTTP.Requests.Table;
using Tests.Core;

namespace Tests.Scenarios.Table
{
    class TablesUpdateDescription : TestDecorator
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

            HTTP.Name("Table UpdateDescription Testi")
                .Post("api/tables/update/description", updateName)
                .ShouldBeOk();
        }
    }
}
