using Tests.Core;

namespace Tests.Scenarios.Components.Deletes
{
    class ComponentDeleteUserId : TestDecorator
    {

        public override string GetName()
        {
            return "namespace => " + this.GetType().Namespace + ", class => " + this.GetType().Name;
        }

        public override void Execute()
        {
            HTTP.Name("Component Delete Testi")
                .Get("api/components/delete/" + Config.data["user_id_component_id"])
                .ShouldResponseCode(204);
        }
    }
}
