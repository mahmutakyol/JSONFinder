using Tests.Core;

namespace Tests.Scenarios.Components.Deletes
{
    class ComponentDeleteAuthorId : TestDecorator
    {

        public override string GetName()
        {
            return "namespace => " + this.GetType().Namespace + ", class => " + this.GetType().Name;
        }

        public override void Execute()
        {
            HTTP.Name("Component Delete Testi")
                .Get("api/components/delete/" + Config.data["author_id_component_id"])
                .ShouldResponseCode(204);
        }
    }
}
