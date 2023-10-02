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
    public partial class FrmCategoryList : Form
    {
        public FrmCategoryList()
        {
            InitializeComponent();
        }

        private async void FrmCategoryList_Load(object sender, EventArgs e)
        {
            var client = new HttpClient();
            HttpResponseMessage responseMessage = await client.GetAsync("https://localhost:44301/api/Categories/GetAllCategories");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var categories = JsonConvert.DeserializeObject<List<ResultCategoryDto>>(jsonData);
                gridCategoryList.DataSource = categories;
            }
            else
            {
                MessageBox.Show("Kategorileri çekerken bir sorun oluştu.");
            }
        }

        private async void BtnSave_Click(object sender, EventArgs e)
        {
            string categoryName = TxtCategoryName.Text;
            CreateCategoryDto createCategoryDto = new CreateCategoryDto { CategoryName = categoryName };
            var client = new HttpClient();
            client.BaseAddress = new Uri("https://localhost:44301/");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
            HttpResponseMessage responseMessage = await client.PostAsJsonAsync("api/Categories/CreateCategory", createCategoryDto);
            if (responseMessage.IsSuccessStatusCode)
            {
                MessageBox.Show("Kategori Başarıyla Kaydedildi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Bir Sorun Oluştu");
            }
        }

        private  void btnList_Click(object sender, EventArgs e)
        {
            FrmCategoryList_Load(sender,e);
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            TxtCategoryId.Text = gridView1.GetFocusedRowCellValue("CategoryId").ToString();
            TxtCategoryName.Text = gridView1.GetFocusedRowCellValue("CategoryName").ToString();
        }

        private async void BtnDelete_Click(object sender, EventArgs e)
        {
            int id = int.Parse(TxtCategoryId.Text);
            var client = new HttpClient();
            var responseMessage = await client.DeleteAsync("https://localhost:44301/api/Categories/DeleteCategory?id=" + id);
            if (responseMessage.IsSuccessStatusCode)
            {
                MessageBox.Show("Kategori Başarıyla Silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else
            {
                MessageBox.Show("Bir Sorun Oluştu");
            }
        }

        private async void BtnUpdate_Click(object sender, EventArgs e)
        {
            int id = int.Parse(TxtCategoryId.Text);
            string categoryName = TxtCategoryName.Text;
            UpdateCategoryDto updateCategoryDto = new UpdateCategoryDto { CategoryId = id, CategoryName = categoryName };
            var client = new HttpClient();
            client.BaseAddress = new Uri("https://localhost:44301/");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
            HttpResponseMessage responseMessage = await client.PutAsJsonAsync("api/Categories/UpdateCategory", updateCategoryDto);
            if (responseMessage.IsSuccessStatusCode)
            {
                MessageBox.Show("Kategori Başarıyla Güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show("Bir Sorun Oluştu");
            }
        }
    }
}
