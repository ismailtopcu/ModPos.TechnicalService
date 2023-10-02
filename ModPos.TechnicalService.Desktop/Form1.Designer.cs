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
        BtnNewProduct = new DevExpress.XtraBars.BarButtonItem();
        BtnCategoryList = new DevExpress.XtraBars.BarButtonItem();
        BtnCreateCategory = new DevExpress.XtraBars.BarButtonItem();
        BtnCustomerList = new DevExpress.XtraBars.BarButtonItem();
        BtnCustomerCreate = new DevExpress.XtraBars.BarButtonItem();
        BtnServiceList = new DevExpress.XtraBars.BarButtonItem();
        BtnServiceCreate = new DevExpress.XtraBars.BarButtonItem();
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
        ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] { ribbonControl1.ExpandCollapseItem, BtnProductListForm, BtnNewProduct, BtnCategoryList, BtnCreateCategory, BtnCustomerList, BtnCustomerCreate, BtnServiceList, BtnServiceCreate });
        ribbonControl1.Location = new Point(0, 0);
        ribbonControl1.MaxItemId = 9;
        ribbonControl1.Name = "ribbonControl1";
        ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] { HomePage });
        ribbonControl1.Size = new Size(1444, 150);
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
        // BtnNewProduct
        // 
        BtnNewProduct.Caption = "Ürün Ekle";
        BtnNewProduct.Id = 2;
        BtnNewProduct.ImageOptions.Image = (Image)resources.GetObject("BtnNewProduct.ImageOptions.Image");
        BtnNewProduct.ImageOptions.LargeImage = (Image)resources.GetObject("BtnNewProduct.ImageOptions.LargeImage");
        BtnNewProduct.Name = "BtnNewProduct";
        BtnNewProduct.ItemClick += BtnNewProduct_ItemClick;
        // 
        // BtnCategoryList
        // 
        BtnCategoryList.Caption = "Kategori Listesi";
        BtnCategoryList.Id = 3;
        BtnCategoryList.ImageOptions.Image = (Image)resources.GetObject("BtnCategoryList.ImageOptions.Image");
        BtnCategoryList.ImageOptions.LargeImage = (Image)resources.GetObject("BtnCategoryList.ImageOptions.LargeImage");
        BtnCategoryList.Name = "BtnCategoryList";
        BtnCategoryList.ItemClick += BtnCategoryList_ItemClick;
        // 
        // BtnCreateCategory
        // 
        BtnCreateCategory.Caption = "Kategori Ekle";
        BtnCreateCategory.Id = 4;
        BtnCreateCategory.ImageOptions.Image = (Image)resources.GetObject("BtnCreateCategory.ImageOptions.Image");
        BtnCreateCategory.ImageOptions.LargeImage = (Image)resources.GetObject("BtnCreateCategory.ImageOptions.LargeImage");
        BtnCreateCategory.Name = "BtnCreateCategory";
        BtnCreateCategory.ItemClick += BtnCreateCategory_ItemClick;
        // 
        // BtnCustomerList
        // 
        BtnCustomerList.Caption = "Müşteri Listesi";
        BtnCustomerList.Id = 5;
        BtnCustomerList.ImageOptions.Image = (Image)resources.GetObject("BtnCustomerList.ImageOptions.Image");
        BtnCustomerList.ImageOptions.LargeImage = (Image)resources.GetObject("BtnCustomerList.ImageOptions.LargeImage");
        BtnCustomerList.Name = "BtnCustomerList";
        BtnCustomerList.ItemClick += BtnCustomerList_ItemClick;
        // 
        // BtnCustomerCreate
        // 
        BtnCustomerCreate.Caption = "Müşteri Ekle";
        BtnCustomerCreate.Id = 6;
        BtnCustomerCreate.ImageOptions.Image = (Image)resources.GetObject("BtnCustomerCreate.ImageOptions.Image");
        BtnCustomerCreate.ImageOptions.LargeImage = (Image)resources.GetObject("BtnCustomerCreate.ImageOptions.LargeImage");
        BtnCustomerCreate.Name = "BtnCustomerCreate";
        BtnCustomerCreate.ItemClick += BtnCustomerCreate_ItemClick;
        // 
        // BtnServiceList
        // 
        BtnServiceList.Caption = "Servis Listesini Getir";
        BtnServiceList.Id = 7;
        BtnServiceList.ImageOptions.Image = (Image)resources.GetObject("BtnServiceList.ImageOptions.Image");
        BtnServiceList.ImageOptions.LargeImage = (Image)resources.GetObject("BtnServiceList.ImageOptions.LargeImage");
        BtnServiceList.Name = "BtnServiceList";
        BtnServiceList.ItemClick += BtnServiceList_ItemClick;
        // 
        // BtnServiceCreate
        // 
        BtnServiceCreate.Caption = "Servis Oluştur";
        BtnServiceCreate.Id = 8;
        BtnServiceCreate.ImageOptions.Image = (Image)resources.GetObject("BtnServiceCreate.ImageOptions.Image");
        BtnServiceCreate.ImageOptions.LargeImage = (Image)resources.GetObject("BtnServiceCreate.ImageOptions.LargeImage");
        BtnServiceCreate.Name = "BtnServiceCreate";
        BtnServiceCreate.ItemClick += BtnServiceCreate_ItemClick;
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
        ribbonPageGroup1.ItemLinks.Add(BtnNewProduct);
        ribbonPageGroup1.Name = "ribbonPageGroup1";
        ribbonPageGroup1.Text = "Ürün";
        // 
        // ribbonPageGroup2
        // 
        ribbonPageGroup2.ItemLinks.Add(BtnCategoryList);
        ribbonPageGroup2.ItemLinks.Add(BtnCreateCategory);
        ribbonPageGroup2.Name = "ribbonPageGroup2";
        ribbonPageGroup2.Text = "Kategori";
        // 
        // ribbonPageGroup3
        // 
        ribbonPageGroup3.ItemLinks.Add(BtnCustomerList);
        ribbonPageGroup3.ItemLinks.Add(BtnCustomerCreate);
        ribbonPageGroup3.Name = "ribbonPageGroup3";
        ribbonPageGroup3.Text = "Müşteri";
        // 
        // ribbonPageGroup4
        // 
        ribbonPageGroup4.ItemLinks.Add(BtnServiceList);
        ribbonPageGroup4.ItemLinks.Add(BtnServiceCreate);
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
        ClientSize = new Size(1444, 1021);
        Controls.Add(ribbonControl1);
        IsMdiContainer = true;
        Name = "Form1";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Form1";
        ((System.ComponentModel.ISupportInitialize)ribbonControl1).EndInit();
        ((System.ComponentModel.ISupportInitialize)xtraTabbedMdiManager1).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
    private DevExpress.XtraBars.BarButtonItem BtnProductListForm;
    private DevExpress.XtraBars.BarButtonItem BtnNewProduct;
    private DevExpress.XtraBars.BarButtonItem BtnCategoryList;
    private DevExpress.XtraBars.BarButtonItem BtnCreateCategory;
    private DevExpress.XtraBars.BarButtonItem BtnCustomerList;
    private DevExpress.XtraBars.BarButtonItem BtnCustomerCreate;
    private DevExpress.XtraBars.BarButtonItem BtnServiceList;
    private DevExpress.XtraBars.BarButtonItem BtnServiceCreate;
    private DevExpress.XtraBars.Ribbon.RibbonPage HomePage;
    private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
    private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
    private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
    private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup4;
    private DevExpress.XtraTabbedMdi.XtraTabbedMdiManager xtraTabbedMdiManager1;
}
