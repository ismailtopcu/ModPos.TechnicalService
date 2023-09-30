using ModPos.TechnicalService.DtoLayer.Dtos.ServiceDto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModPos.TechnicalService.DtoLayer.Dtos.CustomerDto
{
    public class ResultCustomerDto
    {
        public int CustomerId { get; set; }
        public string CustomerName { get; set; }
        public string CustomerSurname { get; set; }
        public string PhoneNumber { get; set; }
        public string CustomerEmail { get; set; }
        public string Address { get; set; }
        public List<ResultServiceDto> Services{ get; set; }
    }
}
