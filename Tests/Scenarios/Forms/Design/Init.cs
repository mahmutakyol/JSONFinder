using Repositories.HTTP.Requests.Forms.Design;
using Tests.Core;

namespace Tests.Scenarios.Forms.Design
{
    class FormDesignInit : TestDecorator
    {

        public override string GetName()
        {
            return "namespace => " + this.GetType().Namespace + ", class => " + this.GetType().Name;
        }

        public override void Execute()
        {
            GetById id = new GetById()
            {
                id = 7
            };

            HTTP.Name("Form Design Init Testi")
                .Post("api/forms/design/init", id)
                .ShouldBeOk();
        }
    }
}
