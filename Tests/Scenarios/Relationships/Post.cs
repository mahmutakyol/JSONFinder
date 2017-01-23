using Tests.Core;

namespace Tests.Scenarios.Relationships
{
    class RelationshipsPost : TestDecorator
    {

        public override string GetName()
        {
            return "namespace => " + this.GetType().Namespace + ", class => " + this.GetType().Name;
        }

        public override void Execute()
        {

            Repositories.HTTP.Requests.Relationships.Relationship relations = new Repositories.HTTP.Requests.Relationships.Relationship()
            {
                sourceColumn = "soruce",
                sourceId = 1,
                sourceName = "soruce",
                targetColumn = "column",
                targetId = 1,
                targetName = "name"
            };

            HTTP.Name("Relationship Post Testi")
                .Post("api/relationships", relations)
                .ShouldBeOk();
        }
    }
}
