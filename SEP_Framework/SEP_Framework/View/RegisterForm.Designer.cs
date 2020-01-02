namespace SEP_Framework
{
    partial class RegisterForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegisterForm));
            this.loginTitleLabel = new System.Windows.Forms.Label();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.registerButton = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuElipse2 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.infoPanel = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.memberTitle = new System.Windows.Forms.Label();
            this.sepFramworkLabel = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.membershipTitle = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.registerTitle = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.label5 = new System.Windows.Forms.Label();
            this.closeButton = new System.Windows.Forms.PictureBox();
            this.password2TextBox = new Bunifu.Framework.UI.BunifuTextbox();
            this.passwordTextBox = new Bunifu.Framework.UI.BunifuTextbox();
            this.usernameTextBox = new Bunifu.Framework.UI.BunifuTextbox();
            this.infoPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.closeButton)).BeginInit();
            this.SuspendLayout();
            // 
            // loginTitleLabel
            // 
            this.loginTitleLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.loginTitleLabel.AutoSize = true;
            this.loginTitleLabel.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginTitleLabel.ForeColor = System.Drawing.Color.White;
            this.loginTitleLabel.Location = new System.Drawing.Point(221, 102);
            this.loginTitleLabel.Name = "loginTitleLabel";
            this.loginTitleLabel.Size = new System.Drawing.Size(141, 23);
            this.loginTitleLabel.TabIndex = 2;
            this.loginTitleLabel.Text = "Tạo tài khoản";
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.BackColor = System.Drawing.Color.White;
            this.usernameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.usernameLabel.Location = new System.Drawing.Point(389, 102);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(116, 20);
            this.usernameLabel.TabIndex = 4;
            this.usernameLabel.Text = "Tên đăng nhập";
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.BackColor = System.Drawing.Color.White;
            this.passwordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.passwordLabel.Location = new System.Drawing.Point(389, 182);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(75, 20);
            this.passwordLabel.TabIndex = 5;
            this.passwordLabel.Text = "Mật khẩu";
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 16;
            this.bunifuElipse1.TargetControl = this;
            // 
            // registerButton
            // 
            this.registerButton.Activecolor = System.Drawing.Color.DeepSkyBlue;
            this.registerButton.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.registerButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.registerButton.BorderRadius = 0;
            this.registerButton.ButtonText = "TẠO TÀI KHOẢN";
            this.registerButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.registerButton.DisabledColor = System.Drawing.Color.Gray;
            this.registerButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registerButton.Iconcolor = System.Drawing.Color.Transparent;
            this.registerButton.Iconimage = null;
            this.registerButton.Iconimage_right = null;
            this.registerButton.Iconimage_right_Selected = null;
            this.registerButton.Iconimage_Selected = null;
            this.registerButton.IconMarginLeft = 0;
            this.registerButton.IconMarginRight = 0;
            this.registerButton.IconRightVisible = true;
            this.registerButton.IconRightZoom = 0D;
            this.registerButton.IconVisible = true;
            this.registerButton.IconZoom = 90D;
            this.registerButton.IsTab = false;
            this.registerButton.Location = new System.Drawing.Point(393, 386);
            this.registerButton.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.registerButton.Name = "registerButton";
            this.registerButton.Normalcolor = System.Drawing.Color.DeepSkyBlue;
            this.registerButton.OnHovercolor = System.Drawing.SystemColors.Highlight;
            this.registerButton.OnHoverTextColor = System.Drawing.Color.White;
            this.registerButton.selected = false;
            this.registerButton.Size = new System.Drawing.Size(254, 48);
            this.registerButton.TabIndex = 7;
            this.registerButton.Text = "TẠO TÀI KHOẢN";
            this.registerButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.registerButton.Textcolor = System.Drawing.Color.White;
            this.registerButton.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registerButton.Click += new System.EventHandler(this.registerButton_Click_1);
            // 
            // bunifuElipse2
            // 
            this.bunifuElipse2.ElipseRadius = 24;
            this.bunifuElipse2.TargetControl = this.registerButton;
            // 
            // infoPanel
            // 
            this.infoPanel.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.infoPanel.Controls.Add(this.label4);
            this.infoPanel.Controls.Add(this.label3);
            this.infoPanel.Controls.Add(this.label2);
            this.infoPanel.Controls.Add(this.label1);
            this.infoPanel.Controls.Add(this.memberTitle);
            this.infoPanel.Controls.Add(this.sepFramworkLabel);
            this.infoPanel.Controls.Add(this.membershipTitle);
            this.infoPanel.Location = new System.Drawing.Point(0, -2);
            this.infoPanel.Name = "infoPanel";
            this.infoPanel.Size = new System.Drawing.Size(350, 500);
            this.infoPanel.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(32, 388);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Nguyễn Hữu Tú";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(32, 351);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Lê Hồ Hữu Trí";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(32, 314);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Huỳnh Trung Tín";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(32, 274);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nguyễn Ngô Tín";
            // 
            // memberTitle
            // 
            this.memberTitle.AutoSize = true;
            this.memberTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.memberTitle.ForeColor = System.Drawing.Color.White;
            this.memberTitle.Location = new System.Drawing.Point(33, 241);
            this.memberTitle.Name = "memberTitle";
            this.memberTitle.Size = new System.Drawing.Size(138, 16);
            this.memberTitle.TabIndex = 2;
            this.memberTitle.Text = "Danh sách thành viên:";
            // 
            // sepFramworkLabel
            // 
            this.sepFramworkLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.sepFramworkLabel.AutoSize = true;
            this.sepFramworkLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sepFramworkLabel.ForeColor = System.Drawing.Color.White;
            this.sepFramworkLabel.Location = new System.Drawing.Point(29, 104);
            this.sepFramworkLabel.Name = "sepFramworkLabel";
            this.sepFramworkLabel.Size = new System.Drawing.Size(302, 42);
            this.sepFramworkLabel.TabIndex = 1;
            this.sepFramworkLabel.Text = "SEP Framework";
            // 
            // membershipTitle
            // 
            this.membershipTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.membershipTitle.AutoSize = true;
            this.membershipTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.membershipTitle.ForeColor = System.Drawing.Color.White;
            this.membershipTitle.Location = new System.Drawing.Point(129, 61);
            this.membershipTitle.Name = "membershipTitle";
            this.membershipTitle.Size = new System.Drawing.Size(78, 29);
            this.membershipTitle.TabIndex = 0;
            this.membershipTitle.Text = "Demo";
            // 
            // registerTitle
            // 
            this.registerTitle.AutoSize = true;
            this.registerTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registerTitle.ForeColor = System.Drawing.SystemColors.Highlight;
            this.registerTitle.Location = new System.Drawing.Point(421, 46);
            this.registerTitle.Name = "registerTitle";
            this.registerTitle.Size = new System.Drawing.Size(226, 37);
            this.registerTitle.TabIndex = 11;
            this.registerTitle.Text = "Tạo tài khoản";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label5.Location = new System.Drawing.Point(389, 261);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(136, 20);
            this.label5.TabIndex = 12;
            this.label5.Text = "Nhập lại mật khẩu";
            // 
            // closeButton
            // 
            this.closeButton.Image = global::SEP_Framework.Properties.Resources.cancel;
            this.closeButton.Location = new System.Drawing.Point(672, 10);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(19, 18);
            this.closeButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.closeButton.TabIndex = 14;
            this.closeButton.TabStop = false;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // password2TextBox
            // 
            this.password2TextBox.BackColor = System.Drawing.Color.White;
            this.password2TextBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("password2TextBox.BackgroundImage")));
            this.password2TextBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.password2TextBox.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.password2TextBox.Icon = ((System.Drawing.Image)(resources.GetObject("password2TextBox.Icon")));
            this.password2TextBox.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.password2TextBox.Location = new System.Drawing.Point(393, 284);
            this.password2TextBox.Name = "password2TextBox";
            this.password2TextBox.Size = new System.Drawing.Size(254, 42);
            this.password2TextBox.TabIndex = 13;
            this.password2TextBox.text = "";
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.BackColor = System.Drawing.Color.White;
            this.passwordTextBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("passwordTextBox.BackgroundImage")));
            this.passwordTextBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.passwordTextBox.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.passwordTextBox.Icon = ((System.Drawing.Image)(resources.GetObject("passwordTextBox.Icon")));
            this.passwordTextBox.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.passwordTextBox.Location = new System.Drawing.Point(393, 205);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(254, 42);
            this.passwordTextBox.TabIndex = 6;
            this.passwordTextBox.text = "";
            // 
            // usernameTextBox
            // 
            this.usernameTextBox.BackColor = System.Drawing.Color.White;
            this.usernameTextBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("usernameTextBox.BackgroundImage")));
            this.usernameTextBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.usernameTextBox.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.usernameTextBox.Icon = ((System.Drawing.Image)(resources.GetObject("usernameTextBox.Icon")));
            this.usernameTextBox.Location = new System.Drawing.Point(393, 125);
            this.usernameTextBox.Name = "usernameTextBox";
            this.usernameTextBox.Size = new System.Drawing.Size(254, 42);
            this.usernameTextBox.TabIndex = 3;
            this.usernameTextBox.text = "";
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(700, 500);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.password2TextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.registerTitle);
            this.Controls.Add(this.infoPanel);
            this.Controls.Add(this.registerButton);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.usernameLabel);
            this.Controls.Add(this.usernameTextBox);
            this.Controls.Add(this.loginTitleLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(700, 500);
            this.MinimumSize = new System.Drawing.Size(700, 500);
            this.Name = "RegisterForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng nhập";
            this.infoPanel.ResumeLayout(false);
            this.infoPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.closeButton)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label loginTitleLabel;
        private Bunifu.Framework.UI.BunifuTextbox usernameTextBox;
        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.Label passwordLabel;
        private Bunifu.Framework.UI.BunifuTextbox passwordTextBox;
        private Bunifu.Framework.UI.BunifuFlatButton registerButton;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        public Bunifu.Framework.UI.BunifuElipse bunifuElipse2;
        private System.Windows.Forms.Panel infoPanel;
        private Bunifu.Framework.UI.BunifuCustomLabel sepFramworkLabel;
        private Bunifu.Framework.UI.BunifuCustomLabel membershipTitle;
        private System.Windows.Forms.Label memberTitle;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuTextbox password2TextBox;
        private System.Windows.Forms.Label label5;
        private Bunifu.Framework.UI.BunifuCustomLabel registerTitle;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox closeButton;
    }
}

