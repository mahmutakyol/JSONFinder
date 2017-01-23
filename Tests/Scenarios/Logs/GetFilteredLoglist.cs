using Repositories.HTTP.Requests.Logs;
using Tests.Core;

namespace Tests.Scenarios.Logs
{
    class LogsGetFilteredLogList : TestDecorator
    {

        public override string GetName()
        {
            return "namespace => " + this.GetType().Namespace + ", class => " + this.GetType().Name;
        }

        public override void Execute()
        {

            GetFilteredLoglist get = new GetFilteredLoglist()
            {
                actionCode = "actionCode",
                current = 0,
                endDate = "yyyy-mm-dd hh:mm:ss",
                startDate = "yyyy-mm-dd hh:mm:ss",
                username = "username"
            };

            HTTP.Name("Logs GetFilteredLogList Testi")
                .Post("api/logs/GetFilteredLogList", get)
                .ShouldBeOk();
        }
    }
}
