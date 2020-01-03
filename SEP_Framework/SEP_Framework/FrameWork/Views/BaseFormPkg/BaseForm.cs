using SEP_Framework.FrameWork.Controllers;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SEP_Framework.Views.BaseFormPkg
{
    public class BaseForm
    {
        protected DataGridView gridView = new DataGridView();
        protected string nameTable;
        protected string primaryKey;
        protected Bunifu.Framework.UI.BunifuFlatButton save;
        protected Bunifu.Framework.UI.BunifuFlatButton cancel;
        protected string SaveText = "Ok";
        protected string CancelText = "Cancel";
     
        public Form form;
        protected AbstractController controllerData;
        protected Dictionary<string, string> listNameTable = new Dictionary<string, string>();
        protected DataTable dt;
        protected Dictionary<string, Label> labelList = new Dictionary<string, Label>();
        protected Dictionary<string, TextBox> textList = new Dictionary<string, TextBox>();
        public string title = "Base Form";
        protected bool hasLabelList = false;

        public BaseForm(AbstractController controller, string nameTable)
        {
            this.form = new Form();
            form.Text = "Demo SEP Framework";
            form.Icon = Properties.Resources.icon;
            this.nameTable = nameTable;
            this.controllerData = controller;

            this.save = new Bunifu.Framework.UI.BunifuFlatButton();
            this.cancel = new Bunifu.Framework.UI.BunifuFlatButton();

            this.save.Click += Save_Click;
            this.cancel.Click += Cancel_Click;
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            this.form.Hide();
        }

        private void Save_Click(object sender, EventArgs e)
        {
            this.clickSave();
        }

        public virtual void ShowForm()
        {
            this.SetupForm();
            this.AddTitle();
            this.form.Show();
        }

        private void SetupForm()
        {
            this.SetPrimaryKey(controllerData.GetPrimaryKey(nameTable));
            this.InitializeForm();
        }

        private void SetPrimaryKey(string key)
        {
            primaryKey = key;
        }

        protected void InitDataGridView()
        {
            gridView.Columns.Clear();
            gridView.Refresh();
            dt = controllerData.ReadData(nameTable);
            DataGridViewColumn[] columns = { };

            foreach (DataColumn item in dt.Columns)
            {
                    DataGridViewTextBoxColumn column = new DataGridViewTextBoxColumn();
                    column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    column.DataPropertyName = item.ColumnName;
                    column.HeaderText = listNameTable.ContainsKey(item.ColumnName) ? listNameTable[item.ColumnName] : item.ColumnName;
                    column.Name = item.ColumnName;
                    column.ReadOnly = true;
                    columns = columns.Concat(new DataGridViewColumn[] { column }).ToArray();
            }

            gridView.Columns.AddRange(columns);
            gridView.DataSource = dt;
            gridView.Location = hasLabelList ? new Point(0, labelList.ElementAt(labelList.Count - 1).Value.Location.Y + labelList.ElementAt(labelList.Count - 1).Value.Height + 50) : new Point(0, 100);
            gridView.Size = new Size(1000, 200);
            gridView.Name = "Data Table";
            gridView.ReadOnly = true;
            gridView.CellClick += Binding_Data;
            form.Controls.Add(gridView);
            if (dt.Rows.Count > 0)
            {
                for (int i = 0, j = 0; i < textList.Count && j < gridView.ColumnCount; i++, j++)
                {
                    textList.ElementAt(i).Value.Text = dt.Rows[0].ItemArray[j].ToString();
                }
            }
        }

        private void Binding_Data(object sender, DataGridViewCellEventArgs e)
        {
            if (gridView.Rows.Count > -1)
            {
                for (int i = 0, j = 0; i < textList.Count && j < gridView.ColumnCount; i++, j++)
                {
                    textList.ElementAt(i).Value.Text = gridView.Rows[e.RowIndex].Cells[j].Value.ToString();
                }
            }
        }

        protected virtual void InitializeForm() { }

        protected void AddTitle()
        {
            Label title = new Label();
            title.Name = "Title Label";
            title.Text = this.title;
            title.AutoSize = true;
            title.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
            title.Location = new Point(form.Width / 2 - title.Width / 2 - 20, 10);
            form.Controls.Add(title);
        }

        protected virtual void clickSave() { }

        public virtual void ChangeNameColumns(Dictionary<string, string> listName) { }

        public virtual void SetSizeAndAddButton(int height, int width)
        {
            form.Width = width;
            form.Height = height;

            //this.save.Text = this.SaveText;
            //this.save.Location = new Point(form.Width / 2 - 100, form.Height - 20);

            //this.cancel.Text = this.CancelText;
            //this.cancel.Location = new Point(form.Width / 2 + 10, form.Height - 20);

            this.save.Activecolor = System.Drawing.Color.DeepSkyBlue;
            this.save.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.save.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.save.BorderRadius = 0;
            this.save.ButtonText = this.SaveText;
            this.save.Cursor = System.Windows.Forms.Cursors.Hand;
            this.save.DisabledColor = System.Drawing.Color.Gray;
            this.save.Iconcolor = System.Drawing.Color.Transparent;
            this.save.Iconimage_right = null;
            this.save.Iconimage_right_Selected = null;
            this.save.Iconimage_Selected = null;
            this.save.IconMarginLeft = 0;
            this.save.IconMarginRight = 0;
            this.save.IconRightVisible = true;
            this.save.IconRightZoom = 0D;
            this.save.IconVisible = true;
            this.save.IconZoom = 90D;
            this.save.IsTab = false;
            this.save.Location = new Point(form.Width / 2 - 100, form.Height - 20);
            this.save.Name = "save";
            this.save.Normalcolor = System.Drawing.Color.DeepSkyBlue;
            this.save.OnHovercolor = System.Drawing.SystemColors.Highlight;
            this.save.OnHoverTextColor = System.Drawing.Color.White;
            this.save.selected = false;
            this.save.Size = new System.Drawing.Size(140, 32);
            this.save.TabIndex = 0;
            this.save.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.save.Textcolor = System.Drawing.Color.White;
            this.save.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));

            this.cancel.Activecolor = System.Drawing.Color.Crimson;
            this.cancel.BackColor = System.Drawing.Color.Red;
            this.cancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cancel.BorderRadius = 0;
            this.cancel.ButtonText = this.CancelText;
            this.cancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cancel.DisabledColor = System.Drawing.Color.Gray;
            this.cancel.Iconcolor = System.Drawing.Color.Transparent;
            this.cancel.Iconimage = null;
            this.cancel.Iconimage_right = null;
            this.cancel.Iconimage_right_Selected = null;
            this.cancel.Iconimage_Selected = null;
            this.cancel.IconMarginLeft = 0;
            this.cancel.IconMarginRight = 0;
            this.cancel.IconRightVisible = true;
            this.cancel.IconRightZoom = 0D;
            this.cancel.IconVisible = true;
            this.cancel.IconZoom = 90D;
            this.cancel.IsTab = false;
            this.cancel.Location = new Point(form.Width / 2 + 25, form.Height - 20);
            this.cancel.Name = "cancel";
            this.cancel.Normalcolor = System.Drawing.Color.Transparent;
            this.cancel.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cancel.OnHoverTextColor = System.Drawing.Color.White;
            this.cancel.selected = false;
            this.cancel.Size = new System.Drawing.Size(166, 31);
            this.cancel.TabIndex = 1;
            this.cancel.Text = "Cancel";
            this.cancel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cancel.Textcolor = System.Drawing.Color.OrangeRed;
            this.cancel.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));


            form.Controls.Add(this.save);
            form.Controls.Add(this.cancel);
            form.Height = save.Location.Y + save.Height + 80;
        }

        public virtual void InsertForm(BaseForm f) { }
    }
}
