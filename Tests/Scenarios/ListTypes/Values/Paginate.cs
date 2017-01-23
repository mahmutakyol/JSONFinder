using Repositories.HTTP.Requests.ListTypes.Values;
using Tests.Core;

namespace Tests.Scenarios.ListTypes.Values
{
    class ListTypeValuesPaginate : TestDecorator
    {

        public override string GetName()
        {
            return "namespace => " + this.GetType().Namespace + ", class => " + this.GetType().Name;
        }

        public override void Execute()
        {

            Index index = new Index()
            {
                current = 1,
                parentId = 1,
                typeId = 1
            };

            HTTP.Name("List Type Values Paginate Test")
                .Post("api/listType/paginate", index)
                .ShouldBeOk();
        }
    }
}
