using Repositories.HTTP.Requests.Service;
using Tests.Core;

namespace Tests.Scenarios.Services
{
    class ServicesAddParameters : TestDecorator
    {

        public override string GetName()
        {
            return "namespace => " + this.GetType().Namespace + ", class => " + this.GetType().Name;
        }

        public override void Execute()
        {
            AddParameter param = new AddParameter();
            AddParameters parameters = new AddParameters()
            {
                datas =
                {
                    param
                }
            };

            HTTP.Name("Service AddParameters Testi")
                .Post("api/services/addParameters", parameters)
                .ShouldBeOk();
        }
    }
}
