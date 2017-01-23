using Tests.Core;

namespace Tests.Scenarios.Logs
{
    class LogsInit : TestDecorator
    {

        public override string GetName()
        {
            return "namespace => " + this.GetType().Namespace + ", class => " + this.GetType().Name;
        }

        public override void Execute()
        {

            HTTP.Name("Logs Init Testi")
                .Get("api/logs/init")
                .ShouldBeOk();
        }
    }
}
