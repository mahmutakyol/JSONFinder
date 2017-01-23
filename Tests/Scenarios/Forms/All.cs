using System.Collections.Generic;
using Tests.Core;

namespace Tests.Scenarios.Forms
{
    class FormsAll : TestDecorator
    {

        public override string GetName()
        {
            return "namespace => " + this.GetType().Namespace + ", class => " + this.GetType().Name;
        }

        public override void Execute()
        {

            HTTP.Name("Form All Testi")
                .Get("api/forms")
                //.ShouldHaveHeader("Pragma")
                //.ShouldNull("[0].code")
                //.ShouldLessThanOrEqual("[0].id", 38)
                //.ShouldLessThan("[0].id", 40)
                //.ShouldGreaterThanOrEqual("[0].id", 38)
                //.ShouldGreaterThan("[0].id", 35)
                //.ShouldTrue("[0].button_save")
                //.ShouldFalse("[0].button_save")
                //.ShouldEqual("[0].id", 38)
                //.ShouldResponseCode(200)
                //.ShouldContain("[0].code")
                .ShouldBeOk();
        }
    }
}
