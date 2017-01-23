using Repositories.HTTP.Requests.ListTypes;
using Tests.Core;

namespace Tests.Scenarios.ListTypes
{
    class ListTypesUpdate : TestDecorator
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
                description = "description",
                id = 1,
                name = "name",
                parentId = 1
            };

            HTTP.Name("ListType Update Testi")
                .Post("api/listTypes/update", update)
                .ShouldBeOk();
        }
    }
}
