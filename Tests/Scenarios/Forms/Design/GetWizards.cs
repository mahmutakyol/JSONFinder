using Tests.Core;

namespace Tests.Scenarios.Forms
{
    class FormDesignGetWizards : TestDecorator
    {

        public override string GetName()
        {
            return "namespace => " + this.GetType().Namespace + ", class => " + this.GetType().Name;
        }

        public override void Execute()
        {
            HTTP.Name("Form Design Get Wizards Testi")
                .Get("api/forms/design/getWizards")
                .ShouldBeOk();
        }

    }
}
