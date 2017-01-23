using Repositories.HTTP.Requests.Forms.Design;
using Tests.Core;

namespace Tests.Scenarios.Forms.Design
{
    class FormDesignSetLocaleTrigger : TestDecorator
    {

        public override string GetName()
        {
            return "namespace => " + this.GetType().Namespace + ", class => " + this.GetType().Name;
        }

        public override void Execute()
        {
            SetLocaleTrigger trigger = new SetLocaleTrigger()
            {
                formId = 1,
                wizardFieldId = 1,
                langId = 1,
                countryId = 1,
                regionId = 1,
                type = "FORM"
            };

            HTTP.Name("Form Design SetLocaleTrigger Testi")
                .Post("api/forms/design/setLocaleTrigger", trigger)
                .ShouldBeOk();
        }
    }

    public enum TriggerTypes
    {
        FORM,
        WIZARD
    }
}
