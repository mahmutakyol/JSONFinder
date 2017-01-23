using Tests.Core;

namespace Tests.Scenarios.LangValues.General
{
    class LangValuesComboBoxes : TestDecorator
    {

        public override string GetName()
        {
            return "namespace => " + this.GetType().Namespace + ", class => " + this.GetType().Name;
        }

        public override void Execute()
        {
            HTTP.Name("Lang Values General Combo Boxes Testi")
                .Get("api/langValuesComboboxes")
                .ShouldBeOk();
        }
    }
}
