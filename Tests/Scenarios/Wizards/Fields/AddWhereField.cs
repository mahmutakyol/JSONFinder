using Repositories.HTTP.Requests.Wizards.Fields;
using Tests.Core;

namespace Tests.Scenarios.Wizards.Fields
{
    class WizardsFieldsAddWhereField : TestDecorator
    {

        public override string GetName()
        {
            return "namespace => " + this.GetType().Namespace + ", class => " + this.GetType().Name;
        }

        public override void Execute()
        {

            Create create = new Create()
            {
                ids = new System.Collections.Generic.List<TableComponentInput>() 
                {
                    new TableComponentInput() {
                        id = 1,
                        isUserTable = false,
                        userTableType = null
                    }
                },
                wizardId = 1
            };

            HTTP.Name("Wizard Field AddWhereField Testi")
                .Post("api/wizard/fields/addWhereField", create)
                .ShouldBeOk();
        }
    }
}
