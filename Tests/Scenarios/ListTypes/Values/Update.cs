using Repositories.HTTP.Requests.ListTypes.Values;
using Tests.Core;

namespace Tests.Scenarios.ListTypes
{
    class ListTypeValuesUpdate : TestDecorator
    {

        public override string GetName()
        {
            return "namespace => " + this.GetType().Namespace + ", class => " + this.GetType().Name;
        }

        public override void Execute()
        {

            Update update = new Update()
            {
                id = 1,
                parentId = 1,
                title = "title",
                value = "value"
            };

            HTTP.Name("List Type Values Update Testi")
                .Post("api/listType/values/update", update)
                .ShouldBeOk();
        }
    }
}
