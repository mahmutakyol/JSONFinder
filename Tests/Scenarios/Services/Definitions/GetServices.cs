using Repositories.HTTP.Requests.ExternalDefinitions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tests.Core;

namespace Tests.Scenarios.Externals.Definitions
{
    class ServiceDefinitionsGetServices : TestDecorator
    {

        public override string GetName()
        {
            return "namespace => " + this.GetType().Namespace + ", class => " + this.GetType().Name;
        }

        public override void Execute()
        {
            GetServices service = new GetServices()
            {
                langId = 1
            };

            List<string> paths = new List<string>()
            {
                "services.[L].code",
                "services.[L].description"
            };

            Dictionary<string, dynamic> datas = HTTP.Name("External Definitions GetServices Testi")
                .Post("api/services/getServicesFromDb", service)
                .ShouldBeOk()
                .FetchAsDictionary(paths);

            Config.data["service_code"] = datas["services.[L].code"];
            Config.data["service_description"] = datas["services.[L].description"];
        }
    }
}
