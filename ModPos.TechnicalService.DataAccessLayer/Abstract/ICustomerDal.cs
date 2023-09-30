using ModPos.TechnicalService.DtoLayer.Dtos.CustomerDto;
using ModPos.TechnicalService.DtoLayer.Dtos.ProductDto;
using ModPos.TechnicalService.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModPos.TechnicalService.DataAccessLayer.Abstract
{
    public interface ICustomerDal:IGenericDal<Customer>
    {
        Task<List<ResultCustomerDto>> GetCustomerList();
        Task<ResultCustomerDto> GetCustomerById(int id);
    }
    
}
