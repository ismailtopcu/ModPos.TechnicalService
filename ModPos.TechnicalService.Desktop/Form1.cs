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
}
