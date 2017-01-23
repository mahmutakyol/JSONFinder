using Repositories.Forms.Wizards;
using Repositories.HTTP.Requests.Forms.Formulas;
using System.Collections.Generic;
using Tests.Core;

namespace Tests.Scenarios.Forms.Formulas
{
    class FormFormulasSave : TestDecorator
    {

        public override string GetName()
        {
            return "namespace => " + this.GetType().Namespace + ", class => " + this.GetType().Name;
        }

        public override void Execute()
        {
            List<ParamParts> paramlist = new List<ParamParts>();
            List<List<ParamParts>> param = new List<List<ParamParts>>();
            ParamParts pp = new ParamParts()
            {
                parameterType = "type",
                value = "value"
            };

            pp.parameterType = "DynamicValue";
            pp.value = "ad";
            paramlist.Add(pp);
            pp.value = "soyad";
            paramlist.Add(pp);
            param.Add(paramlist);
            Save save = new Save();
            save.code = "";
            save.command = "SUM";
            save.commandId = 0;
            save.commandType = "MAIN";
            save.formWizardId = 78;
            save.wizardFieldId = 188;
            save.parameters = param;

            HTTP.Name("Form Formulas Save Testi")
                .Post("api/forms/formulas/save", save)
                .ShouldBeOk();
        }
    }
}
