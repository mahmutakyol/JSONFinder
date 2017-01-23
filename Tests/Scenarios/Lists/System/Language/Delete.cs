using Repositories.HTTP.Requests.Lists.System.Language;
using Tests.Core; 

namespace Tests.Scenarios.Lists.System.Language
{
    class ListsSystemLanguageDelete : TestDecorator
    {

        public override string GetName()
        {
            return "namespace => " + this.GetType().Namespace + ", class => " + this.GetType().Name;
        }

        public override void Execute()
        {
            Delete del = new Delete()
            {
                id = 1
            };

            HTTP.Name("List System Language Delete Testi")
                .Post("api/list/systems/languages/delete", del)
                .ShouldBeOk();
        }
    }
}
