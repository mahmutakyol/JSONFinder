using Repositories.HTTP.Requests.ListTypes.Values;
using Tests.Core;

namespace Tests.Scenarios.ListTypes.Values
{
    class ListTypeValuesGetParentList : TestDecorator
    {

        public override string GetName()
        {
            return "namespace => " + this.GetType().Namespace + ", class => " + this.GetType().Name;
        }

        public override void Execute()
        {

            GetParentList parent = new GetParentList()
            {
                current = 0,
                typeId = 1
            };

            HTTP.Name("List Type Values GetParentList Testi")
                .Post("api/listType/values/getParentList", parent)
                .ShouldBeOk();
        }
    }
}
