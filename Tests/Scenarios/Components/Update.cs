using Repositories.HTTP.Requests.Components;
using Tests.Core;

namespace Tests.Scenarios.Components
{
    class ComponentsUpdate : TestDecorator
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
                defaultValue = "default",
                description = "description",
                length = 1,
                listId = 1,
                listType = "type",
                name = "name",
                reference = 1,
                structure = "structure"
            };

            int id = 1;

            HTTP.Name("Component Update Testi")
                .Post("api/components/update/" + id, update)
                .ShouldBeOk();
        }
    }
}
