using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ModPos.TechnicalService.BusinessLayer.Abstract;
using ModPos.TechnicalService.DtoLayer.Dtos.CustomerDto;
using ModPos.TechnicalService.DtoLayer.Dtos.ServiceDto;
using ModPos.TechnicalService.EntityLayer.Concrete;

namespace ModPos.TechnicalService.WebAPI.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class ServicesController : ControllerBase
    {
        private readonly IServiceService _serviceService;
        private readonly IMapper _mapper;

        public ServicesController(IServiceService serviceService, IMapper mapper)
        {
            _serviceService = serviceService;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllServices(int? customerId)
        {
            var values = await _serviceService.TGetServiceList(customerId);
            
            return Ok(values);
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetServiceById(int id)
        {
            var value = await _serviceService.TGetServiceById(id);
            return Ok(value);
        }
        [HttpPost]
        public async Task<IActionResult> CreateService(CreateServiceDto createServiceDto)
        {
            var value = new Service
            {
                ServiceCode = createServiceDto.ServiceCode,
                ServiceNumber = createServiceDto.ServiceNumber,
                ServiceDate = DateTime.Now,
                CustomerId = createServiceDto.CustomerId.Value,
                ServiceDescription = createServiceDto.ServiceDescription,
                ServiceStatus = "Kabul Edildi"                
            };
            await _serviceService.TInsertAsync(value);
            return Ok();
        }
        [HttpDelete]
        public async Task<IActionResult> DeleteService(int id)
        {
            var value = await _serviceService.TGetByIdAsync(id);
            await _serviceService.TDeleteAsync(value);
            return Ok();
        }
        [HttpPut]
        public async Task<IActionResult> UpdateService(UpdateServiceDto updateServiceDto)
        {
            //var value = _mapper.Map<Service>(updateServiceDto);
            var value = new Service
            {
                ServiceId = updateServiceDto.ServiceId,
                ServiceCode = updateServiceDto.ServiceCode,
                ServiceNumber = updateServiceDto.ServiceNumber,
                UpdatedDate = DateTime.Now,
                CustomerId = updateServiceDto.CustomerId,
                ServiceDescription = updateServiceDto.ServiceDescription,
                ServiceDate = updateServiceDto.ServiceDate,
                ServiceStatus = updateServiceDto.ServiceStatus
            };

            await _serviceService.TUpdateAsync(value);
            return Ok();
        }
        [HttpGet]
        public IActionResult GetServiceStatus()
        {
           var values=  _serviceService.TGetStatusCount();
            return Ok(values);
        }
    }
}
