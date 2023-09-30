using ModPos.TechnicalService.DtoLayer.Dtos.CategoryDto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModPos.TechnicalService.DtoLayer.Dtos.ProductDto
{
    public class ResultProductDto
    {
        public int ProductId { get; set; }
        public string ProductCode { get; set; }
        public  ResultCategoryDto Category { get; set; }
        public string ProductName { get; set; }
        public string ProductSerialNumber { get; set; }
        public string ProductBarcode { get; set; }
        public decimal PurchasePrice { get; set; }
        public decimal SellingPrice { get; set; }
    }
}
