using AutoMapper;
using Microsoft.EntityFrameworkCore;
using ModPos.TechnicalService.DataAccessLayer.Abstract;
using ModPos.TechnicalService.DataAccessLayer.Concrete;
using ModPos.TechnicalService.DataAccessLayer.Repositories;
using ModPos.TechnicalService.DtoLayer.Dtos.ServiceDto;
using ModPos.TechnicalService.EntityLayer.Concrete;

namespace ModPos.TechnicalService.DataAccessLayer.EntityFramework
{
    public class EfServiceDal : GenericRepository<Service>, IServiceDal
    {
        private readonly AppDbContext _appDbContext;
        private readonly IMapper _mapper;
        public EfServiceDal(AppDbContext appDbContext, IMapper mapper) : base(appDbContext)
        {
            _appDbContext = appDbContext;
            _mapper = mapper;
        }

        public async Task<ResultServiceDto> GetServiceById(int id)
        {
            var value = await _appDbContext.Services.Include(x=>x.Customer).Include(y=>y.ServiceMovements).FirstOrDefaultAsync(y=>y.ServiceId== id);
            var result = _mapper.Map<ResultServiceDto>(value);
            return result;
        }

        public async Task<List<ResultServiceDto>> GetServiceList(int? customerId)
        {
            var values = await _appDbContext.Services
                .Include(x=>x.Customer)
                .Include(y => y.ServiceMovements)
                .Where(a=>customerId == null | a.CustomerId == customerId)
                .ToListAsync();
            var result = _mapper.Map<List<ResultServiceDto>>(values);
            return result;
        }

    }
}
