using Repositories.HTTP.Requests.Forms;
using Tests.Core;

namespace Tests.Scenarios.Forms.Creates
{
    class FormBookRegistrationCreate : TestDecorator
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
                code = "BookForm_" + code,
                description = "Kitap kayıt formu",
                name = "Book Registration Form"
            };

            Config.data["book_registration_form_id"] = HTTP.Name("Form Create Testi")
                .Post("api/forms/create", create)
                .ShouldBeOk()
                .FetchAsInt("id");
        }
    }
}
