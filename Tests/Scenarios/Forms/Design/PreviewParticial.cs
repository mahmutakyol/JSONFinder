using Repositories.HTTP.Requests.Forms.Design;
using Tests.Core;

namespace Tests.Scenarios.Forms.Design
{
    class FormDesignPreviewParticial : TestDecorator
    {

        public override string GetName()
        {
            return "namespace => " + this.GetType().Namespace + ", class => " + this.GetType().Name;
        }

        public override void Execute()
        {
            PreviewPartial previewParticial = new PreviewPartial()
            {
                id = 1,
                langId = 1,
                countryId = 1,
                regionId = 1,
                wizardId = 1
            };

            HTTP.Name("Form Design PreviewParticial Testi")
                .Post("api/forms/previewPartial", previewParticial)
                .ShouldBeOk();
        }
    }
}
