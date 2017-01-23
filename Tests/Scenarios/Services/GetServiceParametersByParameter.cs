using Repositories.HTTP.Requests.Service;
using Tests.Core;

namespace Tests.Scenarios.Services
{
    class ServicesGetServiceParametersByParameter : TestDecorator
    {
        public override string GetName()
        {
            return "namespace => " + this.GetType().Namespace + ", class => " + this.GetType().Name;
        }


        public override void Execute()
        {

            GetParametersByParameter param = new GetParametersByParameter()
            {
                components =
                {
                    null
                },
                parameter = "param",
                serviceName = "name"
            };

            HTTP.Name("Service GetServiceParameters Testi")
                .Post("api/services/getserviceParametersByParameter", param)
                .ShouldBeOk();
        }
    }
}
