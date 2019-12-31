﻿using SEP_Framework.Views.BaseFormPkg;
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
    public class DeleteForm : BaseForm
    {
        public DeleteForm(string cnnString, string nameTable)
            : base(cnnString, nameTable)
        {
            this.title = "Form Delete Data";
            this.SaveText = "Delete";
        }

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
                controllerData.DeleteData(src, nameTable, primaryKey);
                foreach (var i in textList)
                {
                    i.Value.Text = "";
                }
                src.Clear();
                MessageBox.Show("Xóa dữ liệu thành công!");
                this.InitDataGridView();
                gridView.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Xóa dữ liệu thất bại!");
            }

        }

        protected override void InitializeForm()
        {
            if (!controllerData.ReadDataFirstTime(nameTable).Columns.Contains("isDelete"))
            {
                controllerData.InitData(nameTable);
            }
            int y = 0;
            foreach (DataColumn item in controllerData.ReadData(nameTable).Columns)
            {
                if (item.ColumnName != "isDelete")
                {
                    Label tmp = new Label();
                    TextBox txt = new TextBox();
                    txt.Name = item.ColumnName;
                    txt.Width = 100;
                    tmp.Text = item.ColumnName;
                    labelList.Add(item.ColumnName, tmp);
                    textList.Add(item.ColumnName, txt);
                    if (tmp.Text == primaryKey)
                        txt.Enabled = false;
                    tmp.Location = new Point(400, 60 + y * 30);
                    txt.Location = new Point(500, 60 + y * 30);
                    y++;
                }
            }

            this.InitDataGridView();

            this.SetSizeAndAddButton(gridView.Location.Y + gridView.Height + 50, 1000);
        }

        public override void ChangeNameColumns(Dictionary<string, string> listName)
        {
            listNameTable = listName;
        }
    }
}
