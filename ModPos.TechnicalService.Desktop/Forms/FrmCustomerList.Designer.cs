namespace ModPos.TechnicalService.Desktop.Forms
{
    partial class FrmCustomerList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCustomerList));
            TxtCustomerId = new DevExpress.XtraEditors.TextEdit();
            labelControl8 = new DevExpress.XtraEditors.LabelControl();
            btnList = new DevExpress.XtraEditors.SimpleButton();
            BtnUpdate = new DevExpress.XtraEditors.SimpleButton();
            BtnDelete = new DevExpress.XtraEditors.SimpleButton();
            BtnSave = new DevExpress.XtraEditors.SimpleButton();
            labelControl5 = new DevExpress.XtraEditors.LabelControl();
            TxtCustomerEmail = new DevExpress.XtraEditors.TextEdit();
            labelControl6 = new DevExpress.XtraEditors.LabelControl();
            TxtPhoneNumber = new DevExpress.XtraEditors.TextEdit();
            labelControl3 = new DevExpress.XtraEditors.LabelControl();
            TxtCustomerName = new DevExpress.XtraEditors.TextEdit();
            labelControl1 = new DevExpress.XtraEditors.LabelControl();
            groupControl1 = new DevExpress.XtraEditors.GroupControl();
            BtnCreateService = new DevExpress.XtraEditors.SimpleButton();
            BtnServiceMovements = new DevExpress.XtraEditors.SimpleButton();
            TxtServiceId = new DevExpress.XtraEditors.TextEdit();
            labelControl4 = new DevExpress.XtraEditors.LabelControl();
            panel1 = new Panel();
            TxtAddress = new TextBox();
            BtnCustomerService = new DevExpress.XtraEditors.SimpleButton();
            TxtCustomerSurname = new DevExpress.XtraEditors.TextEdit();
            labelControl2 = new DevExpress.XtraEditors.LabelControl();
            gridCustomerList = new DevExpress.XtraGrid.GridControl();
            gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            gridCustomerServiceList = new DevExpress.XtraGrid.GridControl();
            gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            gridServiceMovementsList = new DevExpress.XtraGrid.GridControl();
            gridView3 = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)TxtCustomerId.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)TxtCustomerEmail.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)TxtPhoneNumber.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)TxtCustomerName.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)groupControl1).BeginInit();
            groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)TxtServiceId.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)TxtCustomerSurname.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridCustomerList).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridCustomerServiceList).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridView2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridServiceMovementsList).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridView3).BeginInit();
            SuspendLayout();
            // 
            // TxtCustomerId
            // 
            TxtCustomerId.Enabled = false;
            TxtCustomerId.Location = new Point(123, 59);
            TxtCustomerId.Name = "TxtCustomerId";
            TxtCustomerId.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            TxtCustomerId.Size = new Size(222, 20);
            TxtCustomerId.TabIndex = 27;
            // 
            // labelControl8
            // 
            labelControl8.Location = new Point(49, 62);
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
            BtnSave.Text = "EKLE";
            BtnSave.Click += BtnSave_Click;
            // 
            // labelControl5
            // 
            labelControl5.Location = new Point(74, 192);
            labelControl5.Name = "labelControl5";
            labelControl5.Size = new Size(40, 13);
            labelControl5.TabIndex = 14;
            labelControl5.Text = "ADRES :";
            // 
            // TxtCustomerEmail
            // 
            TxtCustomerEmail.Location = new Point(123, 163);
            TxtCustomerEmail.Name = "TxtCustomerEmail";
            TxtCustomerEmail.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            TxtCustomerEmail.Size = new Size(222, 20);
            TxtCustomerEmail.TabIndex = 13;
            // 
            // labelControl6
            // 
            labelControl6.Location = new Point(73, 166);
            labelControl6.Name = "labelControl6";
            labelControl6.Size = new Size(41, 13);
            labelControl6.TabIndex = 12;
            labelControl6.Text = "E-MAİL :";
            // 
            // TxtPhoneNumber
            // 
            TxtPhoneNumber.Location = new Point(123, 137);
            TxtPhoneNumber.Name = "TxtPhoneNumber";
            TxtPhoneNumber.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            TxtPhoneNumber.Size = new Size(222, 20);
            TxtPhoneNumber.TabIndex = 11;
            // 
            // labelControl3
            // 
            labelControl3.Location = new Point(7, 140);
            labelControl3.Name = "labelControl3";
            labelControl3.Size = new Size(107, 13);
            labelControl3.TabIndex = 10;
            labelControl3.Text = "TELEFON NUMARASI :";
            // 
            // TxtCustomerName
            // 
            TxtCustomerName.Location = new Point(123, 85);
            TxtCustomerName.Name = "TxtCustomerName";
            TxtCustomerName.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            TxtCustomerName.Size = new Size(222, 20);
            TxtCustomerName.TabIndex = 7;
            // 
            // labelControl1
            // 
            labelControl1.Location = new Point(42, 88);
            labelControl1.Name = "labelControl1";
            labelControl1.Size = new Size(72, 13);
            labelControl1.TabIndex = 6;
            labelControl1.Text = "MÜŞTERİ ADI :";
            // 
            // groupControl1
            // 
            groupControl1.Controls.Add(BtnCreateService);
            groupControl1.Controls.Add(BtnServiceMovements);
            groupControl1.Controls.Add(TxtServiceId);
            groupControl1.Controls.Add(labelControl4);
            groupControl1.Controls.Add(panel1);
            groupControl1.Controls.Add(TxtAddress);
            groupControl1.Controls.Add(BtnCustomerService);
            groupControl1.Controls.Add(TxtCustomerSurname);
            groupControl1.Controls.Add(labelControl2);
            groupControl1.Controls.Add(TxtCustomerId);
            groupControl1.Controls.Add(labelControl8);
            groupControl1.Controls.Add(btnList);
            groupControl1.Controls.Add(BtnUpdate);
            groupControl1.Controls.Add(BtnDelete);
            groupControl1.Controls.Add(BtnSave);
            groupControl1.Controls.Add(labelControl5);
            groupControl1.Controls.Add(TxtCustomerEmail);
            groupControl1.Controls.Add(labelControl6);
            groupControl1.Controls.Add(TxtPhoneNumber);
            groupControl1.Controls.Add(labelControl3);
            groupControl1.Controls.Add(TxtCustomerName);
            groupControl1.Controls.Add(labelControl1);
            groupControl1.Location = new Point(957, 12);
            groupControl1.Name = "groupControl1";
            groupControl1.Size = new Size(473, 825);
            groupControl1.TabIndex = 6;
            groupControl1.Text = "MÜŞTERİ İŞLEMLERİ";
            // 
            // BtnCreateService
            // 
            BtnCreateService.ImageOptions.Image = (Image)resources.GetObject("BtnCreateService.ImageOptions.Image");
            BtnCreateService.Location = new Point(260, 264);
            BtnCreateService.Name = "BtnCreateService";
            BtnCreateService.Size = new Size(197, 47);
            BtnCreateService.TabIndex = 35;
            BtnCreateService.Text = "SERVİS OLUŞTUR";
            BtnCreateService.Click += BtnCreateService_Click;
            // 
            // BtnServiceMovements
            // 
            BtnServiceMovements.ImageOptions.Image = (Image)resources.GetObject("BtnServiceMovements.ImageOptions.Image");
            BtnServiceMovements.Location = new Point(123, 389);
            BtnServiceMovements.Name = "BtnServiceMovements";
            BtnServiceMovements.Size = new Size(222, 47);
            BtnServiceMovements.TabIndex = 34;
            BtnServiceMovements.Text = "SERVİS HAREKETLERİNİ GETİR";
            BtnServiceMovements.Click += BtnServiceMovements_Click;
            // 
            // TxtServiceId
            // 
            TxtServiceId.Enabled = false;
            TxtServiceId.Location = new Point(123, 362);
            TxtServiceId.Name = "TxtServiceId";
            TxtServiceId.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            TxtServiceId.Size = new Size(222, 20);
            TxtServiceId.TabIndex = 33;
            // 
            // labelControl4
            // 
            labelControl4.Location = new Point(49, 365);
            labelControl4.Name = "labelControl4";
            labelControl4.Size = new Size(63, 13);
            labelControl4.TabIndex = 32;
            labelControl4.Text = "SERVİCE ID :";
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Location = new Point(22, 339);
            panel1.Name = "panel1";
            panel1.Size = new Size(430, 3);
            panel1.TabIndex = 31;
            // 
            // TxtAddress
            // 
            TxtAddress.BorderStyle = BorderStyle.FixedSingle;
            TxtAddress.Location = new Point(123, 188);
            TxtAddress.Multiline = true;
            TxtAddress.Name = "TxtAddress";
            TxtAddress.Size = new Size(222, 70);
            TxtAddress.TabIndex = 7;
            // 
            // BtnCustomerService
            // 
            BtnCustomerService.ImageOptions.Image = (Image)resources.GetObject("BtnCustomerService.ImageOptions.Image");
            BtnCustomerService.Location = new Point(49, 264);
            BtnCustomerService.Name = "BtnCustomerService";
            BtnCustomerService.Size = new Size(197, 47);
            BtnCustomerService.TabIndex = 30;
            BtnCustomerService.Text = "MÜŞTERİNİN SERVİSLERİ GETİR";
            BtnCustomerService.Click += BtnCustomerService_Click;
            // 
            // TxtCustomerSurname
            // 
            TxtCustomerSurname.Location = new Point(123, 111);
            TxtCustomerSurname.Name = "TxtCustomerSurname";
            TxtCustomerSurname.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            TxtCustomerSurname.Size = new Size(222, 20);
            TxtCustomerSurname.TabIndex = 29;
            // 
            // labelControl2
            // 
            labelControl2.Location = new Point(22, 114);
            labelControl2.Name = "labelControl2";
            labelControl2.Size = new Size(92, 13);
            labelControl2.TabIndex = 28;
            labelControl2.Text = "MÜŞTERİ SOYADI :";
            // 
            // gridCustomerList
            // 
            gridCustomerList.Location = new Point(12, 12);
            gridCustomerList.MainView = gridView1;
            gridCustomerList.Name = "gridCustomerList";
            gridCustomerList.Size = new Size(939, 445);
            gridCustomerList.TabIndex = 5;
            gridCustomerList.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] { gridView1 });
            // 
            // gridView1
            // 
            gridView1.GridControl = gridCustomerList;
            gridView1.Name = "gridView1";
            gridView1.FocusedRowObjectChanged += gridView1_FocusedRowObjectChanged;
            // 
            // gridCustomerServiceList
            // 
            gridCustomerServiceList.Location = new Point(12, 463);
            gridCustomerServiceList.MainView = gridView2;
            gridCustomerServiceList.Name = "gridCustomerServiceList";
            gridCustomerServiceList.Size = new Size(735, 374);
            gridCustomerServiceList.TabIndex = 7;
            gridCustomerServiceList.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] { gridView2 });
            // 
            // gridView2
            // 
            gridView2.GridControl = gridCustomerServiceList;
            gridView2.Name = "gridView2";
            gridView2.FocusedRowChanged += gridView2_FocusedRowChanged;
            // 
            // gridServiceMovementsList
            // 
            gridServiceMovementsList.Location = new Point(753, 463);
            gridServiceMovementsList.MainView = gridView3;
            gridServiceMovementsList.Name = "gridServiceMovementsList";
            gridServiceMovementsList.Size = new Size(672, 374);
            gridServiceMovementsList.TabIndex = 35;
            gridServiceMovementsList.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] { gridView3 });
            // 
            // gridView3
            // 
            gridView3.GridControl = gridServiceMovementsList;
            gridView3.Name = "gridView3";
            // 
            // FrmCustomerList
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1442, 849);
            Controls.Add(gridServiceMovementsList);
            Controls.Add(gridCustomerServiceList);
            Controls.Add(groupControl1);
            Controls.Add(gridCustomerList);
            Name = "FrmCustomerList";
            Text = "FrmCustomerList";
            Load += FrmCustomerList_Load;
            ((System.ComponentModel.ISupportInitialize)TxtCustomerId.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)TxtCustomerEmail.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)TxtPhoneNumber.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)TxtCustomerName.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)groupControl1).EndInit();
            groupControl1.ResumeLayout(false);
            groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)TxtServiceId.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)TxtCustomerSurname.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridCustomerList).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridCustomerServiceList).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridView2).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridServiceMovementsList).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridView3).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DevExpress.XtraEditors.TextEdit TxtCustomerId;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.SimpleButton btnList;
        private DevExpress.XtraEditors.SimpleButton BtnUpdate;
        private DevExpress.XtraEditors.SimpleButton BtnDelete;
        private DevExpress.XtraEditors.SimpleButton BtnSave;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.TextEdit TxtCustomerEmail;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.TextEdit TxtPhoneNumber;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit TxtCustomerName;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraGrid.GridControl gridCustomerList;
        private DevExpress.XtraEditors.SimpleButton BtnCustomerService;
        private DevExpress.XtraEditors.TextEdit TxtCustomerSurname;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit TxtAdress;
        private TextBox TxtAddress;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.GridControl gridCustomerServiceList;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private Panel panel1;
        private DevExpress.XtraEditors.SimpleButton BtnServiceMovements;
        private DevExpress.XtraEditors.TextEdit TxtServiceId;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraGrid.GridControl gridServiceMovementsList;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView3;
        private DevExpress.XtraEditors.SimpleButton BtnCreateService;
    }
}