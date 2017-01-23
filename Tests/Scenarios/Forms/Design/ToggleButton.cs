using Repositories.HTTP.Requests.Forms.Design;
using Tests.Core;

namespace Tests.Scenarios.Forms.Design
{
    class FormDesignToggleButton : TestDecorator
    {

        public override string GetName()
        {
            return "namespace => " + this.GetType().Namespace + ", class => " + this.GetType().Name;
        }

        public override void Execute()
        {
            ToggleButton toggle = new ToggleButton()
            {
                formId = Config.data["form_id"],
                langId = 1,
                countryId = 0,
                regionId = 0,
                type = "save"
            };

            HTTP.Name("Form Design ToggleButton Testi")
                .Post("api/forms/design/toggleButton", toggle)
                .ShouldBeOk();
        }
    }
}
