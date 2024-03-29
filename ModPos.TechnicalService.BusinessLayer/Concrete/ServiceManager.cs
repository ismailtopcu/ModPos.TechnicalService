﻿using ModPos.TechnicalService.BusinessLayer.Abstract;
using ModPos.TechnicalService.DataAccessLayer.Abstract;
using ModPos.TechnicalService.DtoLayer.Dtos.ServiceDto;
using ModPos.TechnicalService.EntityLayer.Concrete;

namespace ModPos.TechnicalService.BusinessLayer.Concrete
{
    public class ServiceManager : IServiceService
    {
        private readonly IServiceDal _serviceDal;

        public ServiceManager(IServiceDal serviceDal)
        {
            _serviceDal = serviceDal;
        }

        public async Task TDeleteAsync(Service t)
        {
            await _serviceDal.DeleteAsync(t);
        }

        public async Task<Service> TGetByIdAsync(int id)
        {
            return await _serviceDal.GetByIdAsync(id);
        }

        public async Task<List<Service>> TGetListAsync()
        {
            return await _serviceDal.GetListAsync();
        }

        public async Task<ResultServiceDto> TGetServiceById(int id)
        {
            return await _serviceDal.GetServiceById(id);
        }

        public async Task<List<ResultServiceDto>> TGetServiceList(int? customerId)
        {
            return await _serviceDal.GetServiceList(customerId);
        }

		public ServiceStatusCountDto TGetStatusCount()
		{
			return _serviceDal.GetStatusCount();
		}

		public async Task TInsertAsync(Service t)
        {
            await _serviceDal.InsertAsync(t);
        }

        public async Task TUpdateAsync(Service t)
        {
            await _serviceDal.UpdateAsync(t);
        }
    }
}
