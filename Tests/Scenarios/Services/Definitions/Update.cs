using Repositories.HTTP.Requests.ExternalDefinitions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tests.Core;

namespace Tests.Scenarios.Externals.Definitions
{
    class ServiceDefinitionsUpdate : TestDecorator
    {

        public override string GetName()
        {
            return "namespace => " + this.GetType().Namespace + ", class => " + this.GetType().Name;
        }

        public override void Execute()
        {
            Update update = new Update()
            {
                code = Config.data["service_code"],
                lang_description = "my_test_description_updated",
                lang_name = "my_test_name_updated",
                lang_id = 1,
                selectedLangId = 1
            };

            HTTP.Name("External Definitions Update Testi")
                .Post("api/services/update", update)
                .ShouldBeOk()
                .ShouldEqual("services.[L].lang_description", "my_test_description_updated");
        }
    }
}
