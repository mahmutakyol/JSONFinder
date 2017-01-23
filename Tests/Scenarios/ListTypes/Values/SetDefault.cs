using Repositories.HTTP.Requests.ListTypes.Values;
using Tests.Core;

namespace Tests.Scenarios.ListTypes.Values
{
    class ListTypeValuesSetDefault : TestDecorator
    {

        public override string GetName()
        {
            return "namespace => " + this.GetType().Namespace + ", class => " + this.GetType().Name;
        }

        public override void Execute()
        {
            SetDefault setDefault = new SetDefault()
            {
                current = 0,
                parentId = 1,
                typeId = 1,
                valueId = 1
            };

            HTTP.Name("List Type Values SetDefault Testi")
                .Post("api/listTypes/values/setDefault", setDefault)
                .ShouldBeOk();
        }
    }
}
