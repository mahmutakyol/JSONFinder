using Tests.Core;

namespace Tests.Scenarios.Lists.System.Language
{
    class ListsSystemLanguageSelectbox : TestDecorator
    {

        public override string GetName()
        {
            return "namespace => " + this.GetType().Namespace + ", class => " + this.GetType().Name;
        }

        public override void Execute()
        {
            HTTP.Name("List System Language SelectBox Testi")
                .Get("api/list/systems/languages/selectbox")
                .ShouldBeOk();
        }
    }
}
