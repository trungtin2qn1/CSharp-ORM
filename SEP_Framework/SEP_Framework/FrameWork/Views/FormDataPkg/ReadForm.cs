using SEP_Framework.FrameWork.Controllers;
using SEP_Framework.Views.BaseFormPkg;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SEP_Framework.Views.FormDataPkg
{
    class ReadForm : BaseForm
    {
        public ReadForm(AbstractController controller, string nameTable) : base(controller, nameTable)
        {
            form.AutoSize = true;
            form.FormBorderStyle = FormBorderStyle.FixedToolWindow;
            this.title = "Form Read Data";
            this.SaveText = "Refresh";
            this.CancelText = "Close";
        }

        protected override void InitializeForm()
        {
            this.InitDataGridView();

            this.SetSizeAndAddButton(form.Height, 1000);
        }

        protected override void clickSave()
        {
            this.InitDataGridView();
        }

        public override void ChangeNameColumns(Dictionary<string, string> listName)
        {
            listNameTable = listName;
        }
    }
}
