using DevExpress.XtraEditors;
using ModPos.TechnicalService.DtoLayer.Dtos.CustomerDto;
using ModPos.TechnicalService.DtoLayer.Dtos.ServiceDto;
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
    public partial class FrmServiceCreate : Form
    {
        public FrmServiceCreate()
        {
            InitializeComponent();
        }
        public int CustomerId;
        private async void FrmServiceCreate_Load(object sender, EventArgs e)
        {

            var client = new HttpClient();
            HttpResponseMessage response = await client.GetAsync("https://localhost:44301/api/Customers/GetAllCustomers");
            if (response.IsSuccessStatusCode)
            {
                var jsonCustomersData = await response.Content.ReadAsStringAsync();
                var customers = JsonConvert.DeserializeObject<List<ResultCustomerDto>>(jsonCustomersData);
                var customerValues = from s in customers
                                     select new
                                     {
                                         s.CustomerId,
                                         s.DisplayText
                                     };

                if (CustomerId != 0)
                {
                    var existingCustomer = customers?.FirstOrDefault(c => c.CustomerId == CustomerId);
                    if (existingCustomer != null)
                    {
                        lookUpEdit1.Properties.NullText = "Müşteri Seçiniz";
                        lookUpEdit1.Properties.DataSource = customerValues;
                        lookUpEdit1.Properties.DisplayMember = "DisplayText";
                        lookUpEdit1.Properties.ValueMember = "CustomerId";
                        lookUpEdit1.EditValue = existingCustomer.CustomerId;
                        lookUpEdit1.Properties.ReadOnly = true;
                    }
                    else
                    {
                        MessageBox.Show("Geçerli müşteri bulunamadı.");
                    }
                }
                else
                {
                    lookUpEdit1.Properties.NullText = "Müşteri Seçiniz";
                    lookUpEdit1.Properties.DataSource = customerValues;
                    lookUpEdit1.Properties.DisplayMember = "DisplayText";
                    lookUpEdit1.Properties.ValueMember = "CustomerId";
                }
            }
            else
            {
                MessageBox.Show("Müşteriler Çekilemedi");
            }
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void BtnSave_Click(object sender, EventArgs e)
        {
            int customerId = (int)lookUpEdit1.EditValue;
            string serviceCode = TxtServiceCode.Text;
            string serviceNumber = TxtServiceNumber.Text;
            string serviceDescription = TxtServiceDescription.Text;

            CreateServiceDto createServiceDto = new CreateServiceDto
            {
                CustomerId = customerId,
                ServiceCode = serviceCode,
                ServiceNumber = serviceNumber,
                ServiceDescription = serviceDescription
            };
            var client = new HttpClient();
            client.BaseAddress = new Uri("https://localhost:44301/");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
            HttpResponseMessage responseMessage = await client.PostAsJsonAsync("api/Services/CreateService", createServiceDto);
            if (responseMessage.IsSuccessStatusCode)
            {
                MessageBox.Show("Servis Başarıyla Kaydedildi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Bir Sorun Oluştu");
            }
            this.Close();
        }
    }
}
