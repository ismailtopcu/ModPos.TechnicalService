using Microsoft.AspNetCore.Mvc;
using ModPos.TechnicalService.DtoLayer.Dtos.ServiceMovementsDto;
using Newtonsoft.Json;
using System.Text;

namespace ModPos.TechnicalService.PresentationLayer.Controllers
{
    public class ServiceMovementsController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public ServiceMovementsController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IActionResult> ServiceMovementsList(int id)
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("https://localhost:44301/api/ServiceMovements/GetServiceMovementsByServiceId?id="+id);
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<ResultServiceMovementsDto>>(jsonData);
                return View(values);
            }
            return View();
        }



        [HttpGet]
        public async Task<IActionResult> UpdateServiceMovements(int id)
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("https://localhost:44301/api/ServiceMovements/GetServiceMovementsById/" + id);
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<UpdateServiceMovementsDto>(jsonData);
                return View(values);
            }
            return RedirectToAction("ServiceList","Services");
        }
        [HttpPost]
        public async Task<IActionResult> UpdateServiceMovements(UpdateServiceMovementsDto updateServiceMovementsDto)
        {
            var client = _httpClientFactory.CreateClient();
            var jsonData = JsonConvert.SerializeObject(updateServiceMovementsDto);
            StringContent stringContent = new StringContent(jsonData, Encoding.UTF8, "application/json");
            var responseMessage = await client.PutAsync("https://localhost:44301/api/ServiceMovements/UpdateServiceMovements", stringContent);
            if (responseMessage.IsSuccessStatusCode)
            {
                return RedirectToAction("ServiceMovementsList", new { id = updateServiceMovementsDto.ServiceId });
            }
            return View();
        }

        public async Task<IActionResult> DeleteServiceMovements(int id)
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.DeleteAsync("https://localhost:44301/api/ServiceMovements/DeleteServiceMovements?id=" + id);
            if (responseMessage.IsSuccessStatusCode)
            {
                return RedirectToAction("ServiceList", "Services");
            }
            return View();
        }

        [HttpGet]
        public IActionResult CreateServiceMovements()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> CreateServiceMovements(CreateServiceMovementsDto createServiceMovementsDto)
        {
            var client = _httpClientFactory.CreateClient();
            var jsonData = JsonConvert.SerializeObject(createServiceMovementsDto);
            StringContent content = new StringContent(jsonData, Encoding.UTF8, "application/json");
            var respMessage = await client.PostAsync("https://localhost:44301/api/ServiceMovements/CreateServiceMovements", content);
            if (respMessage.IsSuccessStatusCode)
            {
                return RedirectToAction("ServiceMovementsList", new { id = createServiceMovementsDto.ServiceId });
            }
            return View();
        }
    }
}
