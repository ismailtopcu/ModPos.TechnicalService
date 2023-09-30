using ModPos.TechnicalService.DtoLayer.Dtos.ServiceDto;
using ModPos.TechnicalService.DtoLayer.Dtos.ServiceMovementsDto;
using ModPos.TechnicalService.EntityLayer.Concrete;

namespace ModPos.TechnicalService.DataAccessLayer.Abstract
{
    public interface IServiceMovementsDal : IGenericDal<ServiceMovements>
    {
		Task<List<ResultServiceMovementsDto>> GetServiceMovementsList();
		Task<ResultServiceMovementsDto> GetServiceMovementsById(int id);
		Task<List<ResultServiceMovementsDto>> GetServiceMovementsByServiceId(int serviceId);
	}
    
}
