using Repositories.HTTP.Requests.Service;
using Tests.Core;

namespace Tests.Scenarios.Services
{
    class ServicesGetServiceParameters : TestDecorator
    {

        public override string GetName()
        {
            return "namespace => " + this.GetType().Namespace + ", class => " + this.GetType().Name;
        }

        public override void Execute()
        {

            GetServiceParameter param = new GetServiceParameter()
            {
                serviceCode = "service"
            };

            HTTP.Name("Service GetServiceParameters Testi")
                .Post("api/services/getServiceParameters", param)
                .ShouldBeOk();
        }
    }
}
