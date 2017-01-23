using Tests.Core;

namespace Tests.Scenarios.Relationships
{
    class RelationshipsGet : TestDecorator
    {

        public override string GetName()
        {
            return "namespace => " + this.GetType().Namespace + ", class => " + this.GetType().Name;
        }

        public override void Execute()
        {

            int tableId = 1;

            HTTP.Name("Relationship Get Testi")
                .Get("api/relationships/" + tableId, tableId)
                .ShouldBeOk();
        }
    }
}
