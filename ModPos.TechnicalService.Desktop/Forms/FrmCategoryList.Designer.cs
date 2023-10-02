namespace ModPos.TechnicalService.Desktop.Forms
{
    partial class FrmCategoryList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCategoryList));
            TxtCategoryId = new DevExpress.XtraEditors.TextEdit();
            labelControl8 = new DevExpress.XtraEditors.LabelControl();
            btnList = new DevExpress.XtraEditors.SimpleButton();
            BtnUpdate = new DevExpress.XtraEditors.SimpleButton();
            BtnDelete = new DevExpress.XtraEditors.SimpleButton();
            BtnSave = new DevExpress.XtraEditors.SimpleButton();
            TxtCategoryName = new DevExpress.XtraEditors.TextEdit();
            labelControl1 = new DevExpress.XtraEditors.LabelControl();
            groupControl1 = new DevExpress.XtraEditors.GroupControl();
            gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            gridCategoryList = new DevExpress.XtraGrid.GridControl();
            ((System.ComponentModel.ISupportInitialize)TxtCategoryId.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)TxtCategoryName.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)groupControl1).BeginInit();
            groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridCategoryList).BeginInit();
            SuspendLayout();
            // 
            // TxtCategoryId
            // 
            TxtCategoryId.Enabled = false;
            TxtCategoryId.Location = new Point(143, 70);
            TxtCategoryId.Name = "TxtCategoryId";
            TxtCategoryId.Size = new Size(257, 20);
            TxtCategoryId.TabIndex = 27;
            // 
            // labelControl8
            // 
            labelControl8.Location = new Point(65, 73);
            labelControl8.Name = "labelControl8";
            labelControl8.Size = new Size(72, 13);
            labelControl8.TabIndex = 26;
            labelControl8.Text = "KATEGORİ ID :";
            // 
            // btnList
            // 
            btnList.ImageOptions.Image = (Image)resources.GetObject("btnList.ImageOptions.Image");
            btnList.Location = new Point(143, 266);
            btnList.Name = "btnList";
            btnList.Size = new Size(257, 35);
            btnList.TabIndex = 25;
            btnList.Text = "LİSTELE";
            btnList.Click += btnList_Click;
            // 
            // BtnUpdate
            // 
            BtnUpdate.ImageOptions.Image = (Image)resources.GetObject("BtnUpdate.ImageOptions.Image");
            BtnUpdate.Location = new Point(143, 225);
            BtnUpdate.Name = "BtnUpdate";
            BtnUpdate.Size = new Size(257, 35);
            BtnUpdate.TabIndex = 23;
            BtnUpdate.Text = "GÜNCELLE";
            BtnUpdate.Click += BtnUpdate_Click;
            // 
            // BtnDelete
            // 
            BtnDelete.ImageOptions.Image = (Image)resources.GetObject("BtnDelete.ImageOptions.Image");
            BtnDelete.Location = new Point(143, 184);
            BtnDelete.Name = "BtnDelete";
            BtnDelete.Size = new Size(257, 35);
            BtnDelete.TabIndex = 22;
            BtnDelete.Text = "SİL";
            BtnDelete.Click += BtnDelete_Click;
            // 
            // BtnSave
            // 
            BtnSave.ImageOptions.Image = (Image)resources.GetObject("BtnSave.ImageOptions.Image");
            BtnSave.Location = new Point(143, 143);
            BtnSave.Name = "BtnSave";
            BtnSave.Size = new Size(257, 35);
            BtnSave.TabIndex = 21;
            BtnSave.Text = "KAYDET";
            BtnSave.Click += BtnSave_Click;
            // 
            // TxtCategoryName
            // 
            TxtCategoryName.Location = new Point(143, 98);
            TxtCategoryName.Name = "TxtCategoryName";
            TxtCategoryName.Size = new Size(257, 20);
            TxtCategoryName.TabIndex = 7;
            // 
            // labelControl1
            // 
            labelControl1.Location = new Point(58, 101);
            labelControl1.Name = "labelControl1";
            labelControl1.Size = new Size(79, 13);
            labelControl1.TabIndex = 6;
            labelControl1.Text = "KATEGORİ ADI :";
            // 
            // groupControl1
            // 
            groupControl1.Controls.Add(TxtCategoryId);
            groupControl1.Controls.Add(labelControl8);
            groupControl1.Controls.Add(btnList);
            groupControl1.Controls.Add(BtnUpdate);
            groupControl1.Controls.Add(BtnDelete);
            groupControl1.Controls.Add(BtnSave);
            groupControl1.Controls.Add(TxtCategoryName);
            groupControl1.Controls.Add(labelControl1);
            groupControl1.Location = new Point(957, 12);
            groupControl1.Name = "groupControl1";
            groupControl1.Size = new Size(473, 825);
            groupControl1.TabIndex = 6;
            groupControl1.Text = "KATEGORİ İŞLEMLERİ";
            // 
            // gridView1
            // 
            gridView1.GridControl = gridCategoryList;
            gridView1.Name = "gridView1";
            gridView1.FocusedRowChanged += gridView1_FocusedRowChanged;
            // 
            // gridCategoryList
            // 
            gridCategoryList.Location = new Point(12, 12);
            gridCategoryList.MainView = gridView1;
            gridCategoryList.Name = "gridCategoryList";
            gridCategoryList.Size = new Size(939, 825);
            gridCategoryList.TabIndex = 5;
            gridCategoryList.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] { gridView1 });
            // 
            // FrmCategoryList
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1442, 849);
            Controls.Add(groupControl1);
            Controls.Add(gridCategoryList);
            Name = "FrmCategoryList";
            Text = "FrmCategoryList";
            Load += FrmCategoryList_Load;
            ((System.ComponentModel.ISupportInitialize)TxtCategoryId.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)TxtCategoryName.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)groupControl1).EndInit();
            groupControl1.ResumeLayout(false);
            groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)gridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridCategoryList).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DevExpress.XtraEditors.TextEdit TxtCategoryId;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.SimpleButton btnList;
        private DevExpress.XtraEditors.SimpleButton BtnUpdate;
        private DevExpress.XtraEditors.SimpleButton BtnDelete;
        private DevExpress.XtraEditors.SimpleButton BtnSave;
        private DevExpress.XtraEditors.TextEdit TxtCategoryName;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.GridControl gridCategoryList;
    }
}