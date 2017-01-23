using Repositories.HTTP.Requests.ListTypes.Values;
using Tests.Core;

namespace Tests.Scenarios.ListTypes.Values
{
    class ListTypeValuesAll : TestDecorator
    {

        public override string GetName()
        {
            return "namespace => " + this.GetType().Namespace + ", class => " + this.GetType().Name;
        }

        public override void Execute()
        {

            GetAllValues values = new GetAllValues()
            {
                listId = 1
            };

            HTTP.Name("List Type Values All Testi")
                .Post("api/listType/values/all", values)
                .ShouldBeOk();
        }
    }
}
