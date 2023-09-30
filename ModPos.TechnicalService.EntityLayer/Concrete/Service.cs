namespace ModPos.TechnicalService.EntityLayer.Concrete
{
    public class Service
    {
        public int ServiceId { get; set; }
        public string ServiceCode { get; set; }
        public string ServiceNumber { get; set; }
        public DateTime ServiceDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public int CustomerId { get; set; }
        public Customer Customer { get; set; }
        public string ServiceDescription { get; set; }
        public string ServiceStatus { get; set; }
        public ICollection<ServiceMovements> ServiceMovements { get; set; }
        public Service()
        {
            ServiceMovements = new HashSet<ServiceMovements>();
        }

    }
}
