namespace ModPos.TechnicalService.Desktop;

partial class Form1
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
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
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        components = new System.ComponentModel.Container();
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
        ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
        BtnProductListForm = new DevExpress.XtraBars.BarButtonItem();
        barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
        barButtonItem3 = new DevExpress.XtraBars.BarButtonItem();
        barButtonItem4 = new DevExpress.XtraBars.BarButtonItem();
        barButtonItem5 = new DevExpress.XtraBars.BarButtonItem();
        barButtonItem6 = new DevExpress.XtraBars.BarButtonItem();
        barButtonItem7 = new DevExpress.XtraBars.BarButtonItem();
        barButtonItem8 = new DevExpress.XtraBars.BarButtonItem();
        HomePage = new DevExpress.XtraBars.Ribbon.RibbonPage();
        ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
        ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
        ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
        ribbonPageGroup4 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
        xtraTabbedMdiManager1 = new DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(components);
        ((System.ComponentModel.ISupportInitialize)ribbonControl1).BeginInit();
        ((System.ComponentModel.ISupportInitialize)xtraTabbedMdiManager1).BeginInit();
        SuspendLayout();
        // 
        // ribbonControl1
        // 
        ribbonControl1.ExpandCollapseItem.Id = 0;
        ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] { ribbonControl1.ExpandCollapseItem, BtnProductListForm, barButtonItem2, barButtonItem3, barButtonItem4, barButtonItem5, barButtonItem6, barButtonItem7, barButtonItem8 });
        ribbonControl1.Location = new Point(0, 0);
        ribbonControl1.MaxItemId = 9;
        ribbonControl1.Name = "ribbonControl1";
        ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] { HomePage });
        ribbonControl1.Size = new Size(1644, 150);
        // 
        // BtnProductListForm
        // 
        BtnProductListForm.Caption = "Ürün Listesi";
        BtnProductListForm.Id = 1;
        BtnProductListForm.ImageOptions.Image = (Image)resources.GetObject("BtnProductListForm.ImageOptions.Image");
        BtnProductListForm.ImageOptions.LargeImage = (Image)resources.GetObject("BtnProductListForm.ImageOptions.LargeImage");
        BtnProductListForm.Name = "BtnProductListForm";
        BtnProductListForm.ItemClick += BtnProductListForm_ItemClick;
        // 
        // barButtonItem2
        // 
        barButtonItem2.Caption = "Ürün Ekle";
        barButtonItem2.Id = 2;
        barButtonItem2.ImageOptions.Image = (Image)resources.GetObject("barButtonItem2.ImageOptions.Image");
        barButtonItem2.ImageOptions.LargeImage = (Image)resources.GetObject("barButtonItem2.ImageOptions.LargeImage");
        barButtonItem2.Name = "barButtonItem2";
        // 
        // barButtonItem3
        // 
        barButtonItem3.Caption = "Kategori Listesi";
        barButtonItem3.Id = 3;
        barButtonItem3.ImageOptions.Image = (Image)resources.GetObject("barButtonItem3.ImageOptions.Image");
        barButtonItem3.ImageOptions.LargeImage = (Image)resources.GetObject("barButtonItem3.ImageOptions.LargeImage");
        barButtonItem3.Name = "barButtonItem3";
        // 
        // barButtonItem4
        // 
        barButtonItem4.Caption = "Kategori Ekle";
        barButtonItem4.Id = 4;
        barButtonItem4.ImageOptions.Image = (Image)resources.GetObject("barButtonItem4.ImageOptions.Image");
        barButtonItem4.ImageOptions.LargeImage = (Image)resources.GetObject("barButtonItem4.ImageOptions.LargeImage");
        barButtonItem4.Name = "barButtonItem4";
        // 
        // barButtonItem5
        // 
        barButtonItem5.Caption = "Müşteri Listesi";
        barButtonItem5.Id = 5;
        barButtonItem5.ImageOptions.Image = (Image)resources.GetObject("barButtonItem5.ImageOptions.Image");
        barButtonItem5.ImageOptions.LargeImage = (Image)resources.GetObject("barButtonItem5.ImageOptions.LargeImage");
        barButtonItem5.Name = "barButtonItem5";
        // 
        // barButtonItem6
        // 
        barButtonItem6.Caption = "Müşteri Ekle";
        barButtonItem6.Id = 6;
        barButtonItem6.ImageOptions.Image = (Image)resources.GetObject("barButtonItem6.ImageOptions.Image");
        barButtonItem6.ImageOptions.LargeImage = (Image)resources.GetObject("barButtonItem6.ImageOptions.LargeImage");
        barButtonItem6.Name = "barButtonItem6";
        // 
        // barButtonItem7
        // 
        barButtonItem7.Caption = "Servis Listesini Getir";
        barButtonItem7.Id = 7;
        barButtonItem7.ImageOptions.Image = (Image)resources.GetObject("barButtonItem7.ImageOptions.Image");
        barButtonItem7.ImageOptions.LargeImage = (Image)resources.GetObject("barButtonItem7.ImageOptions.LargeImage");
        barButtonItem7.Name = "barButtonItem7";
        // 
        // barButtonItem8
        // 
        barButtonItem8.Caption = "Servis Oluştur";
        barButtonItem8.Id = 8;
        barButtonItem8.ImageOptions.Image = (Image)resources.GetObject("barButtonItem8.ImageOptions.Image");
        barButtonItem8.ImageOptions.LargeImage = (Image)resources.GetObject("barButtonItem8.ImageOptions.LargeImage");
        barButtonItem8.Name = "barButtonItem8";
        // 
        // HomePage
        // 
        HomePage.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] { ribbonPageGroup1, ribbonPageGroup2, ribbonPageGroup3, ribbonPageGroup4 });
        HomePage.Name = "HomePage";
        HomePage.Text = "Ana Sayfa";
        // 
        // ribbonPageGroup1
        // 
        ribbonPageGroup1.ItemLinks.Add(BtnProductListForm);
        ribbonPageGroup1.ItemLinks.Add(barButtonItem2);
        ribbonPageGroup1.Name = "ribbonPageGroup1";
        ribbonPageGroup1.Text = "Ürün";
        // 
        // ribbonPageGroup2
        // 
        ribbonPageGroup2.ItemLinks.Add(barButtonItem3);
        ribbonPageGroup2.ItemLinks.Add(barButtonItem4);
        ribbonPageGroup2.Name = "ribbonPageGroup2";
        ribbonPageGroup2.Text = "Kategori";
        // 
        // ribbonPageGroup3
        // 
        ribbonPageGroup3.ItemLinks.Add(barButtonItem5);
        ribbonPageGroup3.ItemLinks.Add(barButtonItem6);
        ribbonPageGroup3.Name = "ribbonPageGroup3";
        ribbonPageGroup3.Text = "Müşteri";
        // 
        // ribbonPageGroup4
        // 
        ribbonPageGroup4.ItemLinks.Add(barButtonItem7);
        ribbonPageGroup4.ItemLinks.Add(barButtonItem8);
        ribbonPageGroup4.Name = "ribbonPageGroup4";
        ribbonPageGroup4.Text = "Servis";
        // 
        // xtraTabbedMdiManager1
        // 
        xtraTabbedMdiManager1.MdiParent = this;
        // 
        // Form1
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(1644, 849);
        Controls.Add(ribbonControl1);
        IsMdiContainer = true;
        Name = "Form1";
        Text = "Form1";
        WindowState = FormWindowState.Maximized;
        ((System.ComponentModel.ISupportInitialize)ribbonControl1).EndInit();
        ((System.ComponentModel.ISupportInitialize)xtraTabbedMdiManager1).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
    private DevExpress.XtraBars.BarButtonItem BtnProductListForm;
    private DevExpress.XtraBars.BarButtonItem barButtonItem2;
    private DevExpress.XtraBars.BarButtonItem barButtonItem3;
    private DevExpress.XtraBars.BarButtonItem barButtonItem4;
    private DevExpress.XtraBars.BarButtonItem barButtonItem5;
    private DevExpress.XtraBars.BarButtonItem barButtonItem6;
    private DevExpress.XtraBars.BarButtonItem barButtonItem7;
    private DevExpress.XtraBars.BarButtonItem barButtonItem8;
    private DevExpress.XtraBars.Ribbon.RibbonPage HomePage;
    private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
    private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
    private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
    private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup4;
    private DevExpress.XtraTabbedMdi.XtraTabbedMdiManager xtraTabbedMdiManager1;
}
