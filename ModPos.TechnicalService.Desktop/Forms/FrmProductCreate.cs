using DevExpress.XtraEditors;
using ModPos.TechnicalService.DtoLayer.Dtos.CategoryDto;
using ModPos.TechnicalService.DtoLayer.Dtos.ProductDto;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ModPos.TechnicalService.Desktop.Forms
{
    public partial class FrmProductCreate : Form
    {
        public FrmProductCreate()
        {
            InitializeComponent();
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void BtnSave_Click(object sender, EventArgs e)
        {
            string productCode = TxtProductCode.Text;
            string productName = TxtProductName.Text;
            string productSerialNumber = TxtProductSerialNumber.Text;
            string productBarcode = TxtProductBarcode.Text;
            int productCategoryId = (int)lookUpEdit1.EditValue;
            decimal purchasePrice = decimal.Parse(TxtPurchasePrice.Text);
            decimal sellingPrice = decimal.Parse(TxtSellingPrice.Text);

            CreateProductDto createProductDto = new CreateProductDto
            {
                ProductBarcode = productBarcode,
                ProductName = productName,
                ProductSerialNumber = productSerialNumber,
                ProductCode = productCode,
                PurchasePrice = purchasePrice,
                SellingPrice = sellingPrice,
                CategoryId = productCategoryId
            };

            var client = new HttpClient();
            client.BaseAddress = new Uri("https://localhost:44301/");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));

            HttpResponseMessage responseMessage = await client.PostAsJsonAsync("api/Products/CreateProduct", createProductDto);
            if (responseMessage.IsSuccessStatusCode)
            {
                MessageBox.Show("Ürün Başarıyla Kaydedildi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Bir Sorun Oluştu");
            }

            this.Close();
        }

        private async void FrmProductCreate_Load(object sender, EventArgs e)
        {
            var client = new HttpClient();
            HttpResponseMessage categoriesResponse = await client.GetAsync("https://localhost:44301/api/Categories/GetAllCategories");

            if (categoriesResponse.IsSuccessStatusCode)
            {
                var categoriesJsonData = await categoriesResponse.Content.ReadAsStringAsync();
                var categories = JsonConvert.DeserializeObject<List<ResultCategoryDto>>(categoriesJsonData);
                lookUpEdit1.Properties.NullText = "Kategori Seçiniz";
                lookUpEdit1.Properties.DisplayMember = "CategoryName";
                lookUpEdit1.Properties.ValueMember = "CategoryId";
                lookUpEdit1.Properties.DataSource = categories;

            }
            else
            {
                MessageBox.Show("Kategorileri çekerken bir sorun oluştu.");
            }
        }
    }
}
