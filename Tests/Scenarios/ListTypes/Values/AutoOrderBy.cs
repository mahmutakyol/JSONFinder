using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tests.Core;

namespace Tests.Scenarios.ListTypes.Values
{
    class ListTypeValuesAutoOrderBy : TestDecorator
    {

        public override string GetName()
        {
            return "namespace => " + this.GetType().Namespace + ", class => " + this.GetType().Name;
        }

        public override void Execute()
        {
            var arguments = new
            {
                listId = 1,
                parentId = 1
            };
            HTTP.Name("List Type Values AutoOrderBy Testi")
                .Get("api/listType/values/autoorderby", arguments)
                .ShouldBeOk();
        }
    }
}
