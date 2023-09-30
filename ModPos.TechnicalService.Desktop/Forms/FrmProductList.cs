using DevExpress.ReportServer.ServiceModel.DataContracts;
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
    public partial class FrmProductList : Form
    {

        public FrmProductList()
        {
            InitializeComponent();
        }

        private async void FrmProductList_Load(object sender, EventArgs e)
        {
            var client = new HttpClient();
            HttpResponseMessage responseMessage = await client.GetAsync("https://localhost:44301/api/Products/GetAllProducts");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<ResultProductDto>>(jsonData);
                gridProductList.DataSource = values;
            }
            else
            {
                MessageBox.Show("Ürünleri Çekerken Bir Sorun Oluştu");
            }
            HttpResponseMessage categoriesResponse = await client.GetAsync("https://localhost:44301/api/Categories/GetAllCategories");

            if (categoriesResponse.IsSuccessStatusCode)
            {
                var categoriesJsonData = await categoriesResponse.Content.ReadAsStringAsync();
                var categories = JsonConvert.DeserializeObject<List<ResultCategoryDto>>(categoriesJsonData);
                lookUpEdit1.Properties.DataSource = categories;
            }
            else
            {
                MessageBox.Show("Kategorileri çekerken bir sorun oluştu.");
            }
        }

        private async void BtnSave_Click(object sender, EventArgs e)
        {
            string productCode = TxtProductCode.Text;
            string productName = TxtProductName.Text;
            string productSerialNumber = TxtProductSerialNumber.Text;
            string productBarcode = TxtProductBarcode.Text;
            string productCategoryId = lookUpEdit1.EditValue.ToString();
            decimal purchasePrice = Convert.ToDecimal(TxtPurchasePrice.Text);
            decimal sellingPrice = Convert.ToDecimal(TxtSellingPrice.Text);

            CreateProductDto createProductDto = new CreateProductDto
            {
                ProductBarcode = productBarcode,
                ProductName = productName,
                ProductSerialNumber = productSerialNumber,
                ProductCode = productCode,
                PurchasePrice = purchasePrice,
                SellingPrice = sellingPrice,
                CategoryId = Convert.ToInt32(productCategoryId)
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
        }

        private async void btnList_Click(object sender, EventArgs e)
        {
            var client = new HttpClient();
            HttpResponseMessage responseMessage = await client.GetAsync("https://localhost:44301/api/Products/GetAllProducts");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<ResultProductDto>>(jsonData);
                gridProductList.DataSource = values;
            }
            else
            {
                MessageBox.Show("Bir Sorun Oluştu");
            }
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            TxtProductId.Text = gridView1.GetFocusedRowCellValue("ProductId").ToString();
            TxtProductCode.Text = gridView1.GetFocusedRowCellValue("ProductCode").ToString();
            TxtProductName.Text = gridView1.GetFocusedRowCellValue("ProductName").ToString();
            lookUpEdit1.Text = gridView1.GetFocusedRowCellValue("Category").ToString();
            TxtProductSerialNumber.Text = gridView1.GetFocusedRowCellValue("ProductSerialNumber").ToString();
            TxtProductBarcode.Text = gridView1.GetFocusedRowCellValue("ProductBarcode").ToString();
            TxtPurchasePrice.Text = gridView1.GetFocusedRowCellValue("PurchasePrice").ToString();
            TxtSellingPrice.Text = gridView1.GetFocusedRowCellValue("SellingPrice").ToString();

        }

        private async void BtnDelete_Click(object sender, EventArgs e)
        {
            int id = int.Parse(TxtProductId.Text);
            var client = new HttpClient();
            var responseMessage = await client.DeleteAsync("https://localhost:44301/api/Products/DeleteProduct?id=" + id);
            if (responseMessage.IsSuccessStatusCode)
            {
                MessageBox.Show("Ürün Başarıyla Silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else
            {
                MessageBox.Show("Bir Sorun Oluştu");
            }
        }

        private async void BtnUpdate_Click(object sender, EventArgs e)
        {
            int id = int.Parse(TxtProductId.Text);
            string productCode = TxtProductCode.Text;
            string productName = TxtProductName.Text;
            string productSerialNumber = TxtProductSerialNumber.Text;
            string productBarcode = TxtProductBarcode.Text;
            string productCategoryId = lookUpEdit1.EditValue.ToString();
            decimal purchasePrice = Convert.ToDecimal(TxtPurchasePrice.Text);
            decimal sellingPrice = Convert.ToDecimal(TxtSellingPrice.Text);

            UpdateProductDto updateProductDto = new UpdateProductDto
            {
                ProductId = id,
                ProductCode = productCode,
                ProductName = productName,
                ProductSerialNumber = productSerialNumber,
                ProductBarcode = productBarcode,
                PurchasePrice = purchasePrice,
                SellingPrice = sellingPrice,
                CategoryId = Convert.ToInt32(productCategoryId)
            };

            var client = new HttpClient();
            client.BaseAddress = new Uri("https://localhost:44301/");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));

            HttpResponseMessage responseMessage = await client.PutAsJsonAsync($"api/Products/UpdateProduct", updateProductDto);
            if (responseMessage.IsSuccessStatusCode)
            {
                MessageBox.Show("Ürün Başarıyla Güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show("Bir Sorun Oluştu");
            }
        }

    }
}
