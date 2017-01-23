
using Tests.Core;

namespace Tests.Scenarios.ListTypes
{
    class ListTypesGetForSelectBox : TestDecorator
    {

        public override string GetName()
        {
            return "namespace => " + this.GetType().Namespace + ", class => " + this.GetType().Name;
        }

        public override void Execute()
        {

            HTTP.Name("ListType GetForSelectBox Testi")
                .Get("api/listTypes/forSelectBox")
                .ShouldBeOk();
        }
    }
}
