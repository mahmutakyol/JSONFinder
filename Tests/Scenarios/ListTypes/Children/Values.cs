using Repositories.Lists;
using Tests.Core;

namespace Tests.Scenarios.ListTypes.Children
{
    class ListTypeChildrenValues : TestDecorator
    {

        public override string GetName()
        {
            return "namespace => " + this.GetType().Namespace + ", class => " + this.GetType().Name;
        }

        public override void Execute()
        {
            ListItem item = new ListItem();
            GetChildrenValues values = new GetChildrenValues()
            {
                langId = 1,
                lists =
                {
                    item
                }
            };

            HTTP.Name("List Type Values Children Values Testi")
                .Post("api/listTypes/children/values", values)
                .ShouldBeOk();
        }
    }
}
