using Repositories.HTTP.Requests.Forms;
using Tests.Core;

namespace Tests.Scenarios.Forms.Creates
{
    class FormUserRegistrationCreate : TestDecorator
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
                code = "userForm_" + code,
                description = "kullanıcı kayıt formu",
                name = "User Register"
            };

            Config.data["user_register_form_id"] = HTTP.Name("Form User Register Create Testi")
                .Post("api/forms/create", create)
                .ShouldBeOk()
                .FetchAsInt("id");
        }
    }
}
