using ModPos.TechnicalService.DtoLayer.Dtos.ServiceDto;
using ModPos.TechnicalService.DtoLayer.Dtos.ServiceMovementsDto;
using ModPos.TechnicalService.EntityLayer.Concrete;

namespace ModPos.TechnicalService.BusinessLayer.Abstract
{
    public interface IServiceMovementsService : IGenericService<ServiceMovements>
    {
		Task<List<ResultServiceMovementsDto>> TGetServiceMovementsList();
		Task<ResultServiceMovementsDto> TGetServiceMovementsById(int id);
		Task<List<ResultServiceMovementsDto>> TGetServiceMovementsByServiceId(int serviceId);

	}
}
