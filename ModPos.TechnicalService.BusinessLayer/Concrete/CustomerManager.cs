using ModPos.TechnicalService.BusinessLayer.Abstract;
using ModPos.TechnicalService.DataAccessLayer.Abstract;
using ModPos.TechnicalService.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModPos.TechnicalService.BusinessLayer.Concrete
{
    public class CustomerManager : ICustomerService
    {
        private readonly ICustomerDal _customerDal;

        public CustomerManager(ICustomerDal customerDal)
        {
            _customerDal = customerDal;
        }

        public async Task TDeleteAsync(Customer t)
        {
           await _customerDal.DeleteAsync(t);
        }

        public async Task<Customer> TGetByIdAsync(int id)
        {
            return await _customerDal.GetByIdAsync(id);
        }

        public async Task<List<Customer>> TGetListAsync()
        {
            return await _customerDal.GetListAsync();
        }

        public async Task TInsertAsync(Customer t)
        {
            await _customerDal.InsertAsync(t);
        }

        public async Task TUpdateAsync(Customer t)
        {
            await _customerDal.UpdateAsync(t);
        }
    }
}
