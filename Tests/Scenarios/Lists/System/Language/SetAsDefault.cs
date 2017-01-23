using Repositories.HTTP.Requests.Lists.System.Language;
using Tests.Core;

namespace Tests.Scenarios.Lists.System.Language
{
    class ListsSystemLanguageSetAsDefault : TestDecorator
    {

        public override string GetName()
        {
            return "namespace => " + this.GetType().Namespace + ", class => " + this.GetType().Name;
        }

        public override void Execute()
        {
            SetAsDefault sad = new SetAsDefault()
            {
                id = 1
            };

            HTTP.Name("List System Language SetAsDefauls Testi")
                .Post("api/list/systems/languages/setAsDefault", sad)
                .ShouldBeOk();
        }
    }
}
