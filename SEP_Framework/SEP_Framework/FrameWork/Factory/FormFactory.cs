using SEP_Framework.FrameWork.Controllers;
using SEP_Framework.Views.BaseFormPkg;
using SEP_Framework.Views.FormDataPkg;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEP_Framework.FrameWork.Factory
{
    public enum typeForm
    {
        ADD,
        DELETE,
        UPDATE,
        READ,
        HASFORMS
    };

    class FormFactory
    {
        public BaseForm getForm(typeForm type, AbstractController controller, string tableName, BaseForm rootForm)
        {
            BaseForm res = null;
            switch (type)
            {
                case typeForm.ADD:
                    res = new AddForm(controller, tableName);
                    return res;
                case typeForm.READ:
                    res = new ReadForm(controller, tableName);
                    return res;
                case typeForm.UPDATE:
                    res = new UpdateForm(controller, tableName);
                    return res;
                case typeForm.DELETE:
                    res = new DeleteForm(controller, tableName);
                    return res;
                case typeForm.HASFORMS:
                    res = new FormHasForms(controller, tableName, rootForm);
                    return res;
                default:
                    return res;
            }
        }
    }
}
