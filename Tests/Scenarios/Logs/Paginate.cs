using Repositories.HTTP.Requests.Logs;
using Tests.Core;

namespace Tests.Scenarios.Logs
{
    class LogsPaginate : TestDecorator
    {

        public override string GetName()
        {
            return "namespace => " + this.GetType().Namespace + ", class => " + this.GetType().Name;
        }

        public override void Execute()
        {
            GetFilteredLoglist get = new GetFilteredLoglist()
            {
                actionCode = "",
                current = 33,
                endDate = "0",
                startDate = "0",
                username = ""
            };

            HTTP.Name("Logs Paginate Testi")
                .Post("api/logs/paginate", get)
                .ShouldBeOk()
                .ShouldEqual("items.[L].action_code", "ManagerDeleteAction");
        }
    }
}
