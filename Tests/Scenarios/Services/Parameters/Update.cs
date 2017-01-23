using Repositories.HTTP.Requests.ExternalDefinitions;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tests.Core;

namespace Tests.Scenarios.Externals.Parameters
{
    class ServiceParametersUpdate : TestDecorator
    {

        public override string GetName()
        {
            return "namespace => " + this.GetType().Namespace + ", class => " + this.GetType().Name;
        }

        public override void Execute()
        {
            ExternalLangUpdate update = new ExternalLangUpdate()
            {
                code = "TR_TRAMER",
                selectedLangId = 1,
                lang_id = 1,
                field_name = "Plaka",
                lang_name = "my_test_name_updated",
                lang_description = "my_test_description_updated"
            };

            HTTP.Name("Externals Parameters LangUpdate Testi")
                .Post("api/services/parameters/langUpdate", update)
                .ShouldBeOk();
        }

    }
}
