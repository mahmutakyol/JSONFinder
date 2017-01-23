using Tests.Core;

namespace Tests.Scenarios.Services
{
    class ServicesInit : TestDecorator
    {

        public override string GetName()
        {
            return "namespace => " + this.GetType().Namespace + ", class => " + this.GetType().Name;
        }

        public override void Execute()
        {
            Repositories.HTTP.Requests.Service.ServicesInit init = new Repositories.HTTP.Requests.Service.ServicesInit()
            {
                WizardId = 1
            };

            HTTP.Name("Services Init Testi")
                .Post("api/services/init", init)
                .ShouldBeOk();
        }
    }
}
