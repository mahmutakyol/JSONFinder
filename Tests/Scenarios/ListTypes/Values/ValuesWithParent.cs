using Tests.Core;

namespace Tests.Scenarios.ListTypes.Values
{
    class ListTypeValuesValuesWithParent : TestDecorator
    {

        public override string GetName()
        {
            return "namespace => " + this.GetType().Namespace + ", class => " + this.GetType().Name;
        }

        public override void Execute()
        {
            int id = 1;
            HTTP.Name("List Type Values ValuesWithParent Test")
                .Get("api/listType/valuesWithParent/" + id)
                .ShouldBeOk();
        }
    }
}
