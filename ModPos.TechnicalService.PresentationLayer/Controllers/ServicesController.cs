using Microsoft.AspNetCore.Mvc;
using ModPos.TechnicalService.DtoLayer.Dtos.CustomerDto;
using ModPos.TechnicalService.DtoLayer.Dtos.ServiceDto;
using Newtonsoft.Json;
using System.Text;

namespace ModPos.TechnicalService.PresentationLayer.Controllers
{
    public class ServicesController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public ServicesController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IActionResult> ServiceList(int? customerId)
        {
            ViewBag.CustomerId = customerId;
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("https://localhost:44301/api/Services/GetAllServices?customerId=" + customerId);
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<ResultServiceDto>>(jsonData);
                return View(values);
            }
            return View();
        }

        [HttpGet]
        public async Task<IActionResult> UpdateService(int id)
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("https://localhost:44301/api/Services/GetServiceById/" + id);
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<UpdateServiceDto>(jsonData);
                return View(values);
            }
            return RedirectToAction("ServiceList");
        }
        [HttpPost]
        public async Task<IActionResult> UpdateService(UpdateServiceDto updateServiceDto)
        {
            var client = _httpClientFactory.CreateClient();
            var jsonData = JsonConvert.SerializeObject(updateServiceDto);
            StringContent stringContent = new StringContent(jsonData, Encoding.UTF8, "application/json");
            var responseMessage = await client.PutAsync("https://localhost:44301/api/Services/UpdateService", stringContent);
            if (responseMessage.IsSuccessStatusCode)
            {
                return RedirectToAction("ServiceList");
            }
            return View();
        }

        public async Task<IActionResult> DeleteService(int id)
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.DeleteAsync("https://localhost:44301/api/Services/DeleteService?id=" + id);
            if (responseMessage.IsSuccessStatusCode)
            {
                return RedirectToAction("ServiceList");
            }
            return View();
        }

        [HttpGet]
        public async Task<IActionResult> CreateService(int? customerId)
		{
			ViewBag.CustomerId = customerId;
			var client = _httpClientFactory.CreateClient();
			var responseMessage = await client.GetAsync("https://localhost:44301/api/Customers/GetAllCustomers");
			if (responseMessage.IsSuccessStatusCode)
			{
				var jsonData = await responseMessage.Content.ReadAsStringAsync();
				var values = JsonConvert.DeserializeObject<List<ResultCustomerDto>>(jsonData);
				return View(values);
			}
			return View();
        }

        [HttpPost]
        public async Task<IActionResult> CreateService(CreateServiceDto createServiceDto)
        {
            var client = _httpClientFactory.CreateClient();
            var jsonData = JsonConvert.SerializeObject(createServiceDto);
            StringContent content = new StringContent(jsonData, Encoding.UTF8, "application/json");
            var respMessage = await client.PostAsync("https://localhost:44301/api/Services/CreateService", content);
            if (respMessage.IsSuccessStatusCode)
            {
                return RedirectToAction("ServiceList");
            }
            return View();
        }
    }
}
