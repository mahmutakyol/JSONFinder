using Repositories.HTTP.Requests.ListTypes.Values;
using Tests.Core;

namespace Tests.Scenarios.ListTypes.Values
{
    class ListTypeValuesGetOptionsByValue : TestDecorator
    {

        public override string GetName()
        {
            return "namespace => " + this.GetType().Namespace + ", class => " + this.GetType().Name;
        }

        public override void Execute()
        {
            GetOptionsByValue value = new GetOptionsByValue()
            {
                childId = 1,
                listId = 1,
                selectedId = 1
            };

            HTTP.Name("List Type Values GetOptionsByValue")
                .Post("api/listType/getOptionsByValue", value)
                .ShouldBeOk();
        }
    }
}
