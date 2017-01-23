using Repositories.HTTP.Requests.References;
using Tests.Core;

namespace Tests.Scenarios.References
{
    class ReferencesUpdate : TestDecorator
    {

        public override string GetName()
        {
            return "namespace => " + this.GetType().Namespace + ", class => " + this.GetType().Name;
        }

        public override void Execute()
        {

            Update update = new Update()
            {
                code = "code",
                id = 1,
                name = "name",
                type = "type"
            };

            HTTP.Name("Reference Update Testi")
                .Post("api/references/update", update)
                .ShouldBeOk();
        }
    }
}
