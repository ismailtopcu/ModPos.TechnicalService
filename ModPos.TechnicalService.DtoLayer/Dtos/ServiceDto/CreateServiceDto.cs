using ModPos.TechnicalService.DtoLayer.Dtos.CustomerDto;

namespace ModPos.TechnicalService.DtoLayer.Dtos.ServiceDto
{
    public class CreateServiceDto
    {
        public string ServiceCode { get; set; }
        public string ServiceNumber { get; set; }
        public int? CustomerId { get; set; }
        public string ServiceDescription { get; set; }
    }
}
