using Tests.Core;

namespace Tests.Scenarios.Forms
{
    class FormsDelete : TestDecorator
    {

        public override string GetName()
        {
            return "namespace => " + this.GetType().Namespace + ", class => " + this.GetType().Name;
        }

        public override void Execute()
        {
            Repositories.HTTP.Requests.Forms.Delete delete = new Repositories.HTTP.Requests.Forms.Delete()
            {
                id = (int)Config.data["form_id"]
            };

            HTTP.Name("Form Silme Testi")
                .Post("api/forms/delete", delete)
                .ShouldBeOk();
                
        }
    }
}
