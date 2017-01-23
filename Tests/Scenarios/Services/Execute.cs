using Tests.Core;

namespace Tests.Scenarios.Services
{
    class ServicesExecute : TestDecorator
    {

        public override string GetName()
        {
            return "namespace => " + this.GetType().Namespace + ", class => " + this.GetType().Name;
        }

        public override void Execute()
        {

            Repositories.HTTP.Requests.Service.Execute exe = new Repositories.HTTP.Requests.Service.Execute()
            {
                //components =
                //{
                //    null
                //},
                //parameter = "parameter",
                //serviceName = "serviceName"
            };

            HTTP.Name("Service Execute Testi")
                .Post("api/services/execute", exe)
                .ShouldBeOk();
        }
    }
}
