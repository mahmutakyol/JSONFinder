using Tests.Core;

namespace Tests.Scenarios.Relationships
{
    class RelationshipsGetForeignKeys : TestDecorator
    {

        public override string GetName()
        {
            return "namespace => " + this.GetType().Namespace + ", class => " + this.GetType().Name;
        }

        public override void Execute()
        {

            Repositories.HTTP.Requests.Relationships.Table table = new Repositories.HTTP.Requests.Relationships.Table()
            {
                id = 1,
                name = "name"
            };

            HTTP.Name("Relationship GetForeignKeys Testi")
                .Post("api/relationships/foreign_keys", table)
                .ShouldBeOk();
        }
    }
}
