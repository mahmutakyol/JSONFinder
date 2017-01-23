using Repositories.HTTP.Requests.Service;
using Tests.Core;

namespace Tests.Scenarios.Services
{
    class ServicesAddService : TestDecorator
    {

        public override string GetName()
        {
            return "namespace => " + this.GetType().Namespace + ", class => " + this.GetType().Name;
        }

        public override void Execute()
        {
            AddService service = new AddService()
            {
                IsSelected = true,
                ServiceId = "1",
                WizardId = 1
            };

            HTTP.Name("Service AddService Testi")
                .Post("api/services/addService", service)
                .ShouldBeOk();
        }
    }
}
