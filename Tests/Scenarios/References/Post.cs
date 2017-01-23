using Repositories.HTTP.Requests.References;
using Tests.Core;

namespace Tests.Scenarios.References
{
    class ReferencesPost : TestDecorator
    {

        public override string GetName()
        {
            return "namespace => " + this.GetType().Namespace + ", class => " + this.GetType().Name;
        }

        public override void Execute()
        {

            string code = GetCode();
            Create create = new Create()
            {
                code = code,
                name = "my_reference_name",
                type = "COMPONENT"
            };

            Config.data["reference_id"] = HTTP.Name("Reference Post Testi")
                .Post("api/references", create)
                .ShouldBeOk()
                .ShouldEqual("code", code)
                .ShouldEqual("name", "my_reference_name")
                .ShouldEqual("type", "COMPONENT")
                .FetchAsInt("id");

        }
    }
}
