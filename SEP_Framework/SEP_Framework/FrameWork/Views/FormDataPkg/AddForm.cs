using SEP_Framework.FrameWork.Controllers;
using SEP_Framework.Views.BaseFormPkg;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SEP_Framework.Views.FormDataPkg
{
    public class AddForm : BaseForm
    {
        protected override void clickSave()
        {
            Dictionary<string, string> src = new Dictionary<string, string>();
            foreach (var i in textList)
            {
                if (i.Value.Text == "")
                {
                    MessageBox.Show("Trường dữ liệu " + i.Key + " còn trống!", "Lỗi");
                    return;
                }
                src.Add(i.Key, i.Value.Text);
            }
            try
            {
                controllerData.AddData(src, nameTable);
                foreach (var i in textList)
                {
                    i.Value.Text = "";
                }
                src.Clear();
                MessageBox.Show("Thêm dữ liệu thành công!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Thêm dữ liệu thất bại!" + ex.ToString());
            }

        }
        public AddForm(AbstractController controller, string nameTable) : base(controller, nameTable)
        {
            form.FormBorderStyle = FormBorderStyle.FixedToolWindow;
            this.title = "Form Add Data";
        }

        protected override void InitializeForm()
        {
            int y = 0;
            this.hasLabelList = true;
            foreach (DataColumn item in controllerData.ReadData(nameTable).Columns)
            {
                if (item.ColumnName != primaryKey )
                {
                    Label tmp = new Label();
                    TextBox txt = new TextBox();
                    txt.Name = item.ColumnName;
                    txt.Width = 100;
                    tmp.Text = item.ColumnName;
                    labelList.Add(item.ColumnName, tmp);
                    textList.Add(item.ColumnName, txt);
                    tmp.Location = new Point(150, 60 + y * 30);
                    txt.Location = new Point(250, 60 + y * 30);
                    y++;
                    form.Controls.Add(tmp);
                    form.Controls.Add(txt);
                }
            }

            this.SetSizeAndAddButton(labelList.ElementAt(labelList.Count - 1).Value.Location.Y + labelList.ElementAt(labelList.Count - 1).Value.Height + 50, 500);
        }
    }
}
