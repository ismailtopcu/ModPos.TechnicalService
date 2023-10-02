using ModPos.TechnicalService.DtoLayer.Dtos.CategoryDto;
using ModPos.TechnicalService.DtoLayer.Dtos.CustomerDto;
using ModPos.TechnicalService.DtoLayer.Dtos.ProductDto;
using ModPos.TechnicalService.DtoLayer.Dtos.ServiceDto;
using ModPos.TechnicalService.DtoLayer.Dtos.ServiceMovementsDto;
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
    public partial class FrmCustomerList : Form
    {
        public FrmCustomerList()
        {
            InitializeComponent();
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            FrmCustomerList_Load(sender, e);
        }

        private async void FrmCustomerList_Load(object sender, EventArgs e)
        {
            var client = new HttpClient();
            HttpResponseMessage responseMessage = await client.GetAsync("https://localhost:44301/api/Customers/GetAllCustomers");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<ResultCustomerDto>>(jsonData);
                var customers = from c in values
                                select new
                                {
                                    c.CustomerId,
                                    c.CustomerName,
                                    c.CustomerSurname,
                                    c.CustomerEmail,
                                    c.PhoneNumber,
                                    c.Address
                                };
                gridCustomerList.DataSource = customers;
            }
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
        }

        private void gridView1_FocusedRowObjectChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowObjectChangedEventArgs e)
        {
            TxtCustomerId.Text = gridView1.GetFocusedRowCellValue("CustomerId").ToString();
            TxtCustomerName.Text = gridView1.GetFocusedRowCellValue("CustomerName").ToString();
            TxtCustomerSurname.Text = gridView1.GetFocusedRowCellValue("CustomerSurname").ToString();
            TxtCustomerEmail.Text = gridView1.GetFocusedRowCellValue("CustomerEmail").ToString();
            TxtPhoneNumber.Text = gridView1.GetFocusedRowCellValue("PhoneNumber").ToString();
            TxtAddress.Text = gridView1.GetFocusedRowCellValue("Address").ToString();
        }

        private async void BtnDelete_Click(object sender, EventArgs e)
        {
            int id = int.Parse(TxtCustomerId.Text);
            var client = new HttpClient();
            var responseMessage = await client.DeleteAsync("https://localhost:44301/api/Customers/DeleteCustomer?id=" + id);
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
            int id = int.Parse(TxtCustomerId.Text);
            string customerName = TxtCustomerName.Text;
            string customerEmail = TxtCustomerEmail.Text;
            string customerSurname = TxtCustomerSurname.Text;
            string phoneNumber = TxtPhoneNumber.Text;
            string address = TxtAddress.Text;
            UpdateCustomerDto updateCustomerDto = new UpdateCustomerDto
            {
                CustomerId = id,
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
            HttpResponseMessage responseMessage = await client.PutAsJsonAsync("api/Customers/UpdateCustomer", updateCustomerDto);
            if (responseMessage.IsSuccessStatusCode)
            {
                MessageBox.Show("Müşteri Başarıyla Güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show("Bir Sorun Oluştu");
            }
        }

        private async void BtnCustomerService_Click(object sender, EventArgs e)
        {

            int customerId = int.Parse(TxtCustomerId.Text);
            var client = new HttpClient();
            var responseMessage = await client.GetAsync("https://localhost:44301/api/Services/GetAllServices?customerId=" + customerId);
            if (responseMessage.IsSuccessStatusCode)
            {

                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<ResultServiceDto>>(jsonData);
                var services = from s in values
                               select new
                               {
                                   s.ServiceId,
                                   s.Customer.CustomerName,
                                   s.Customer.CustomerSurname,
                                   s.ServiceCode,
                                   s.ServiceNumber,
                                   s.ServiceDate,
                                   s.UpdatedDate,
                                   s.ServiceDescription,
                                   s.ServiceStatus,
                                   s.ServiceTotalAmount
                               };
                if (services.Any())
                {
                    gridCustomerServiceList.DataSource = services.ToList();
                    TxtServiceId.Text = gridView2.GetFocusedRowCellValue("ServiceId").ToString();
                }
                else
                {
                    MessageBox.Show("Servis Yok!");
                }

            }
            else
            {
                MessageBox.Show("Bir Sorun Oluştu");
            }
        }

        private void gridView2_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            TxtServiceId.Text = gridView2.GetFocusedRowCellValue("ServiceId").ToString();


        }

        private async void BtnServiceMovements_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TxtServiceId.Text))
            {
                MessageBox.Show("Müşterinin Servis Kaydı Yok!");
                return;
            }

            int serviceId;
            if (!int.TryParse(TxtServiceId.Text, out serviceId))
            {
                MessageBox.Show("Geçersiz Service ID. Lütfen geçerli bir Service ID girin.");
                return;
            }

            var client = new HttpClient();
            var responseMessage = await client.GetAsync("https://localhost:44301/api/ServiceMovements/GetServiceMovementsByServiceId?id=" + serviceId);
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<ResultServiceMovementsDto>>(jsonData);
                var serviceMovements = values?.Select(sm =>
                                        new
                                        {
                                            sm.ServiceMovementsId,
                                            sm.Service.ServiceNumber,
                                            sm.Product.ProductName,
                                            sm.Product.ProductSerialNumber,
                                            sm.ProductQuantity,
                                            sm.ServicePrice,
                                            sm.Currency,
                                            sm.ServiceLineAmount,
                                            sm.ServiceTransactionType
                                        });
                gridServiceMovementsList.DataSource = serviceMovements;
            }
            else
            {
                MessageBox.Show("Bir Sorun Oluştu");
            }
        }

        private void BtnCreateService_Click(object sender, EventArgs e)
        {
            FrmServiceCreate serviceCreate = new FrmServiceCreate();
            int customerId = int.Parse(TxtCustomerId.Text);
            serviceCreate.CustomerId = customerId;
            serviceCreate.Show();
        }
    }
}
