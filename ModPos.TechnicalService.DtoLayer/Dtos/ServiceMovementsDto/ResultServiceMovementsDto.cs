using ModPos.TechnicalService.DtoLayer.Dtos.ProductDto;
using ModPos.TechnicalService.DtoLayer.Dtos.ServiceDto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModPos.TechnicalService.DtoLayer.Dtos.ServiceMovementsDto
{
    public class ResultServiceMovementsDto
    {
        public int ServiceMovementsId { get; set; }
        public int ServiceId { get; set; }
        public ResultServiceDto Service { get; set; }
        public int ProductId { get; set; }
        public ResultProductDto Product { get; set; }
        public int ProductQuantity { get; set; }
        public decimal ServicePrice { get; set; }
        public decimal Currency { get; set; }
        public decimal ServiceLineAmount { get => ProductQuantity * ServicePrice * Currency; }
        public string ServiceTransactionType { get; set; }
    }
}
