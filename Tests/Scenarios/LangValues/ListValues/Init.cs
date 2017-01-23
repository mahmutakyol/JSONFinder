using Tests.Core;

namespace Tests.Scenarios.LangValues.ListValues
{
    class LangValuesListValuesInit : TestDecorator
    {

        public override string GetName()
        {
            return "namespace => " + this.GetType().Namespace + ", class => " + this.GetType().Name;
        }

        public override void Execute()
        {
            HTTP.Name("Lang Values List Values Init Testi")
                .Get("api/langValues/init")
                .ShouldBeOk();
        }
    }
}
