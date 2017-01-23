using Repositories.HTTP.Requests.Forms;
using Tests.Core;

namespace Tests.Scenarios.Forms
{
    class FormsCreate : TestDecorator
    {

        public override string GetName()
        {
            return "namespace => " + this.GetType().Namespace + ", class => " + this.GetType().Name;
        }

        public override void Execute()
        {
            string code = GetCode();
            Create create = new Create()
            {
                code = code,
                description = "my_test_description",
                name = "my_test_form"
            };

            Config.data["form_id"] = HTTP.Name("Form Create Testi")
                .Post("api/forms/create", create)
                .ShouldBeOk()
                .FetchAsInt("id");
        }
    }
}
