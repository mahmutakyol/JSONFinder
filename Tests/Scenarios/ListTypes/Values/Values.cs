using Repositories.HTTP.Requests.ListTypes.Values;
using Tests.Core;

namespace Tests.Scenarios.ListTypes.Values
{
    class ListTypeValuesValues : TestDecorator
    {

        public override string GetName()
        {
            return "namespace => " + this.GetType().Namespace + ", class => " + this.GetType().Name;
        }

        public override void Execute()
        {
            Index index = new Index()
            {
                current = 0,
                parentId = 1,
                typeId = 1
            };

            HTTP.Name("List Type Values Values Testi")
                .Post("api/listType/values", index)
                .ShouldBeOk();
        }
    }
}
