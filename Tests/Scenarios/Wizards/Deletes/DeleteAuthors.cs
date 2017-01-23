using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tests.Core;

namespace Tests.Scenarios.Wizards.Deletes
{
    class WizardDeleteAuthors : TestDecorator
    {

        public override string GetName()
        {
            return "namespace => " + this.GetType().Namespace + ", class => " + this.GetType().Name;
        }

        public override void Execute()
        {
            HTTP.Name("Wizard Delete Testi")
                .Get("api/wizards/delete/" + Config.data["author_registration_wizard_id"])
                .ShouldBeOk();
        }
    }
}
