
using Tests.Core;

namespace Tests.Scenarios.Forms.Deletes
{
    class FormsDeleteBookRegistration : TestDecorator
    {
        public override string GetName()
        {
            return "namespace => " + this.GetType().Namespace + ", class => " + this.GetType().Name;
        }

        public override void Execute()
        {
            Repositories.HTTP.Requests.Forms.Delete delete = new Repositories.HTTP.Requests.Forms.Delete()
            {
                id = (int)Config.data["book_registration_form_id"]
            };

            HTTP.Name("Form Silme Testi")
                .Post("api/forms/delete", delete)
                .ShouldBeOk();

        }
    }
}
