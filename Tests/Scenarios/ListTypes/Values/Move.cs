using Repositories.Lists;
using Tests.Core;

namespace Tests.Scenarios.ListTypes.Values
{
    class ListTypeValuesMove : TestDecorator
    {

        public override string GetName()
        {
            return "namespace => " + this.GetType().Namespace + ", class => " + this.GetType().Name;
        }

        public override void Execute()
        {
            MoveType m = new MoveType();
            Move move = new Move()
            {
                current = 0,
                id = 1,
                LineNo = 1,
                list_id = 1,
                MoveType = m,
                parentId = 1,
                title = "title",
                value = "value"
            };

            HTTP.Name("List Type Values Move Testi")
                .Post("api/listType/values/move", move)
                .ShouldBeOk();
        }
    }
}
