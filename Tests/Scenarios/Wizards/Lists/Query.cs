using Repositories.HTTP.Requests.Wizards.List;
using System.Collections.Generic;
using Tests.Core;

namespace Tests.Scenarios.Wizards.List
{
    class WizardsListsQuery : TestDecorator
    {

        public override string GetName()
        {
            return "namespace => " + this.GetType().Namespace + ", class => " + this.GetType().Name;
        }

        public override void Execute()
        {
            Query query = new Query()
            {
                arguments = new Dictionary<string, dynamic>(),
                countryId = 1,
                langId = 1,
                regionId = 1,
                wizardId = 1
            };

            HTTP.Name("Wizard List Query Testi")
                .Post("api/wizard/list/query", query)
                .ShouldBeOk();
        }
    }
}
