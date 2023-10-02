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
    public partial class FrmServiceList : Form
    {
        public FrmServiceList()
        {
            InitializeComponent();
        }

        private async void FrmServiceList_Load(object sender, EventArgs e)
        {
            var client = new HttpClient();
            var responseMessage = await client.GetAsync("https://localhost:44301/api/Services/GetAllServices?customerId=");
            if (responseMessage.IsSuccessStatusCode)
            {

                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<ResultServiceDto>>(jsonData);
                var services = from s in values
                               select new
                               {
                                   s.ServiceId,
                                   s.Customer.CustomerId,
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
                gridServiceList.DataSource = services;
                List<string> serviceStatusList = new List<string>
                    {
                        "Kabul Edildi",
                        "İşlem Yapılıyor",
                        "Tamamlandı"
                    };
                lookUpEdit1.Properties.NullText = serviceStatusList[0];
                lookUpEdit1.Properties.DataSource = serviceStatusList;

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
                    lookUpEdit2.Properties.NullText = "Müşteri Seçiniz";
                    lookUpEdit2.Properties.DataSource = customerValues;
                    lookUpEdit2.Properties.DisplayMember = "DisplayText";
                    lookUpEdit2.Properties.ValueMember = "CustomerId";
                }
                else
                {
                    MessageBox.Show("Müşteriler Çekilemedi");
                }

            }
            else
            {
                MessageBox.Show("Bir Sorun Oluştu");
            }
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            FrmServiceList_Load(sender, e);
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            lookUpEdit2.EditValue = gridView1.GetFocusedRowCellValue("CustomerId").ToString();
            TxtServiceId.Text = gridView1.GetFocusedRowCellValue("ServiceId").ToString();
            TxtServiceCode.Text = gridView1.GetFocusedRowCellValue("ServiceCode").ToString();
            TxtServiceNumber.Text = gridView1.GetFocusedRowCellValue("ServiceNumber").ToString();
            TxtServiceDescription.Text = gridView1.GetFocusedRowCellValue("ServiceDescription").ToString();
            TxtServiceDate.Text = gridView1.GetFocusedRowCellValue("ServiceDate").ToString();
            lookUpEdit1.Text = gridView1.GetFocusedRowCellValue("ServiceStatus").ToString();
        }

        private async void BtnSave_Click(object sender, EventArgs e)
        {
            int customerId = (int)lookUpEdit2.EditValue;
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

        }

        private async void BtnDelete_Click(object sender, EventArgs e)
        {
            int id = int.Parse(TxtServiceId.Text);
            var client = new HttpClient();
            var responseMessage = await client.DeleteAsync("https://localhost:44301/api/Services/DeleteService?id=" + id);
            if (responseMessage.IsSuccessStatusCode)
            {
                MessageBox.Show("Servis Başarıyla Silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else
            {
                MessageBox.Show("Bir Sorun Oluştu");
            }
        }

        private async void BtnUpdate_Click(object sender, EventArgs e)
        {
            int serviceId = int.Parse(TxtServiceId.Text);
            string customerId = lookUpEdit2.EditValue.ToString();            
            string serviceCode = TxtServiceCode.Text;
            string serviceNumber = TxtServiceNumber.Text;
            string serviceDescription = TxtServiceDescription.Text;
            string servisStatus = lookUpEdit1.Text;
            string servisDate = TxtServiceDate.Text;
            UpdateServiceDto updateServiceDto = new UpdateServiceDto
            {
                ServiceId = serviceId,
                CustomerId = int.Parse(customerId),
                ServiceCode = serviceCode,
                ServiceNumber = serviceNumber,
                ServiceDescription = serviceDescription,
                ServiceStatus = servisStatus,
                ServiceDate = DateTime.Parse(servisDate)
            };
            var client = new HttpClient();
            client.BaseAddress = new Uri("https://localhost:44301/");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
            HttpResponseMessage responseMessage = await client.PutAsJsonAsync("api/Services/UpdateService", updateServiceDto);
            if (responseMessage.IsSuccessStatusCode)
            {
                MessageBox.Show("Servis Başarıyla Güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show("Bir Sorun Oluştu");
            }

        }

        private async void BtnCustomerService_Click(object sender, EventArgs e)
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
                                            sm.Service.ServiceId,
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
            HttpResponseMessage response = await client.GetAsync("https://localhost:44301/api/Products/GetAllProducts");
            if (response.IsSuccessStatusCode)
            {
                var jsonData = await response.Content.ReadAsStringAsync();
                var products = JsonConvert.DeserializeObject<List<ResultProductDto>>(jsonData);
                var transformedProducts = from p in products
                                          select new
                                          {
                                              p.ProductSerialNumber,
                                              p.ProductId
                                          };
                lookUpEdit3.Properties.NullText = "Ürün Seçiniz";
                lookUpEdit3.Properties.DataSource = transformedProducts;
                lookUpEdit3.Properties.DisplayMember = "ProductSerialNumber";
                lookUpEdit3.Properties.ValueMember = "ProductId";
            }
            else
            {
                MessageBox.Show("Ürünleri Çekerken Bir Sorun Oluştu");
            }



        }

        private void gridView2_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            if (gridView2.RowCount > 0 && gridView2.FocusedRowHandle >= 0)
            {
                TxtServiceMovementsId.Text = gridView2.GetFocusedRowCellValue("ServiceMovementsId").ToString();
                TxtProductQuantity.Text = gridView2.GetFocusedRowCellValue("ProductQuantity").ToString();
                TxtServicePrice.Text = gridView2.GetFocusedRowCellValue("ServicePrice").ToString();
                TxtCurrency.Text = gridView2.GetFocusedRowCellValue("Currency").ToString();
                TxtServiceType.Text = gridView2.GetFocusedRowCellValue("ServiceTransactionType").ToString();
                TxtServiceMoveId.Text = gridView2.GetFocusedRowCellValue("ServiceId").ToString();
            }
            else
            {
                TxtServiceMovementsId.Text = "";
                TxtProductQuantity.Text = "";
                TxtServicePrice.Text = "";
                TxtCurrency.Text = "";
                TxtServiceType.Text = "";
                TxtServiceMoveId.Text = "";
            }
        }

        private async void BtnMoveCreate_Click(object sender, EventArgs e)
        {
            int serviceId = int.Parse(TxtServiceId.Text);
            int productId = (int)lookUpEdit3.EditValue;
            int productQuantity = int.Parse(TxtProductQuantity.Text);
            decimal servicePrice = decimal.Parse(TxtServicePrice.Text);
            decimal currency = decimal.Parse(TxtCurrency.Text);
            string serviceType = TxtServiceType.Text;

            CreateServiceMovementsDto createServiceMovementsDto = new CreateServiceMovementsDto
            {
                ServiceId = serviceId,
                ProductId = productId,
                ProductQuantity = productQuantity,
                ServicePrice = servicePrice,
                Currency = currency,
                ServiceTransactionType = serviceType
            };
            var client = new HttpClient();
            client.BaseAddress = new Uri("https://localhost:44301/");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
            HttpResponseMessage responseMessage = await client.PostAsJsonAsync("api/ServiceMovements/CreateServiceMovements", createServiceMovementsDto);
            if (responseMessage.IsSuccessStatusCode)
            {
                MessageBox.Show("Müşteri Başarıyla Kaydedildi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Bir Sorun Oluştu");
            }

        }

        private async void BtnMoveDelete_Click(object sender, EventArgs e)
        {
            int id = int.Parse(TxtServiceMoveId.Text);
            var client = new HttpClient();
            var responseMessage = await client.DeleteAsync("https://localhost:44301/api/ServiceMovements/DeleteServiceMovements?id=" + id);
            if (responseMessage.IsSuccessStatusCode)
            {
                MessageBox.Show("Kategori Başarıyla Silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else
            {
                MessageBox.Show("Bir Sorun Oluştu");
            }
        }

        private async void BtnMoveUpdate_Click(object sender, EventArgs e)
        {
            int id = int.Parse(TxtServiceMovementsId.Text);
            int serviceId = int.Parse(TxtServiceId.Text);
            int productId = (int)lookUpEdit3.EditValue;
            int productQuantity = int.Parse(TxtProductQuantity.Text);
            decimal servicePrice = decimal.Parse(TxtServicePrice.Text);
            decimal currency = decimal.Parse(TxtCurrency.Text);
            string serviceType = TxtServiceType.Text;
            UpdateServiceMovementsDto updateServiceMovementsDto = new UpdateServiceMovementsDto
            {
                ServiceMovementsId = id,
                ServiceId = serviceId,
                ProductId = productId,
                ProductQuantity = productQuantity,
                ServicePrice = servicePrice,
                Currency = currency,
                ServiceTransactionType = serviceType,
            };
            var client = new HttpClient();
            client.BaseAddress = new Uri("https://localhost:44301/");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
            HttpResponseMessage responseMessage = await client.PutAsJsonAsync("api/ServiceMovements/UpdateServiceMovements", updateServiceMovementsDto);
            if (responseMessage.IsSuccessStatusCode)
            {
                MessageBox.Show("Müşteri Başarıyla Güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show("Bir Sorun Oluştu");
            }

        }

        private void BtnMoveList_Click(object sender, EventArgs e)
        {
            BtnCustomerService_Click(sender,e);
        }
    }
}
