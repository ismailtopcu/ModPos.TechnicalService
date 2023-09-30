using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ModPos.TechnicalService.BusinessLayer.Abstract;
using ModPos.TechnicalService.DtoLayer.Dtos.ServiceMovementsDto;
using ModPos.TechnicalService.EntityLayer.Concrete;

namespace ModPos.TechnicalService.WebAPI.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class ServiceMovementsController : ControllerBase
    {
        private readonly IServiceMovementsService _serviceMovementsService;
        private readonly IMapper _mapper;

        public ServiceMovementsController(IServiceMovementsService serviceMovementsService, IMapper mapper)
        {
            _serviceMovementsService = serviceMovementsService;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllServiceMovements()
        {
            var values = await _serviceMovementsService.TGetServiceMovementsList();
            return Ok(values);
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetServiceMovementsById(int id)
        {
            var value = await _serviceMovementsService.TGetServiceMovementsById(id);
            return Ok(value);
        }
        [HttpGet]
        public async Task<IActionResult> GetServiceMovementsByServiceId(int id)
        {
            var value = await _serviceMovementsService.TGetServiceMovementsByServiceId(id);
            return Ok(value);
        }

        [HttpPost]
        public async Task<IActionResult> CreateServiceMovements(CreateServiceMovementsDto createServiceMovementsDto)
        {

            var value = _mapper.Map<ServiceMovements>(createServiceMovementsDto);
            await _serviceMovementsService.TInsertAsync(value);
            return Ok();
        }
        [HttpDelete]
        public async Task<IActionResult> DeleteServiceMovements(int id)
        {
            var value = await _serviceMovementsService.TGetByIdAsync(id);
            await _serviceMovementsService.TDeleteAsync(value);
            return Ok();
        }
        [HttpPut]
        public async Task<IActionResult> UpdateServiceMovements(UpdateServiceMovementsDto updateServiceMovementsDto)
        {

            var value = _mapper.Map<ServiceMovements>(updateServiceMovementsDto);
            await _serviceMovementsService.TUpdateAsync(value);
            return Ok();
        }
    }
}
