using Repositories.HTTP.Requests.Table.Component;
using Tests.Core;

namespace Tests.Scenarios.Table.Component
{
    class TableComponentAddRelated : TestDecorator
    {

        public override string GetName()
        {
            return "namespace => " + this.GetType().Namespace + ", class => " + this.GetType().Name;
        }

        public override void Execute()
        {
            AddRelated add = new AddRelated()
            {
                mainTableId = 1,
                relatedFieldId = 1,
                relatedTableId = 1
            };

            HTTP.Name("Table Component AddRelated Testi")
                .Post("api/table/components/addRelated", add)
                .ShouldBeOk();
        }

    }
}
