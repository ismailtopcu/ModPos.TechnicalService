using AutoMapper;
using Microsoft.EntityFrameworkCore;
using ModPos.TechnicalService.DataAccessLayer.Abstract;
using ModPos.TechnicalService.DataAccessLayer.Concrete;
using ModPos.TechnicalService.DataAccessLayer.Repositories;
using ModPos.TechnicalService.DtoLayer.Dtos.ProductDto;
using ModPos.TechnicalService.EntityLayer.Concrete;

namespace ModPos.TechnicalService.DataAccessLayer.EntityFramework
{
    public class EfProductDal : GenericRepository<Product>, IProductDal
    {
        private readonly AppDbContext _appDbContext;
        private readonly IMapper _mapper;
        public EfProductDal(AppDbContext appDbContext, IMapper mapper) : base(appDbContext)
        {
            _appDbContext = appDbContext;
            _mapper = mapper;
        }

        public async Task<List<ResultProductDto>> GetProductList()
        {
            var values= await _appDbContext.Products.Include(x=>x.Category).ToListAsync();
            var result = _mapper.Map<List<ResultProductDto>>(values);
            return result;
        }

        public async Task<ResultProductDto> GetProductById(int id)
        {
            var value = await _appDbContext.Products.Include(x => x.Category).FirstOrDefaultAsync(y => y.ProductId == id);
            var result = _mapper.Map<ResultProductDto>(value);
            return result;
        }
    }
}
