using Tests.Core;

namespace Tests.Scenarios.Menus
{
    class MenusGetMenusByReferenceIdAndParentId : TestDecorator
    {

        public override string GetName()
        {
            return "namespace => " + this.GetType().Namespace + ", class => " + this.GetType().Name;
        }

        public override void Execute()
        {
            var arguments = new
            {
                referenceId = 1,
                parentId = 1
            };

            HTTP.Name("Manus GetMenusByReferenceIdAndParentId Testi")
                .Get("api/menus/getmenusbyreferenceidandparentid?referenceId=" + arguments.referenceId + "&parentId=" + arguments.parentId, arguments)
                .ShouldBeOk();
        }
    }
}
