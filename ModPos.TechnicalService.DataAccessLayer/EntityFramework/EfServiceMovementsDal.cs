using AutoMapper;
using Microsoft.EntityFrameworkCore;
using ModPos.TechnicalService.DataAccessLayer.Abstract;
using ModPos.TechnicalService.DataAccessLayer.Concrete;
using ModPos.TechnicalService.DataAccessLayer.Repositories;
using ModPos.TechnicalService.DtoLayer.Dtos.ServiceDto;
using ModPos.TechnicalService.DtoLayer.Dtos.ServiceMovementsDto;
using ModPos.TechnicalService.EntityLayer.Concrete;

namespace ModPos.TechnicalService.DataAccessLayer.EntityFramework
{
    public class EfServiceMovementsDal : GenericRepository<ServiceMovements>, IServiceMovementsDal
    {
		private readonly AppDbContext _appDbContext;
		private readonly IMapper _mapper;
		public EfServiceMovementsDal(AppDbContext appDbContext, IMapper mapper) : base(appDbContext)
		{
            _appDbContext = appDbContext;
            _mapper = mapper;
        }

		public async Task<ResultServiceMovementsDto> GetServiceMovementsById(int id)
		{
			var value = await _appDbContext.ServiceMovements.Include(x => x.Service).Include(y => y.Product).FirstOrDefaultAsync(z=>z.ServiceMovementsId==id);
			var result =  _mapper.Map<ResultServiceMovementsDto>(value);
			return result;
		}

		public async Task<List<ResultServiceMovementsDto>> GetServiceMovementsList()
		{
			var values = await _appDbContext.ServiceMovements
				.Include(x=>x.Service)
				.ThenInclude(z=>z.Customer)
				.Include(y=>y.Product)
				.ThenInclude(c=>c.Category).ToListAsync();
			var result = _mapper.Map<List<ResultServiceMovementsDto>>(values);
			return result;
		}
		public async Task<List<ResultServiceMovementsDto>> GetServiceMovementsByServiceId(int serviceId)
		{
			var values = await _appDbContext.ServiceMovements
				.Include(x=>x.Product)
                .ThenInclude(c => c.Category)
                .Include(y=>y.Service)
                .ThenInclude(z => z.Customer)
                .Where(z=>z.ServiceId== serviceId).ToListAsync();
			var result = _mapper.Map<List<ResultServiceMovementsDto>>(values);
			return result;
		}
	}
}
