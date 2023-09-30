using DevExpress.XtraPrinting.Native.WebClientUIControl;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ModPos.TechnicalService.FormsApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private async void BtnProductList_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var client = new HttpClient();
            client.BaseAddress = new Uri("https://localhost:44301/");
            HttpResponseMessage response = await client.GetAsync("api/Products/GetAllProducts");
            string result = await response.Content.ReadAsStringAsync();
            List<Product> products = JsonConvert.DeserializeObject<List<Product>>(result);

            gridControl1.DataSource = products;

        }
    }
}
