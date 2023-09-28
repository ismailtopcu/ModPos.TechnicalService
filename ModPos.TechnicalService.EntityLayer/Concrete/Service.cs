namespace ModPos.TechnicalService.EntityLayer.Concrete
{
    public class Service
    {
        public int ServiceId { get; set; }
        public string ServiceCode { get; set; }
        public string ServiceNumber { get; set; }
        public DateTime ServiceDate { get; set; }
        public int CustomerId { get; set; }
        public Customer Customer { get; set; }
        public string ServiceDescription { get; set; }
        public string ServiceStatus { get; set; }
        public List<ServiceMovements> ServiceMovements { get; set; }
        public decimal ServiceTotalAmount { get; set; }

    }
}
