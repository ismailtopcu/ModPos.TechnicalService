namespace ModPos.TechnicalService.DtoLayer.Dtos.ProductDto
{
    public class UpdateProductDto
    {
        public int ProductId { get; set; }
        public string ProductCode { get; set; }
        public int CategoryId { get; set; }
        public string ProductName { get; set; }
        public string ProductSerialNumber { get; set; }
        public string ProductBarcode { get; set; }
        public decimal PurchasePrice { get; set; }
        public decimal SellingPrice { get; set; }
    }
}
