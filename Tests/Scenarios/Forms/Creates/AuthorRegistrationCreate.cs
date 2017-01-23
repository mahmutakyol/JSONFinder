using Repositories.HTTP.Requests.Forms;
using Tests.Core;

namespace Tests.Scenarios.Forms.Creates
{
    class FormAuthorRegistrationCreate : TestDecorator
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
                code = "authorForm_" + code,
                description = "yazar kayıt formu",
                name = "Author Registration"
            };

            Config.data["author_register_form_id"] = HTTP.Name("Form Author Registration Create Testi")
                .Post("api/forms/create", create)
                .ShouldBeOk()
                .FetchAsInt("id");
        }
    }
}
