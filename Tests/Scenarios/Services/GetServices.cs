using Repositories.HTTP.Requests.Service;
using Tests.Core;

namespace Tests.Scenarios.Services
{
    class ServicesGetServices : TestDecorator
    {

        public override string GetName()
        {
            return "namespace => " + this.GetType().Namespace + ", class => " + this.GetType().Name;
        }

        public override void Execute()
        {

            GetService service = new GetService()
            {
                countryId = "TR",
                wizardId = 1
            };

            HTTP.Name("Service GetServices Testi")
                .Post("api/services/getServices", service)
                .ShouldBeOk();
        }
    }
}
