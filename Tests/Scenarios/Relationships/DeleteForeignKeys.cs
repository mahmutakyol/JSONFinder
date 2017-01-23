using Repositories.HTTP.Requests.Relationships;
using Tests.Core;

namespace Tests.Scenarios.Relationships
{
    class RelationshipsDeleteForeignKeys : TestDecorator
    {

        public override string GetName()
        {
            return "namespace => " + this.GetType().Namespace + ", class => " + this.GetType().Name;
        }

        public override void Execute()
        {

            ForeignKey key = new ForeignKey()
            {
                key = "key",
                tableName = "name"
            };

            HTTP.Name("Relationship DeleteForeignKey Testi")
                .Post("api/relationships/delete", key)
                .ShouldBeOk();
        }
    }
}
