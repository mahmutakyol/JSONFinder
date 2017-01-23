using Repositories.HTTP.Requests.Forms;
using Tests.Core;

namespace Tests.Scenarios.Forms
{
    class FormsUpdate : TestDecorator
    {

        public override string GetName()
        {
            return "namespace => " + this.GetType().Namespace + ", class => " + this.GetType().Name;
        }

        public override void Execute()
        {

            Update update = new Update()
            {
                code = "afasd",
                description = "daasdf",
                id = 29,
                name = "asda"
            };

            HTTP.Name("Form Update Testi")
                .Post("api/forms/update", update)
                .ShouldResponseCode(204);
        }
    }
}
