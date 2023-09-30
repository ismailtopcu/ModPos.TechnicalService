using ModPos.TechnicalService.DtoLayer.Dtos.ServiceDto;
using ModPos.TechnicalService.EntityLayer.Concrete;

namespace ModPos.TechnicalService.DataAccessLayer.Abstract
{
    public interface IServiceDal : IGenericDal<Service>
    {
        Task<List<ResultServiceDto>> GetServiceList(int? customerId);
        Task<ResultServiceDto> GetServiceById(int id);
    }
    
}
