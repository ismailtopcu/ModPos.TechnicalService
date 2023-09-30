using ModPos.TechnicalService.BusinessLayer.Abstract;
using ModPos.TechnicalService.DataAccessLayer.Abstract;
using ModPos.TechnicalService.DtoLayer.Dtos.ServiceDto;
using ModPos.TechnicalService.DtoLayer.Dtos.ServiceMovementsDto;
using ModPos.TechnicalService.EntityLayer.Concrete;

namespace ModPos.TechnicalService.BusinessLayer.Concrete
{
    public class ServiceMovementsManager : IServiceMovementsService
    {
        private readonly IServiceMovementsDal _serviceMovementsDal;

        public ServiceMovementsManager(IServiceMovementsDal serviceMovementsDal)
        {
            _serviceMovementsDal = serviceMovementsDal;
        }

        public async Task TDeleteAsync(ServiceMovements t)
        {
           await _serviceMovementsDal.DeleteAsync(t);
        }

        public async Task<ServiceMovements> TGetByIdAsync(int id)
        {
            return await _serviceMovementsDal.GetByIdAsync(id);
        }

        public async Task<List<ServiceMovements>> TGetListAsync()
        {
            return await _serviceMovementsDal.GetListAsync();
        }

		public async Task<ResultServiceMovementsDto> TGetServiceMovementsById(int id)
		{
			return await _serviceMovementsDal.GetServiceMovementsById(id);
		}

		public async Task<List<ResultServiceMovementsDto>> TGetServiceMovementsByServiceId(int serviceId)
		{
			return await _serviceMovementsDal.GetServiceMovementsByServiceId(serviceId);
		}

		public async Task<List<ResultServiceMovementsDto>> TGetServiceMovementsList()
		{
			return await _serviceMovementsDal.GetServiceMovementsList();
		}

		public async Task TInsertAsync(ServiceMovements t)
        {
            await _serviceMovementsDal.InsertAsync(t);
        }

        public async Task TUpdateAsync(ServiceMovements t)
        {
            await _serviceMovementsDal.UpdateAsync(t);
        }
    }
}
