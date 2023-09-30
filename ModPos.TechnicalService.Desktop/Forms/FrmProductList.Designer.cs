namespace ModPos.TechnicalService.Desktop.Forms
{
    partial class FrmProductList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmProductList));
            gridProductList = new DevExpress.XtraGrid.GridControl();
            gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            groupControl1 = new DevExpress.XtraEditors.GroupControl();
            TxtProductId = new DevExpress.XtraEditors.TextEdit();
            labelControl8 = new DevExpress.XtraEditors.LabelControl();
            btnList = new DevExpress.XtraEditors.SimpleButton();
            BtnUpdate = new DevExpress.XtraEditors.SimpleButton();
            BtnDelete = new DevExpress.XtraEditors.SimpleButton();
            BtnSave = new DevExpress.XtraEditors.SimpleButton();
            lookUpEdit1 = new DevExpress.XtraEditors.LookUpEdit();
            TxtSellingPrice = new DevExpress.XtraEditors.TextEdit();
            labelControl7 = new DevExpress.XtraEditors.LabelControl();
            TxtPurchasePrice = new DevExpress.XtraEditors.TextEdit();
            labelControl4 = new DevExpress.XtraEditors.LabelControl();
            TxtProductBarcode = new DevExpress.XtraEditors.TextEdit();
            labelControl5 = new DevExpress.XtraEditors.LabelControl();
            TxtProductSerialNumber = new DevExpress.XtraEditors.TextEdit();
            labelControl6 = new DevExpress.XtraEditors.LabelControl();
            TxtProductName = new DevExpress.XtraEditors.TextEdit();
            labelControl3 = new DevExpress.XtraEditors.LabelControl();
            labelControl2 = new DevExpress.XtraEditors.LabelControl();
            TxtProductCode = new DevExpress.XtraEditors.TextEdit();
            labelControl1 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)gridProductList).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)groupControl1).BeginInit();
            groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)TxtProductId.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)lookUpEdit1.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)TxtSellingPrice.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)TxtPurchasePrice.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)TxtProductBarcode.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)TxtProductSerialNumber.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)TxtProductName.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)TxtProductCode.Properties).BeginInit();
            SuspendLayout();
            // 
            // gridProductList
            // 
            gridProductList.Location = new Point(12, 12);
            gridProductList.MainView = gridView1;
            gridProductList.Name = "gridProductList";
            gridProductList.Size = new Size(939, 825);
            gridProductList.TabIndex = 3;
            gridProductList.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] { gridView1 });
            // 
            // gridView1
            // 
            gridView1.GridControl = gridProductList;
            gridView1.Name = "gridView1";
            gridView1.FocusedRowChanged += gridView1_FocusedRowChanged;
            // 
            // groupControl1
            // 
            groupControl1.Controls.Add(TxtProductId);
            groupControl1.Controls.Add(labelControl8);
            groupControl1.Controls.Add(btnList);
            groupControl1.Controls.Add(BtnUpdate);
            groupControl1.Controls.Add(BtnDelete);
            groupControl1.Controls.Add(BtnSave);
            groupControl1.Controls.Add(lookUpEdit1);
            groupControl1.Controls.Add(TxtSellingPrice);
            groupControl1.Controls.Add(labelControl7);
            groupControl1.Controls.Add(TxtPurchasePrice);
            groupControl1.Controls.Add(labelControl4);
            groupControl1.Controls.Add(TxtProductBarcode);
            groupControl1.Controls.Add(labelControl5);
            groupControl1.Controls.Add(TxtProductSerialNumber);
            groupControl1.Controls.Add(labelControl6);
            groupControl1.Controls.Add(TxtProductName);
            groupControl1.Controls.Add(labelControl3);
            groupControl1.Controls.Add(labelControl2);
            groupControl1.Controls.Add(TxtProductCode);
            groupControl1.Controls.Add(labelControl1);
            groupControl1.Location = new Point(957, 12);
            groupControl1.Name = "groupControl1";
            groupControl1.Size = new Size(473, 825);
            groupControl1.TabIndex = 4;
            groupControl1.Text = "ÜRÜN İŞLEMLERİ";
            // 
            // TxtProductId
            // 
            TxtProductId.Enabled = false;
            TxtProductId.Location = new Point(143, 57);
            TxtProductId.Name = "TxtProductId";
            TxtProductId.Size = new Size(257, 20);
            TxtProductId.TabIndex = 27;
            // 
            // labelControl8
            // 
            labelControl8.Location = new Point(88, 60);
            labelControl8.Name = "labelControl8";
            labelControl8.Size = new Size(49, 13);
            labelControl8.TabIndex = 26;
            labelControl8.Text = "ÜRÜN ID :";
            // 
            // btnList
            // 
            btnList.ImageOptions.Image = (Image)resources.GetObject("btnList.ImageOptions.Image");
            btnList.Location = new Point(143, 417);
            btnList.Name = "btnList";
            btnList.Size = new Size(257, 35);
            btnList.TabIndex = 25;
            btnList.Text = "LİSTELE";
            btnList.Click += btnList_Click;
            // 
            // BtnUpdate
            // 
            BtnUpdate.ImageOptions.Image = (Image)resources.GetObject("BtnUpdate.ImageOptions.Image");
            BtnUpdate.Location = new Point(143, 376);
            BtnUpdate.Name = "BtnUpdate";
            BtnUpdate.Size = new Size(257, 35);
            BtnUpdate.TabIndex = 23;
            BtnUpdate.Text = "GÜNCELLE";
            BtnUpdate.Click += BtnUpdate_Click;
            // 
            // BtnDelete
            // 
            BtnDelete.ImageOptions.Image = (Image)resources.GetObject("BtnDelete.ImageOptions.Image");
            BtnDelete.Location = new Point(143, 335);
            BtnDelete.Name = "BtnDelete";
            BtnDelete.Size = new Size(257, 35);
            BtnDelete.TabIndex = 22;
            BtnDelete.Text = "SİL";
            BtnDelete.Click += BtnDelete_Click;
            // 
            // BtnSave
            // 
            BtnSave.ImageOptions.Image = (Image)resources.GetObject("BtnSave.ImageOptions.Image");
            BtnSave.Location = new Point(143, 294);
            BtnSave.Name = "BtnSave";
            BtnSave.Size = new Size(257, 35);
            BtnSave.TabIndex = 21;
            BtnSave.Text = "KAYDET";
            BtnSave.Click += BtnSave_Click;
            // 
            // lookUpEdit1
            // 
            lookUpEdit1.Location = new Point(143, 116);
            lookUpEdit1.Name = "lookUpEdit1";
            lookUpEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            lookUpEdit1.Properties.DisplayMember = "CategoryName";
            lookUpEdit1.Properties.ValueMember = "CategoryId";
            lookUpEdit1.Size = new Size(258, 20);
            lookUpEdit1.TabIndex = 20;
            // 
            // TxtSellingPrice
            // 
            TxtSellingPrice.Location = new Point(143, 268);
            TxtSellingPrice.Name = "TxtSellingPrice";
            TxtSellingPrice.Size = new Size(257, 20);
            TxtSellingPrice.TabIndex = 19;
            // 
            // labelControl7
            // 
            labelControl7.Location = new Point(65, 271);
            labelControl7.Name = "labelControl7";
            labelControl7.Size = new Size(72, 13);
            labelControl7.TabIndex = 18;
            labelControl7.Text = "SATIŞ FİYATI :";
            // 
            // TxtPurchasePrice
            // 
            TxtPurchasePrice.Location = new Point(143, 239);
            TxtPurchasePrice.Name = "TxtPurchasePrice";
            TxtPurchasePrice.Size = new Size(257, 20);
            TxtPurchasePrice.TabIndex = 17;
            // 
            // labelControl4
            // 
            labelControl4.Location = new Point(72, 242);
            labelControl4.Name = "labelControl4";
            labelControl4.Size = new Size(65, 13);
            labelControl4.TabIndex = 16;
            labelControl4.Text = "ALIŞ FİYATI :";
            // 
            // TxtProductBarcode
            // 
            TxtProductBarcode.Location = new Point(143, 209);
            TxtProductBarcode.Name = "TxtProductBarcode";
            TxtProductBarcode.Size = new Size(257, 20);
            TxtProductBarcode.TabIndex = 15;
            // 
            // labelControl5
            // 
            labelControl5.Location = new Point(58, 212);
            labelControl5.Name = "labelControl5";
            labelControl5.Size = new Size(79, 13);
            labelControl5.TabIndex = 14;
            labelControl5.Text = "ÜRÜN BARKOD :";
            // 
            // TxtProductSerialNumber
            // 
            TxtProductSerialNumber.Location = new Point(143, 178);
            TxtProductSerialNumber.Name = "TxtProductSerialNumber";
            TxtProductSerialNumber.Size = new Size(257, 20);
            TxtProductSerialNumber.TabIndex = 13;
            // 
            // labelControl6
            // 
            labelControl6.Location = new Point(20, 181);
            labelControl6.Name = "labelControl6";
            labelControl6.Size = new Size(117, 13);
            labelControl6.TabIndex = 12;
            labelControl6.Text = "ÜRÜN SERİ NUMARASI :";
            // 
            // TxtProductName
            // 
            TxtProductName.Location = new Point(143, 146);
            TxtProductName.Name = "TxtProductName";
            TxtProductName.Size = new Size(257, 20);
            TxtProductName.TabIndex = 11;
            // 
            // labelControl3
            // 
            labelControl3.Location = new Point(81, 149);
            labelControl3.Name = "labelControl3";
            labelControl3.Size = new Size(56, 13);
            labelControl3.TabIndex = 10;
            labelControl3.Text = "ÜRÜN ADI :";
            // 
            // labelControl2
            // 
            labelControl2.Location = new Point(79, 119);
            labelControl2.Name = "labelControl2";
            labelControl2.Size = new Size(58, 13);
            labelControl2.TabIndex = 8;
            labelControl2.Text = "KATEGORİ :";
            // 
            // TxtProductCode
            // 
            TxtProductCode.Location = new Point(143, 85);
            TxtProductCode.Name = "TxtProductCode";
            TxtProductCode.Size = new Size(257, 20);
            TxtProductCode.TabIndex = 7;
            // 
            // labelControl1
            // 
            labelControl1.Location = new Point(71, 88);
            labelControl1.Name = "labelControl1";
            labelControl1.Size = new Size(66, 13);
            labelControl1.TabIndex = 6;
            labelControl1.Text = "ÜRÜN KODU :";
            // 
            // FrmProductList
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1442, 849);
            Controls.Add(groupControl1);
            Controls.Add(gridProductList);
            Name = "FrmProductList";
            Text = "FrmProductList";
            Load += FrmProductList_Load;
            ((System.ComponentModel.ISupportInitialize)gridProductList).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)groupControl1).EndInit();
            groupControl1.ResumeLayout(false);
            groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)TxtProductId.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)lookUpEdit1.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)TxtSellingPrice.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)TxtPurchasePrice.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)TxtProductBarcode.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)TxtProductSerialNumber.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)TxtProductName.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)TxtProductCode.Properties).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridProductList;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.TextEdit TxtProductName;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit TxtProductCode;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit TxtSellingPrice;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.TextEdit TxtPurchasePrice;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit TxtProductBarcode;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.TextEdit TxtProductSerialNumber;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.SimpleButton BtnUpdate;
        private DevExpress.XtraEditors.SimpleButton BtnDelete;
        private DevExpress.XtraEditors.SimpleButton BtnSave;
        private DevExpress.XtraEditors.LookUpEdit lookUpEdit1;
        private DevExpress.XtraEditors.TextEdit TxtProductCategoryId;
        private DevExpress.XtraEditors.SimpleButton btnList;
        private DevExpress.XtraEditors.TextEdit TxtProductId;
        private DevExpress.XtraEditors.LabelControl labelControl8;
    }
}