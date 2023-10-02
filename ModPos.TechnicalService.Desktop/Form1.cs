using ModPos.TechnicalService.DtoLayer.Dtos.ProductDto;
using Newtonsoft.Json;
using System.Net.Http;
using System.Text.Json.Serialization;

namespace ModPos.TechnicalService.Desktop;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
    }

    private void BtnProductListForm_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
    {
        Forms.FrmProductList fr = new Forms.FrmProductList();
        fr.MdiParent = this;
        fr.Show();

    }

    private void BtnNewProduct_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
    {
        Forms.FrmProductCreate fr = new Forms.FrmProductCreate();
        fr.Show();
    }

    private void BtnCategoryList_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
    {
        Forms.FrmCategoryList fr = new Forms.FrmCategoryList();
        fr.MdiParent = this;
        fr.Show();
    }

    private void BtnCreateCategory_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
    {
        Forms.FrmCategoryCreate fr = new Forms.FrmCategoryCreate();
        fr.Show();
    }

    private void BtnCustomerList_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
    {
        Forms.FrmCustomerList fr = new Forms.FrmCustomerList();
        fr.MdiParent = this;
        fr.Show();
    }

    private void BtnCustomerCreate_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
    {
        Forms.FrmCustomerCreate fr = new Forms.FrmCustomerCreate();
        fr.Show();
    }

    private void BtnServiceList_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
    {
        Forms.FrmServiceList fr = new Forms.FrmServiceList();
        fr.MdiParent = this;
        fr.Show();
    }

    private void BtnServiceCreate_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
    {
        Forms.FrmServiceCreate fr = new Forms.FrmServiceCreate();
        fr.Show();
    }
}
