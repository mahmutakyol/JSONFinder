using Repositories.HTTP.Requests.Forms.Design;
using Tests.Core;

namespace Tests.Scenarios.Forms.Design
{
    class FormDesignMove : TestDecorator
    {

        public override string GetName()
        {
            return "namespace => " + this.GetType().Namespace + ", class => " + this.GetType().Name;
        }

        public override void Execute()
        {

            Move move = new Move()
            {
                formId = 22,
                formWizardId = 78,
                toRow = 0,
                toColumn = 1,
                langId = 1,
                countryId = 1,
                regionId = 0
            };

            HTTP.Name("Form Design Move Testi")
                .Post("api/forms/design/move", move)
                .ShouldBeOk();
        }
    }
}
