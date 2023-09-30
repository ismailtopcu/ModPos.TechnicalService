using ModPos.TechnicalService.DtoLayer.Dtos.CustomerDto;
using ModPos.TechnicalService.EntityLayer.Concrete;

namespace ModPos.TechnicalService.BusinessLayer.Abstract
{
    public interface ICustomerService : IGenericService<Customer>
    {
        Task<List<ResultCustomerDto>> TGetCustomerList();
        Task<ResultCustomerDto> TGetCustomerById(int id);
    }
}
