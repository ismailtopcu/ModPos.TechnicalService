using Microsoft.AspNetCore.Mvc;
using ModPos.TechnicalService.DtoLayer.Dtos.CategoryDto;
using Newtonsoft.Json;
using System.Text;

namespace ModPos.TechnicalService.PresentationLayer.Controllers
{
    public class CategoriesController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public CategoriesController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public  IActionResult CategoryList()
        {
            
            return View();
        }

        [HttpGet]
        public async Task<IActionResult> UpdateCategory(int id)
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("https://localhost:44301/api/Categories/GetCategoryById/" + id);
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<UpdateCategoryDto>(jsonData);
                return View(values);
            }
            return RedirectToAction("CategoryList");
        }
        

        public IActionResult DeleteCategory(int id)
        {
            
            return View();
        }

        
        public IActionResult CreateCategory()
        {
            return View();
        }
        
    }
}
