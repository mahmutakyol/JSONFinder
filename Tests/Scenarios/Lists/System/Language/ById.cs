using Tests.Core;

namespace Tests.Scenarios.Lists.System.Language
{
    class ListsSystemLanguageLanguagesById : TestDecorator
    {

        public override string GetName()
        {
            return "namespace => " + this.GetType().Namespace + ", class => " + this.GetType().Name;
        }

        public override void Execute()
        {
            int id = 1;
            HTTP.Name("List System Languages By Id Testi")
                .Get("api/list/systems/languages/" + id)
                .ShouldBeOk();
            
        }
    }
}
