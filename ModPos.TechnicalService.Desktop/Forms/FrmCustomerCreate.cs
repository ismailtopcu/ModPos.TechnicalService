using ModPos.TechnicalService.DtoLayer.Dtos.CustomerDto;
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
    public partial class FrmCustomerCreate : Form
    {
        public FrmCustomerCreate()
        {
            InitializeComponent();
        }

        private async void BtnSave_Click(object sender, EventArgs e)
        {
            string customerName = TxtCustomerName.Text;
            string customerEmail = TxtCustomerEmail.Text;
            string customerSurname = TxtCustomerSurname.Text;
            string phoneNumber = TxtPhoneNumber.Text;
            string address = TxtAddress.Text;
            CreateCustomerDto createCustomerDto = new CreateCustomerDto
            {
                CustomerName = customerName,
                CustomerEmail = customerEmail,
                CustomerSurname = customerSurname,
                PhoneNumber = phoneNumber,
                Address = address
            };
            var client = new HttpClient();
            client.BaseAddress = new Uri("https://localhost:44301/");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
            HttpResponseMessage responseMessage = await client.PostAsJsonAsync("api/Customers/CreateCustomer", createCustomerDto);
            if (responseMessage.IsSuccessStatusCode)
            {
                MessageBox.Show("Müşteri Başarıyla Kaydedildi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
