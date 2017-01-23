using Tests.Core;

namespace Tests.Scenarios.Lists.System.Language
{
    class ListsSystemLanguageLanguages : TestDecorator
    {

        public override string GetName()
        {
            return "namespace => " + this.GetType().Namespace + ", class => " + this.GetType().Name;
        }

        public override void Execute()
        {
            HTTP.Name("List System Languages Testi")
                .Get("api/list/systems/languages")
                .ShouldBeOk();
        }
    }
}
