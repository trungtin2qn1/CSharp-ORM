namespace SEP_Framework
{
    partial class TempForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TempForm));
            this.cancel = new Bunifu.Framework.UI.BunifuFlatButton();
            this.save = new Bunifu.Framework.UI.BunifuFlatButton();
            this.SuspendLayout();
            // 
            // cancel
            // 
            this.cancel.Activecolor = System.Drawing.Color.Crimson;
            this.cancel.BackColor = System.Drawing.Color.Red;
            this.cancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cancel.BorderRadius = 0;
            this.cancel.ButtonText = "Cancel";
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
            this.cancel.Location = new System.Drawing.Point(343, 111);
            this.cancel.Name = "cancel";
            this.cancel.Normalcolor = System.Drawing.Color.Transparent;
            this.cancel.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cancel.OnHoverTextColor = System.Drawing.Color.White;
            this.cancel.selected = false;
            this.cancel.Size = new System.Drawing.Size(166, 31);
            this.cancel.TabIndex = 1;
            this.cancel.Text = "Cancel";
            this.cancel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cancel.Textcolor = System.Drawing.Color.White;
            this.cancel.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // save
            // 
            this.save.Activecolor = System.Drawing.Color.DeepSkyBlue;
            this.save.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.save.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.save.BorderRadius = 0;
            this.save.ButtonText = "";
            this.save.Cursor = System.Windows.Forms.Cursors.Hand;
            this.save.DisabledColor = System.Drawing.Color.Gray;
            this.save.Iconcolor = System.Drawing.Color.Transparent;
            this.save.Iconimage = ((System.Drawing.Image)(resources.GetObject("save.Iconimage")));
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
            this.save.Location = new System.Drawing.Point(68, 111);
            this.save.Name = "save";
            this.save.Normalcolor = System.Drawing.Color.DeepSkyBlue;
            this.save.OnHovercolor = System.Drawing.SystemColors.Highlight;
            this.save.OnHoverTextColor = System.Drawing.Color.White;
            this.save.selected = false;
            this.save.Size = new System.Drawing.Size(140, 32);
            this.save.TabIndex = 0;
            this.save.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.save.Textcolor = System.Drawing.Color.White;
            this.save.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // TempForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.save);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TempForm";
            this.Text = "TempForm";
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuFlatButton save;
        private Bunifu.Framework.UI.BunifuFlatButton cancel;
    }
}