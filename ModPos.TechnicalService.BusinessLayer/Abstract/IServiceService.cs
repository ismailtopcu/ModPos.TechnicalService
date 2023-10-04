using ModPos.TechnicalService.DtoLayer.Dtos.ServiceDto;
using ModPos.TechnicalService.EntityLayer.Concrete;

namespace ModPos.TechnicalService.BusinessLayer.Abstract
{
    public interface IServiceService : IGenericService<Service>
    {
        Task<List<ResultServiceDto>> TGetServiceList(int? customerId);
        Task<ResultServiceDto> TGetServiceById(int id);
        ServiceStatusCountDto TGetStatusCount();


	}
}
