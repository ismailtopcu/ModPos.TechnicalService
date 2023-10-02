namespace ModPos.TechnicalService.Desktop.Forms
{
    partial class FrmServiceList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmServiceList));
            TxtServiceDescription = new TextBox();
            BtnCustomerService = new DevExpress.XtraEditors.SimpleButton();
            labelControl2 = new DevExpress.XtraEditors.LabelControl();
            labelControl8 = new DevExpress.XtraEditors.LabelControl();
            btnList = new DevExpress.XtraEditors.SimpleButton();
            BtnUpdate = new DevExpress.XtraEditors.SimpleButton();
            BtnDelete = new DevExpress.XtraEditors.SimpleButton();
            BtnSave = new DevExpress.XtraEditors.SimpleButton();
            labelControl5 = new DevExpress.XtraEditors.LabelControl();
            gridServiceMovementsList = new DevExpress.XtraGrid.GridControl();
            gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            labelControl3 = new DevExpress.XtraEditors.LabelControl();
            labelControl1 = new DevExpress.XtraEditors.LabelControl();
            gridServiceList = new DevExpress.XtraGrid.GridControl();
            gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            groupControl1 = new DevExpress.XtraEditors.GroupControl();
            lookUpEdit2 = new DevExpress.XtraEditors.LookUpEdit();
            labelControl15 = new DevExpress.XtraEditors.LabelControl();
            lookUpEdit1 = new DevExpress.XtraEditors.LookUpEdit();
            TxtServiceDate = new DevExpress.XtraEditors.TextEdit();
            TxtServiceNumber = new DevExpress.XtraEditors.TextEdit();
            TxtServiceCode = new DevExpress.XtraEditors.TextEdit();
            TxtServiceId = new DevExpress.XtraEditors.TextEdit();
            labelControl4 = new DevExpress.XtraEditors.LabelControl();
            groupControl2 = new DevExpress.XtraEditors.GroupControl();
            TxtServiceMoveId = new DevExpress.XtraEditors.TextEdit();
            labelControl10 = new DevExpress.XtraEditors.LabelControl();
            lookUpEdit3 = new DevExpress.XtraEditors.LookUpEdit();
            TxtServiceMovementsId = new DevExpress.XtraEditors.TextEdit();
            labelControl6 = new DevExpress.XtraEditors.LabelControl();
            TxtServiceType = new TextBox();
            TxtProductQuantity = new DevExpress.XtraEditors.TextEdit();
            labelControl9 = new DevExpress.XtraEditors.LabelControl();
            BtnMoveList = new DevExpress.XtraEditors.SimpleButton();
            BtnMoveUpdate = new DevExpress.XtraEditors.SimpleButton();
            BtnMoveDelete = new DevExpress.XtraEditors.SimpleButton();
            BtnMoveCreate = new DevExpress.XtraEditors.SimpleButton();
            labelControl11 = new DevExpress.XtraEditors.LabelControl();
            TxtCurrency = new DevExpress.XtraEditors.TextEdit();
            labelControl12 = new DevExpress.XtraEditors.LabelControl();
            TxtServicePrice = new DevExpress.XtraEditors.TextEdit();
            labelControl13 = new DevExpress.XtraEditors.LabelControl();
            labelControl14 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)gridServiceMovementsList).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridView2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridServiceList).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)groupControl1).BeginInit();
            groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)lookUpEdit2.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)lookUpEdit1.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)TxtServiceDate.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)TxtServiceNumber.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)TxtServiceCode.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)TxtServiceId.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)groupControl2).BeginInit();
            groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)TxtServiceMoveId.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)lookUpEdit3.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)TxtServiceMovementsId.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)TxtProductQuantity.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)TxtCurrency.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)TxtServicePrice.Properties).BeginInit();
            SuspendLayout();
            // 
            // TxtServiceDescription
            // 
            TxtServiceDescription.BorderStyle = BorderStyle.FixedSingle;
            TxtServiceDescription.Location = new Point(121, 218);
            TxtServiceDescription.Multiline = true;
            TxtServiceDescription.Name = "TxtServiceDescription";
            TxtServiceDescription.Size = new Size(222, 70);
            TxtServiceDescription.TabIndex = 7;
            // 
            // BtnCustomerService
            // 
            BtnCustomerService.ImageOptions.Image = (Image)resources.GetObject("BtnCustomerService.ImageOptions.Image");
            BtnCustomerService.Location = new Point(121, 306);
            BtnCustomerService.Name = "BtnCustomerService";
            BtnCustomerService.Size = new Size(222, 47);
            BtnCustomerService.TabIndex = 30;
            BtnCustomerService.Text = "SERVİS HAREKETLERİNİ GETİR";
            BtnCustomerService.Click += BtnCustomerService_Click;
            // 
            // labelControl2
            // 
            labelControl2.Location = new Point(20, 136);
            labelControl2.Name = "labelControl2";
            labelControl2.Size = new Size(98, 13);
            labelControl2.TabIndex = 28;
            labelControl2.Text = "SERVİS NUMARASI :";
            // 
            // labelControl8
            // 
            labelControl8.Location = new Point(53, 84);
            labelControl8.Name = "labelControl8";
            labelControl8.Size = new Size(65, 13);
            labelControl8.TabIndex = 26;
            labelControl8.Text = "MÜŞTERİ ID :";
            // 
            // btnList
            // 
            btnList.ImageOptions.Image = (Image)resources.GetObject("btnList.ImageOptions.Image");
            btnList.Location = new Point(360, 192);
            btnList.Name = "btnList";
            btnList.Size = new Size(97, 35);
            btnList.TabIndex = 25;
            btnList.Text = "LİSTELE";
            btnList.Click += btnList_Click;
            // 
            // BtnUpdate
            // 
            BtnUpdate.ImageOptions.Image = (Image)resources.GetObject("BtnUpdate.ImageOptions.Image");
            BtnUpdate.Location = new Point(360, 148);
            BtnUpdate.Name = "BtnUpdate";
            BtnUpdate.Size = new Size(97, 35);
            BtnUpdate.TabIndex = 23;
            BtnUpdate.Text = "GÜNCELLE";
            BtnUpdate.Click += BtnUpdate_Click;
            // 
            // BtnDelete
            // 
            BtnDelete.ImageOptions.Image = (Image)resources.GetObject("BtnDelete.ImageOptions.Image");
            BtnDelete.Location = new Point(360, 103);
            BtnDelete.Name = "BtnDelete";
            BtnDelete.Size = new Size(97, 35);
            BtnDelete.TabIndex = 22;
            BtnDelete.Text = "SİL";
            BtnDelete.Click += BtnDelete_Click;
            // 
            // BtnSave
            // 
            BtnSave.ImageOptions.Image = (Image)resources.GetObject("BtnSave.ImageOptions.Image");
            BtnSave.Location = new Point(360, 62);
            BtnSave.Name = "BtnSave";
            BtnSave.Size = new Size(97, 35);
            BtnSave.TabIndex = 21;
            BtnSave.Text = "OLUŞTUR";
            BtnSave.Click += BtnSave_Click;
            // 
            // labelControl5
            // 
            labelControl5.Location = new Point(30, 162);
            labelControl5.Name = "labelControl5";
            labelControl5.Size = new Size(88, 13);
            labelControl5.TabIndex = 14;
            labelControl5.Text = "SERVİS DURUMU :";
            // 
            // gridServiceMovementsList
            // 
            gridServiceMovementsList.Location = new Point(12, 428);
            gridServiceMovementsList.MainView = gridView2;
            gridServiceMovementsList.Name = "gridServiceMovementsList";
            gridServiceMovementsList.Size = new Size(939, 410);
            gridServiceMovementsList.TabIndex = 38;
            gridServiceMovementsList.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] { gridView2 });
            // 
            // gridView2
            // 
            gridView2.GridControl = gridServiceMovementsList;
            gridView2.Name = "gridView2";
            gridView2.FocusedRowChanged += gridView2_FocusedRowChanged;
            // 
            // labelControl3
            // 
            labelControl3.Location = new Point(12, 220);
            labelControl3.Name = "labelControl3";
            labelControl3.Size = new Size(106, 13);
            labelControl3.TabIndex = 10;
            labelControl3.Text = "SERVİS AÇIKLAMASI :";
            // 
            // labelControl1
            // 
            labelControl1.Location = new Point(52, 110);
            labelControl1.Name = "labelControl1";
            labelControl1.Size = new Size(66, 13);
            labelControl1.TabIndex = 6;
            labelControl1.Text = "SERVİS KOD :";
            // 
            // gridServiceList
            // 
            gridServiceList.Location = new Point(12, 12);
            gridServiceList.MainView = gridView1;
            gridServiceList.Name = "gridServiceList";
            gridServiceList.Size = new Size(939, 410);
            gridServiceList.TabIndex = 36;
            gridServiceList.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] { gridView1 });
            // 
            // gridView1
            // 
            gridView1.GridControl = gridServiceList;
            gridView1.Name = "gridView1";
            gridView1.FocusedRowChanged += gridView1_FocusedRowChanged;
            // 
            // groupControl1
            // 
            groupControl1.Controls.Add(lookUpEdit2);
            groupControl1.Controls.Add(labelControl15);
            groupControl1.Controls.Add(lookUpEdit1);
            groupControl1.Controls.Add(TxtServiceDate);
            groupControl1.Controls.Add(TxtServiceNumber);
            groupControl1.Controls.Add(TxtServiceCode);
            groupControl1.Controls.Add(TxtServiceId);
            groupControl1.Controls.Add(TxtServiceDescription);
            groupControl1.Controls.Add(labelControl4);
            groupControl1.Controls.Add(BtnCustomerService);
            groupControl1.Controls.Add(labelControl2);
            groupControl1.Controls.Add(labelControl8);
            groupControl1.Controls.Add(btnList);
            groupControl1.Controls.Add(BtnUpdate);
            groupControl1.Controls.Add(BtnDelete);
            groupControl1.Controls.Add(BtnSave);
            groupControl1.Controls.Add(labelControl5);
            groupControl1.Controls.Add(labelControl3);
            groupControl1.Controls.Add(labelControl1);
            groupControl1.Location = new Point(957, 12);
            groupControl1.Name = "groupControl1";
            groupControl1.Size = new Size(473, 410);
            groupControl1.TabIndex = 37;
            groupControl1.Text = "SERVİS İŞLEMLERİ";
            // 
            // lookUpEdit2
            // 
            lookUpEdit2.Location = new Point(121, 81);
            lookUpEdit2.Name = "lookUpEdit2";
            lookUpEdit2.Properties.Appearance.Options.UseFont = true;
            lookUpEdit2.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            lookUpEdit2.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            lookUpEdit2.Size = new Size(222, 20);
            lookUpEdit2.TabIndex = 39;
            // 
            // labelControl15
            // 
            labelControl15.Location = new Point(34, 188);
            labelControl15.Name = "labelControl15";
            labelControl15.Size = new Size(84, 13);
            labelControl15.TabIndex = 38;
            labelControl15.Text = "SERVİS ZAMANI :";
            // 
            // lookUpEdit1
            // 
            lookUpEdit1.Location = new Point(121, 159);
            lookUpEdit1.Name = "lookUpEdit1";
            lookUpEdit1.Properties.Appearance.Options.UseFont = true;
            lookUpEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            lookUpEdit1.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            lookUpEdit1.Size = new Size(222, 20);
            lookUpEdit1.TabIndex = 37;
            // 
            // TxtServiceDate
            // 
            TxtServiceDate.Enabled = false;
            TxtServiceDate.Location = new Point(121, 185);
            TxtServiceDate.Name = "TxtServiceDate";
            TxtServiceDate.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            TxtServiceDate.Size = new Size(222, 20);
            TxtServiceDate.TabIndex = 36;
            // 
            // TxtServiceNumber
            // 
            TxtServiceNumber.Location = new Point(121, 133);
            TxtServiceNumber.Name = "TxtServiceNumber";
            TxtServiceNumber.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            TxtServiceNumber.Size = new Size(222, 20);
            TxtServiceNumber.TabIndex = 35;
            // 
            // TxtServiceCode
            // 
            TxtServiceCode.Location = new Point(121, 107);
            TxtServiceCode.Name = "TxtServiceCode";
            TxtServiceCode.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            TxtServiceCode.Size = new Size(222, 20);
            TxtServiceCode.TabIndex = 34;
            // 
            // TxtServiceId
            // 
            TxtServiceId.Enabled = false;
            TxtServiceId.Location = new Point(121, 55);
            TxtServiceId.Name = "TxtServiceId";
            TxtServiceId.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            TxtServiceId.Size = new Size(222, 20);
            TxtServiceId.TabIndex = 33;
            // 
            // labelControl4
            // 
            labelControl4.Location = new Point(62, 58);
            labelControl4.Name = "labelControl4";
            labelControl4.Size = new Size(56, 13);
            labelControl4.TabIndex = 32;
            labelControl4.Text = "SERVİS ID :";
            // 
            // groupControl2
            // 
            groupControl2.Controls.Add(TxtServiceMoveId);
            groupControl2.Controls.Add(labelControl10);
            groupControl2.Controls.Add(lookUpEdit3);
            groupControl2.Controls.Add(TxtServiceMovementsId);
            groupControl2.Controls.Add(labelControl6);
            groupControl2.Controls.Add(TxtServiceType);
            groupControl2.Controls.Add(TxtProductQuantity);
            groupControl2.Controls.Add(labelControl9);
            groupControl2.Controls.Add(BtnMoveList);
            groupControl2.Controls.Add(BtnMoveUpdate);
            groupControl2.Controls.Add(BtnMoveDelete);
            groupControl2.Controls.Add(BtnMoveCreate);
            groupControl2.Controls.Add(labelControl11);
            groupControl2.Controls.Add(TxtCurrency);
            groupControl2.Controls.Add(labelControl12);
            groupControl2.Controls.Add(TxtServicePrice);
            groupControl2.Controls.Add(labelControl13);
            groupControl2.Controls.Add(labelControl14);
            groupControl2.Location = new Point(957, 428);
            groupControl2.Name = "groupControl2";
            groupControl2.Size = new Size(473, 410);
            groupControl2.TabIndex = 38;
            groupControl2.Text = "SERVİS HAREKETLERİ";
            // 
            // TxtServiceMoveId
            // 
            TxtServiceMoveId.Enabled = false;
            TxtServiceMoveId.Location = new Point(121, 49);
            TxtServiceMoveId.Name = "TxtServiceMoveId";
            TxtServiceMoveId.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            TxtServiceMoveId.Size = new Size(222, 20);
            TxtServiceMoveId.TabIndex = 41;
            // 
            // labelControl10
            // 
            labelControl10.Location = new Point(62, 52);
            labelControl10.Name = "labelControl10";
            labelControl10.Size = new Size(56, 13);
            labelControl10.TabIndex = 40;
            labelControl10.Text = "SERVİS ID :";
            // 
            // lookUpEdit3
            // 
            lookUpEdit3.Location = new Point(124, 99);
            lookUpEdit3.Name = "lookUpEdit3";
            lookUpEdit3.Properties.Appearance.Options.UseFont = true;
            lookUpEdit3.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            lookUpEdit3.Properties.DisplayMember = "ProductSerialNumber";
            lookUpEdit3.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            lookUpEdit3.Properties.ValueMember = "ProductId";
            lookUpEdit3.Size = new Size(219, 20);
            lookUpEdit3.TabIndex = 40;
            // 
            // TxtServiceMovementsId
            // 
            TxtServiceMovementsId.Enabled = false;
            TxtServiceMovementsId.Location = new Point(121, 75);
            TxtServiceMovementsId.Name = "TxtServiceMovementsId";
            TxtServiceMovementsId.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            TxtServiceMovementsId.Size = new Size(222, 20);
            TxtServiceMovementsId.TabIndex = 33;
            // 
            // labelControl6
            // 
            labelControl6.Location = new Point(16, 76);
            labelControl6.Name = "labelControl6";
            labelControl6.Size = new Size(104, 13);
            labelControl6.TabIndex = 32;
            labelControl6.Text = "SERVİS HAREKET ID :";
            // 
            // TxtServiceType
            // 
            TxtServiceType.BorderStyle = BorderStyle.FixedSingle;
            TxtServiceType.Location = new Point(121, 204);
            TxtServiceType.Multiline = true;
            TxtServiceType.Name = "TxtServiceType";
            TxtServiceType.Size = new Size(222, 20);
            TxtServiceType.TabIndex = 7;
            // 
            // TxtProductQuantity
            // 
            TxtProductQuantity.Location = new Point(121, 127);
            TxtProductQuantity.Name = "TxtProductQuantity";
            TxtProductQuantity.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            TxtProductQuantity.Size = new Size(222, 20);
            TxtProductQuantity.TabIndex = 29;
            // 
            // labelControl9
            // 
            labelControl9.Location = new Point(49, 128);
            labelControl9.Name = "labelControl9";
            labelControl9.Size = new Size(69, 13);
            labelControl9.TabIndex = 28;
            labelControl9.Text = "ÜRÜN ADEDİ :";
            // 
            // BtnMoveList
            // 
            BtnMoveList.ImageOptions.Image = (Image)resources.GetObject("BtnMoveList.ImageOptions.Image");
            BtnMoveList.Location = new Point(360, 192);
            BtnMoveList.Name = "BtnMoveList";
            BtnMoveList.Size = new Size(97, 35);
            BtnMoveList.TabIndex = 25;
            BtnMoveList.Text = "LİSTELE";
            BtnMoveList.Click += BtnMoveList_Click;
            // 
            // BtnMoveUpdate
            // 
            BtnMoveUpdate.ImageOptions.Image = (Image)resources.GetObject("BtnMoveUpdate.ImageOptions.Image");
            BtnMoveUpdate.Location = new Point(360, 148);
            BtnMoveUpdate.Name = "BtnMoveUpdate";
            BtnMoveUpdate.Size = new Size(97, 35);
            BtnMoveUpdate.TabIndex = 23;
            BtnMoveUpdate.Text = "GÜNCELLE";
            BtnMoveUpdate.Click += BtnMoveUpdate_Click;
            // 
            // BtnMoveDelete
            // 
            BtnMoveDelete.ImageOptions.Image = (Image)resources.GetObject("BtnMoveDelete.ImageOptions.Image");
            BtnMoveDelete.Location = new Point(360, 103);
            BtnMoveDelete.Name = "BtnMoveDelete";
            BtnMoveDelete.Size = new Size(97, 35);
            BtnMoveDelete.TabIndex = 22;
            BtnMoveDelete.Text = "SİL";
            BtnMoveDelete.Click += BtnMoveDelete_Click;
            // 
            // BtnMoveCreate
            // 
            BtnMoveCreate.ImageOptions.Image = (Image)resources.GetObject("BtnMoveCreate.ImageOptions.Image");
            BtnMoveCreate.Location = new Point(360, 62);
            BtnMoveCreate.Name = "BtnMoveCreate";
            BtnMoveCreate.Size = new Size(97, 35);
            BtnMoveCreate.TabIndex = 21;
            BtnMoveCreate.Text = "OLUŞTUR";
            BtnMoveCreate.Click += BtnMoveCreate_Click;
            // 
            // labelControl11
            // 
            labelControl11.Location = new Point(21, 206);
            labelControl11.Name = "labelControl11";
            labelControl11.Size = new Size(97, 13);
            labelControl11.TabIndex = 14;
            labelControl11.Text = "SERVİS İŞLEM TİPİ :";
            // 
            // TxtCurrency
            // 
            TxtCurrency.Location = new Point(121, 179);
            TxtCurrency.Name = "TxtCurrency";
            TxtCurrency.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            TxtCurrency.Size = new Size(222, 20);
            TxtCurrency.TabIndex = 13;
            // 
            // labelControl12
            // 
            labelControl12.Location = new Point(80, 180);
            labelControl12.Name = "labelControl12";
            labelControl12.Size = new Size(38, 13);
            labelControl12.TabIndex = 12;
            labelControl12.Text = "DÖVİZ :";
            // 
            // TxtServicePrice
            // 
            TxtServicePrice.Location = new Point(121, 153);
            TxtServicePrice.Name = "TxtServicePrice";
            TxtServicePrice.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            TxtServicePrice.Size = new Size(222, 20);
            TxtServicePrice.TabIndex = 11;
            // 
            // labelControl13
            // 
            labelControl13.Location = new Point(36, 154);
            labelControl13.Name = "labelControl13";
            labelControl13.Size = new Size(82, 13);
            labelControl13.TabIndex = 10;
            labelControl13.Text = "SERVİS ÜCRETİ :";
            // 
            // labelControl14
            // 
            labelControl14.Location = new Point(83, 102);
            labelControl14.Name = "labelControl14";
            labelControl14.Size = new Size(35, 13);
            labelControl14.TabIndex = 6;
            labelControl14.Text = "ÜRÜN :";
            // 
            // FrmServiceList
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1442, 849);
            Controls.Add(groupControl2);
            Controls.Add(gridServiceMovementsList);
            Controls.Add(gridServiceList);
            Controls.Add(groupControl1);
            Name = "FrmServiceList";
            Text = "FrmServiceList";
            Load += FrmServiceList_Load;
            ((System.ComponentModel.ISupportInitialize)gridServiceMovementsList).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridView2).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridServiceList).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)groupControl1).EndInit();
            groupControl1.ResumeLayout(false);
            groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)lookUpEdit2.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)lookUpEdit1.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)TxtServiceDate.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)TxtServiceNumber.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)TxtServiceCode.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)TxtServiceId.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)groupControl2).EndInit();
            groupControl2.ResumeLayout(false);
            groupControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)TxtServiceMoveId.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)lookUpEdit3.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)TxtServiceMovementsId.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)TxtProductQuantity.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)TxtCurrency.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)TxtServicePrice.Properties).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TextBox TxtServiceDescription;
        private DevExpress.XtraEditors.SimpleButton BtnCustomerService;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.SimpleButton btnList;
        private DevExpress.XtraEditors.SimpleButton BtnUpdate;
        private DevExpress.XtraEditors.SimpleButton BtnDelete;
        private DevExpress.XtraEditors.SimpleButton BtnSave;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraGrid.GridControl gridServiceMovementsList;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraEditors.TextEdit TxtPhoneNumber;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraGrid.GridControl gridServiceList;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private TextBox TxtServiceType;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraEditors.TextEdit TxtProductQuantity;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.SimpleButton BtnMoveList;
        private DevExpress.XtraEditors.SimpleButton BtnMoveUpdate;
        private DevExpress.XtraEditors.SimpleButton BtnMoveDelete;
        private DevExpress.XtraEditors.SimpleButton BtnMoveCreate;
        private DevExpress.XtraEditors.LabelControl labelControl11;
        private DevExpress.XtraEditors.TextEdit TxtCurrency;
        private DevExpress.XtraEditors.LabelControl labelControl12;
        private DevExpress.XtraEditors.TextEdit TxtServicePrice;
        private DevExpress.XtraEditors.LabelControl labelControl13;
        private DevExpress.XtraEditors.LabelControl labelControl14;
        private DevExpress.XtraEditors.TextEdit TxtServiceId;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit TxtServiceMovementsId;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.TextEdit TxtServiceDate;
        private DevExpress.XtraEditors.TextEdit TxtServiceNumber;
        private DevExpress.XtraEditors.TextEdit TxtServiceCode;
        private DevExpress.XtraEditors.LookUpEdit lookUpEdit1;
        private DevExpress.XtraEditors.LabelControl labelControl15;
        private DevExpress.XtraEditors.LookUpEdit lookUpEdit2;
        private DevExpress.XtraEditors.LookUpEdit lookUpEdit3;
        private DevExpress.XtraEditors.TextEdit TxtServiceMoveId;
        private DevExpress.XtraEditors.LabelControl labelControl10;
    }
}