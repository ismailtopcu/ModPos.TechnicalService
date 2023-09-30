namespace ModPos.TechnicalService.EntityLayer.Concrete
{
    public class ServiceMovements
    {
        public int ServiceMovementsId { get; set; }
        public int ServiceId { get; set; }
        public Service Service { get; set; }
        public int ProductId { get; set; }
        public Product Product { get; set; }
        public int ProductQuantity { get; set; }
        public decimal ServicePrice { get; set; }
        public decimal Currency { get; set; }
        public string ServiceTransactionType { get; set; }
    }
}
