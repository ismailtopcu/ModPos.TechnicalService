using ModPos.TechnicalService.DtoLayer.Dtos.CategoryDto;
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
    public partial class FrmCategoryCreate : Form
    {
        public FrmCategoryCreate()
        {
            InitializeComponent();
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
            this.Close();
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
