namespace ModPos.TechnicalService.DtoLayer.Dtos.ServiceDto
{
    public class UpdateServiceDto
    {
        public int ServiceId { get; set; }
        public string ServiceCode { get; set; }
        public string ServiceNumber { get; set; }
        public DateTime ServiceDate { get; set; }
        public int CustomerId { get; set; }
        public string ServiceDescription { get; set; }
        public string ServiceStatus { get; set; }
    }
}
