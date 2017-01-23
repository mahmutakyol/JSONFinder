using Repositories.HTTP.Requests.Components;
using Tests.Core;

namespace Tests.Scenarios.Components
{
    class ComponentsUpdateCode : TestDecorator
    {

        public override string GetName()
        {
            return "namespace => " + this.GetType().Namespace + ", class => " + this.GetType().Name;
        }

        public override void Execute()
        {

            int id = 1;

            UpdateCode updateCode = new UpdateCode()
            {
                code = "code"
            };

            HTTP.Name("Component UpdateCode Testi")
                .Post("api/components/update/code/" + id, updateCode)
                .ShouldBeOk();
        }
    }
}
