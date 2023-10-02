namespace ModPos.TechnicalService.Desktop.Forms
{
    partial class FrmCategoryCreate
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCategoryCreate));
            BtnCancel = new DevExpress.XtraEditors.SimpleButton();
            textEdit10 = new DevExpress.XtraEditors.TextEdit();
            pictureEdit8 = new DevExpress.XtraEditors.PictureEdit();
            pictureEdit1 = new DevExpress.XtraEditors.PictureEdit();
            BtnSave = new DevExpress.XtraEditors.SimpleButton();
            panel1 = new Panel();
            TxtCategoryName = new DevExpress.XtraEditors.TextEdit();
            labelControl1 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)textEdit10.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureEdit8.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureEdit1.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)TxtCategoryName.Properties).BeginInit();
            SuspendLayout();
            // 
            // BtnCancel
            // 
            BtnCancel.ImageOptions.Image = (Image)resources.GetObject("BtnCancel.ImageOptions.Image");
            BtnCancel.Location = new Point(209, 180);
            BtnCancel.Name = "BtnCancel";
            BtnCancel.Size = new Size(185, 52);
            BtnCancel.TabIndex = 47;
            BtnCancel.Text = "Vazgeç";
            BtnCancel.Click += BtnCancel_Click;
            // 
            // textEdit10
            // 
            textEdit10.EditValue = "YENİ KATEGORİ EKLEME";
            textEdit10.Location = new Point(149, 27);
            textEdit10.Name = "textEdit10";
            textEdit10.Properties.Appearance.BackColor = Color.FromArgb(34, 36, 49);
            textEdit10.Properties.Appearance.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textEdit10.Properties.Appearance.ForeColor = Color.White;
            textEdit10.Properties.Appearance.Options.UseBackColor = true;
            textEdit10.Properties.Appearance.Options.UseFont = true;
            textEdit10.Properties.Appearance.Options.UseForeColor = true;
            textEdit10.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            textEdit10.Size = new Size(181, 26);
            textEdit10.TabIndex = 45;
            // 
            // pictureEdit8
            // 
            pictureEdit8.EditValue = resources.GetObject("pictureEdit8.EditValue");
            pictureEdit8.Location = new Point(59, 5);
            pictureEdit8.Name = "pictureEdit8";
            pictureEdit8.Properties.Appearance.BackColor = Color.Transparent;
            pictureEdit8.Properties.Appearance.Options.UseBackColor = true;
            pictureEdit8.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            pictureEdit8.Size = new Size(69, 64);
            pictureEdit8.TabIndex = 44;
            // 
            // pictureEdit1
            // 
            pictureEdit1.EditValue = resources.GetObject("pictureEdit1.EditValue");
            pictureEdit1.Location = new Point(9, 101);
            pictureEdit1.Name = "pictureEdit1";
            pictureEdit1.Properties.Appearance.BackColor = Color.Transparent;
            pictureEdit1.Properties.Appearance.Options.UseBackColor = true;
            pictureEdit1.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            pictureEdit1.Size = new Size(46, 38);
            pictureEdit1.TabIndex = 35;
            // 
            // BtnSave
            // 
            BtnSave.ImageOptions.Image = (Image)resources.GetObject("BtnSave.ImageOptions.Image");
            BtnSave.Location = new Point(9, 180);
            BtnSave.Name = "BtnSave";
            BtnSave.Size = new Size(185, 52);
            BtnSave.TabIndex = 46;
            BtnSave.Text = "Kaydet";
            BtnSave.Click += BtnSave_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Location = new Point(75, 136);
            panel1.Name = "panel1";
            panel1.Size = new Size(319, 3);
            panel1.TabIndex = 24;
            // 
            // TxtCategoryName
            // 
            TxtCategoryName.EditValue = "";
            TxtCategoryName.Location = new Point(189, 104);
            TxtCategoryName.Name = "TxtCategoryName";
            TxtCategoryName.Properties.Appearance.BackColor = Color.FromArgb(34, 36, 49);
            TxtCategoryName.Properties.Appearance.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            TxtCategoryName.Properties.Appearance.ForeColor = Color.White;
            TxtCategoryName.Properties.Appearance.Options.UseBackColor = true;
            TxtCategoryName.Properties.Appearance.Options.UseFont = true;
            TxtCategoryName.Properties.Appearance.Options.UseForeColor = true;
            TxtCategoryName.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            TxtCategoryName.Size = new Size(203, 26);
            TxtCategoryName.TabIndex = 23;
            // 
            // labelControl1
            // 
            labelControl1.Appearance.BackColor = Color.Transparent;
            labelControl1.Appearance.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelControl1.Appearance.ForeColor = Color.White;
            labelControl1.Appearance.Options.UseBackColor = true;
            labelControl1.Appearance.Options.UseFont = true;
            labelControl1.Appearance.Options.UseForeColor = true;
            labelControl1.Location = new Point(75, 107);
            labelControl1.Name = "labelControl1";
            labelControl1.Size = new Size(108, 21);
            labelControl1.TabIndex = 48;
            labelControl1.Text = "KATEGORİ ADI :";
            // 
            // FrmCategoryCreate
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(34, 36, 49);
            ClientSize = new Size(404, 282);
            Controls.Add(labelControl1);
            Controls.Add(BtnCancel);
            Controls.Add(textEdit10);
            Controls.Add(pictureEdit8);
            Controls.Add(pictureEdit1);
            Controls.Add(BtnSave);
            Controls.Add(panel1);
            Controls.Add(TxtCategoryName);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "FrmCategoryCreate";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmCategoryCreate";
            ((System.ComponentModel.ISupportInitialize)textEdit10.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureEdit8.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureEdit1.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)TxtCategoryName.Properties).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton BtnCancel;
        private DevExpress.XtraEditors.TextEdit textEdit10;
        private DevExpress.XtraEditors.PictureEdit pictureEdit8;
        private DevExpress.XtraEditors.PictureEdit pictureEdit1;
        private DevExpress.XtraEditors.SimpleButton BtnSave;
        private Panel panel1;
        private DevExpress.XtraEditors.TextEdit TxtCategoryName;
        private DevExpress.XtraEditors.LabelControl labelControl1;
    }
}