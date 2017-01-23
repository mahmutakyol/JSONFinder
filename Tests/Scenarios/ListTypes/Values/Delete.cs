using Repositories.HTTP.Requests.ListTypes.Values;
using Tests.Core;

namespace Tests.Scenarios.ListTypes.Values
{
    class ListTypeValuesDelete : TestDecorator
    {

        public override string GetName()
        {
            return "namespace => " + this.GetType().Namespace + ", class => " + this.GetType().Name;
        }

        public override void Execute()
        {
            Delete delete = new Delete()
            {
                current = 0,
                id = 1,
                list_id = 1,
                parentId = 1
            };

            HTTP.Name("List Type Values Delete Testi")
                .Post("api/listType/values/delete", delete)
                .ShouldBeOk();
        }
    }
}
