using Repositories.HTTP.Requests.Wizards.Fields;
using Tests.Core;

namespace Tests.Scenarios.Wizards.Fields
{
    class WizardsFieldsDelete : TestDecorator
    {

        public override string GetName()
        {
            return "namespace => " + this.GetType().Namespace + ", class => " + this.GetType().Name;
        }

        public override void Execute()
        {

            Delete delete = new Delete()
            {
                countryId = 1,
                fieldId = 1,
                langId = 1,
                regionId = 1,
                wizardId = 1
            };

            HTTP.Name("Wizard Field Delete Testi")
                .Post("api/wizard/fields/delete", delete)
                .ShouldBeOk();
        }
    }
}
