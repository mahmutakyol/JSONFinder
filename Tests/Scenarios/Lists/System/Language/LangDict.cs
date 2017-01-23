using Tests.Core;

namespace Tests.Scenarios.Lists.System.Language
{
    class ListsSystemLanguageLangDict : TestDecorator
    {

        public override string GetName()
        {
            return "namespace => " + this.GetType().Namespace + ", class => " + this.GetType().Name;
        }

        public override void Execute()
        {
            HTTP.Name("List System Language LangDict Testi")
                .Get("api/list/systems/languages/langDict")
                .ShouldBeOk();
        }
    }
}
