using Repositories.HTTP.Requests.Forms.Design;
using Tests.Core;

namespace Tests.Scenarios.Forms.Design
{
    class FormDesignPreview : TestDecorator
    {

        public override string GetName()
        {
            return "namespace => " + this.GetType().Namespace + ", class => " + this.GetType().Name;
        }

        public override void Execute()
        {
            Preview preview = new Preview()
            {
                id = Config.data["form_id"],
                langId = 1,
                countryId = 0,
                regionId = 0
            };

            HTTP.Name("Form Design Preview Testi")
                .Post("api/forms/preview", preview)
                .ShouldBeOk();
        }
    }
}
