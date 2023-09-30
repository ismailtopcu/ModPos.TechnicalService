using AutoMapper;
using Microsoft.EntityFrameworkCore;
using ModPos.TechnicalService.DataAccessLayer.Abstract;
using ModPos.TechnicalService.DataAccessLayer.Concrete;
using ModPos.TechnicalService.DataAccessLayer.Repositories;
using ModPos.TechnicalService.DtoLayer.Dtos.CustomerDto;
using ModPos.TechnicalService.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModPos.TechnicalService.DataAccessLayer.EntityFramework
{
    public class EfCustomerDal : GenericRepository<Customer>, ICustomerDal
    {
        private readonly AppDbContext _appDbContext;
        private readonly IMapper _mapper;
        public EfCustomerDal(AppDbContext appDbContext, IMapper mapper) : base(appDbContext)
        {
            _appDbContext = appDbContext;
            _mapper = mapper;
        }

        public async Task<ResultCustomerDto> GetCustomerById(int id)
        {
            var value = await _appDbContext.Customers.FirstOrDefaultAsync(y=>y.CustomerId == id);
            var result = _mapper.Map<ResultCustomerDto>(value);
            return result;
        }

        public async Task<List<ResultCustomerDto>> GetCustomerList()
        {
            var values = await _appDbContext.Customers.ToListAsync();
            var result = _mapper.Map<List<ResultCustomerDto>>(values); 
            return result;
        }
    }
}
