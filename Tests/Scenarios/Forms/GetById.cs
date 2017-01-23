using Repositories.HTTP.Requests.Forms;
using Tests.Core;

namespace Tests.Scenarios.Forms
{
    class FormsGetById : TestDecorator
    {

        public override string GetName()
        {
            return "namespace => " + this.GetType().Namespace + ", class => " + this.GetType().Name;
        }

        public override void Execute()
        {

            GetById id = new GetById()
            {
                id = 10
            };

            HTTP.Name("Form GetById Testi")
                .Post("api/forms/getById", id)
                .ShouldResponseCode(200);
        }
    }
}
