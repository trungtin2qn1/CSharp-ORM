namespace SEP_Framework.View
{
    partial class HomeForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel2 = new System.Windows.Forms.Panel();
            this.minimizeButton = new Bunifu.Framework.UI.BunifuImageButton();
            this.formTitleLabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.closeButton = new Bunifu.Framework.UI.BunifuImageButton();
            this.chooseTableLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.deleteDataButton = new Bunifu.Framework.UI.BunifuFlatButton();
            this.editDataButton = new Bunifu.Framework.UI.BunifuFlatButton();
            this.addDataButton = new Bunifu.Framework.UI.BunifuFlatButton();
            this.showDataButton = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.tableDropdown = new Bunifu.Framework.UI.BunifuDropdown();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.minimizeButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.closeButton)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.AliceBlue;
            this.panel2.Controls.Add(this.minimizeButton);
            this.panel2.Controls.Add(this.formTitleLabel);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.closeButton);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(923, 45);
            this.panel2.TabIndex = 3;
            // 
            // minimizeButton
            // 
            this.minimizeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.minimizeButton.BackColor = System.Drawing.Color.Transparent;
            this.minimizeButton.Image = global::SEP_Framework.Properties.Resources.minus;
            this.minimizeButton.ImageActive = null;
            this.minimizeButton.Location = new System.Drawing.Point(866, 13);
            this.minimizeButton.Name = "minimizeButton";
            this.minimizeButton.Size = new System.Drawing.Size(20, 18);
            this.minimizeButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.minimizeButton.TabIndex = 6;
            this.minimizeButton.TabStop = false;
            this.minimizeButton.Zoom = 10;
            this.minimizeButton.Click += new System.EventHandler(this.minimizeButton_Click);
            // 
            // formTitleLabel
            // 
            this.formTitleLabel.AutoSize = true;
            this.formTitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.formTitleLabel.ForeColor = System.Drawing.Color.SteelBlue;
            this.formTitleLabel.Location = new System.Drawing.Point(52, 13);
            this.formTitleLabel.Name = "formTitleLabel";
            this.formTitleLabel.Size = new System.Drawing.Size(224, 20);
            this.formTitleLabel.TabIndex = 5;
            this.formTitleLabel.Text = "Ứng dụng quản lý sinh viên";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.AliceBlue;
            this.pictureBox1.Image = global::SEP_Framework.Properties.Resources.cdio;
            this.pictureBox1.Location = new System.Drawing.Point(12, 7);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(34, 31);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // closeButton
            // 
            this.closeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.closeButton.BackColor = System.Drawing.Color.Transparent;
            this.closeButton.Image = global::SEP_Framework.Properties.Resources.error;
            this.closeButton.ImageActive = null;
            this.closeButton.Location = new System.Drawing.Point(892, 13);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(20, 18);
            this.closeButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.closeButton.TabIndex = 0;
            this.closeButton.TabStop = false;
            this.closeButton.Zoom = 10;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // chooseTableLabel
            // 
            this.chooseTableLabel.AutoSize = true;
            this.chooseTableLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chooseTableLabel.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.chooseTableLabel.Location = new System.Drawing.Point(248, 64);
            this.chooseTableLabel.Name = "chooseTableLabel";
            this.chooseTableLabel.Size = new System.Drawing.Size(80, 18);
            this.chooseTableLabel.TabIndex = 1;
            this.chooseTableLabel.Text = "Chọn bảng";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.panel1.Controls.Add(this.deleteDataButton);
            this.panel1.Controls.Add(this.editDataButton);
            this.panel1.Controls.Add(this.addDataButton);
            this.panel1.Controls.Add(this.showDataButton);
            this.panel1.Location = new System.Drawing.Point(0, 45);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(242, 374);
            this.panel1.TabIndex = 2;
            // 
            // deleteDataButton
            // 
            this.deleteDataButton.Activecolor = System.Drawing.Color.DeepSkyBlue;
            this.deleteDataButton.BackColor = System.Drawing.Color.Transparent;
            this.deleteDataButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.deleteDataButton.BorderRadius = 0;
            this.deleteDataButton.ButtonText = "Xóa dữ liệu";
            this.deleteDataButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.deleteDataButton.DisabledColor = System.Drawing.Color.Gray;
            this.deleteDataButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteDataButton.Iconcolor = System.Drawing.Color.Transparent;
            this.deleteDataButton.Iconimage = global::SEP_Framework.Properties.Resources.rubbish_bin;
            this.deleteDataButton.Iconimage_right = null;
            this.deleteDataButton.Iconimage_right_Selected = null;
            this.deleteDataButton.Iconimage_Selected = null;
            this.deleteDataButton.IconMarginLeft = 20;
            this.deleteDataButton.IconMarginRight = 0;
            this.deleteDataButton.IconRightVisible = true;
            this.deleteDataButton.IconRightZoom = 0D;
            this.deleteDataButton.IconVisible = true;
            this.deleteDataButton.IconZoom = 45D;
            this.deleteDataButton.IsTab = false;
            this.deleteDataButton.Location = new System.Drawing.Point(0, 221);
            this.deleteDataButton.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.deleteDataButton.Name = "deleteDataButton";
            this.deleteDataButton.Normalcolor = System.Drawing.Color.Transparent;
            this.deleteDataButton.OnHovercolor = System.Drawing.Color.DeepSkyBlue;
            this.deleteDataButton.OnHoverTextColor = System.Drawing.Color.White;
            this.deleteDataButton.selected = false;
            this.deleteDataButton.Size = new System.Drawing.Size(242, 48);
            this.deleteDataButton.TabIndex = 11;
            this.deleteDataButton.Text = "Xóa dữ liệu";
            this.deleteDataButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.deleteDataButton.Textcolor = System.Drawing.Color.White;
            this.deleteDataButton.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteDataButton.Click += new System.EventHandler(this.deleteDataButton_Click);
            // 
            // editDataButton
            // 
            this.editDataButton.Activecolor = System.Drawing.Color.DeepSkyBlue;
            this.editDataButton.BackColor = System.Drawing.Color.Transparent;
            this.editDataButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.editDataButton.BorderRadius = 0;
            this.editDataButton.ButtonText = "Sửa dữ liệu";
            this.editDataButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.editDataButton.DisabledColor = System.Drawing.Color.Gray;
            this.editDataButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editDataButton.Iconcolor = System.Drawing.Color.Transparent;
            this.editDataButton.Iconimage = global::SEP_Framework.Properties.Resources.pencil_edit_button;
            this.editDataButton.Iconimage_right = null;
            this.editDataButton.Iconimage_right_Selected = null;
            this.editDataButton.Iconimage_Selected = null;
            this.editDataButton.IconMarginLeft = 20;
            this.editDataButton.IconMarginRight = 0;
            this.editDataButton.IconRightVisible = true;
            this.editDataButton.IconRightZoom = 0D;
            this.editDataButton.IconVisible = true;
            this.editDataButton.IconZoom = 45D;
            this.editDataButton.IsTab = false;
            this.editDataButton.Location = new System.Drawing.Point(0, 163);
            this.editDataButton.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.editDataButton.Name = "editDataButton";
            this.editDataButton.Normalcolor = System.Drawing.Color.Transparent;
            this.editDataButton.OnHovercolor = System.Drawing.Color.DeepSkyBlue;
            this.editDataButton.OnHoverTextColor = System.Drawing.Color.White;
            this.editDataButton.selected = false;
            this.editDataButton.Size = new System.Drawing.Size(242, 48);
            this.editDataButton.TabIndex = 10;
            this.editDataButton.Text = "Sửa dữ liệu";
            this.editDataButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.editDataButton.Textcolor = System.Drawing.Color.White;
            this.editDataButton.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editDataButton.Click += new System.EventHandler(this.editDataButton_Click);
            // 
            // addDataButton
            // 
            this.addDataButton.Activecolor = System.Drawing.Color.DeepSkyBlue;
            this.addDataButton.BackColor = System.Drawing.Color.Transparent;
            this.addDataButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.addDataButton.BorderRadius = 0;
            this.addDataButton.ButtonText = "Thêm dữ liệu";
            this.addDataButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addDataButton.DisabledColor = System.Drawing.Color.Gray;
            this.addDataButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addDataButton.Iconcolor = System.Drawing.Color.Transparent;
            this.addDataButton.Iconimage = global::SEP_Framework.Properties.Resources.plus;
            this.addDataButton.Iconimage_right = null;
            this.addDataButton.Iconimage_right_Selected = null;
            this.addDataButton.Iconimage_Selected = null;
            this.addDataButton.IconMarginLeft = 20;
            this.addDataButton.IconMarginRight = 0;
            this.addDataButton.IconRightVisible = true;
            this.addDataButton.IconRightZoom = 0D;
            this.addDataButton.IconVisible = true;
            this.addDataButton.IconZoom = 45D;
            this.addDataButton.IsTab = false;
            this.addDataButton.Location = new System.Drawing.Point(0, 104);
            this.addDataButton.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.addDataButton.Name = "addDataButton";
            this.addDataButton.Normalcolor = System.Drawing.Color.Transparent;
            this.addDataButton.OnHovercolor = System.Drawing.Color.DeepSkyBlue;
            this.addDataButton.OnHoverTextColor = System.Drawing.Color.White;
            this.addDataButton.selected = false;
            this.addDataButton.Size = new System.Drawing.Size(242, 48);
            this.addDataButton.TabIndex = 9;
            this.addDataButton.Text = "Thêm dữ liệu";
            this.addDataButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.addDataButton.Textcolor = System.Drawing.Color.White;
            this.addDataButton.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addDataButton.Click += new System.EventHandler(this.addDataButton_Click);
            // 
            // showDataButton
            // 
            this.showDataButton.Activecolor = System.Drawing.Color.DeepSkyBlue;
            this.showDataButton.BackColor = System.Drawing.Color.Transparent;
            this.showDataButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.showDataButton.BorderRadius = 0;
            this.showDataButton.ButtonText = "Hiển thị dữ liệu";
            this.showDataButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.showDataButton.DisabledColor = System.Drawing.Color.Gray;
            this.showDataButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showDataButton.Iconcolor = System.Drawing.Color.Transparent;
            this.showDataButton.Iconimage = global::SEP_Framework.Properties.Resources.eye;
            this.showDataButton.Iconimage_right = null;
            this.showDataButton.Iconimage_right_Selected = null;
            this.showDataButton.Iconimage_Selected = null;
            this.showDataButton.IconMarginLeft = 20;
            this.showDataButton.IconMarginRight = 0;
            this.showDataButton.IconRightVisible = true;
            this.showDataButton.IconRightZoom = 0D;
            this.showDataButton.IconVisible = true;
            this.showDataButton.IconZoom = 40D;
            this.showDataButton.IsTab = false;
            this.showDataButton.Location = new System.Drawing.Point(0, 46);
            this.showDataButton.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.showDataButton.Name = "showDataButton";
            this.showDataButton.Normalcolor = System.Drawing.Color.Transparent;
            this.showDataButton.OnHovercolor = System.Drawing.Color.DeepSkyBlue;
            this.showDataButton.OnHoverTextColor = System.Drawing.Color.White;
            this.showDataButton.selected = false;
            this.showDataButton.Size = new System.Drawing.Size(242, 48);
            this.showDataButton.TabIndex = 8;
            this.showDataButton.Text = "Hiển thị dữ liệu";
            this.showDataButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.showDataButton.Textcolor = System.Drawing.Color.White;
            this.showDataButton.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showDataButton.Click += new System.EventHandler(this.showDataButton_Click);
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.tableDropdown);
            this.panel3.Controls.Add(this.panel1);
            this.panel3.Controls.Add(this.chooseTableLabel);
            this.panel3.Controls.Add(this.panel2);
            this.panel3.Location = new System.Drawing.Point(2, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(923, 420);
            this.panel3.TabIndex = 4;
            // 
            // tableDropdown
            // 
            this.tableDropdown.BackColor = System.Drawing.Color.Transparent;
            this.tableDropdown.BackgroundImage = global::SEP_Framework.Properties.Resources.round_bg_image;
            this.tableDropdown.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.tableDropdown.BorderRadius = 3;
            this.tableDropdown.ForeColor = System.Drawing.Color.SteelBlue;
            this.tableDropdown.Items = new string[0];
            this.tableDropdown.Location = new System.Drawing.Point(338, 45);
            this.tableDropdown.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.tableDropdown.Name = "tableDropdown";
            this.tableDropdown.NomalColor = System.Drawing.Color.Transparent;
            this.tableDropdown.onHoverColor = System.Drawing.Color.Transparent;
            this.tableDropdown.selectedIndex = -1;
            this.tableDropdown.Size = new System.Drawing.Size(200, 59);
            this.tableDropdown.TabIndex = 0;
            // 
            // HomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.ClientSize = new System.Drawing.Size(929, 426);
            this.Controls.Add(this.panel3);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "HomeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HomeForm";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.minimizeButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.closeButton)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private Bunifu.Framework.UI.BunifuImageButton minimizeButton;
        private System.Windows.Forms.Label formTitleLabel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.Framework.UI.BunifuImageButton closeButton;
        private System.Windows.Forms.Label chooseTableLabel;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuDropdown tableDropdown;
        private System.Windows.Forms.Panel panel3;
        private Bunifu.Framework.UI.BunifuFlatButton showDataButton;
        private Bunifu.Framework.UI.BunifuFlatButton deleteDataButton;
        private Bunifu.Framework.UI.BunifuFlatButton editDataButton;
        private Bunifu.Framework.UI.BunifuFlatButton addDataButton;
    }
}