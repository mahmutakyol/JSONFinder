using Tests.Core;

namespace Tests.Scenarios.Languages
{
    class LanguagesGet : TestDecorator
    {

        public override string GetName()
        {
            return "namespace => " + this.GetType().Namespace + ", class => " + this.GetType().Name;
        }

        public override void Execute()
        {

            HTTP.Name("Language Get Testi")
                .Get("api/languages")
                .ShouldBeOk();
        }
    }
}
