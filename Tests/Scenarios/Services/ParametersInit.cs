using Repositories.HTTP.Requests.Service;
using Tests.Core;

namespace Tests.Scenarios.Services
{
    class ServicesParametersInit : TestDecorator
    {

        public override string GetName()
        {
            return "namespace => " + this.GetType().Namespace + ", class => " + this.GetType().Name;
        }

        public override void Execute()
        {

        ParametersInit init = new ParametersInit()
            {
                service_code = "service"
            };

            HTTP.Name("Service ParametersInit Testi")
                .Post("api/services/parametersInit", init)
                .ShouldBeOk();
        }
    }
}
