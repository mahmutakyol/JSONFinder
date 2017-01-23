using Tests.Core;

namespace Tests.Scenarios.LangValues.Lists
{
    class LangValuesListsInit : TestDecorator
    {
        public override string GetName()
        {
            return "namespace => " + this.GetType().Namespace + ", class => " + this.GetType().Name;
        }

        public override void Execute()
        {
            HTTP.Name("Lang Values Lists Init")
                .Get("api/langValues/list/init")
                .ShouldBeOk();
        }
    }
}
