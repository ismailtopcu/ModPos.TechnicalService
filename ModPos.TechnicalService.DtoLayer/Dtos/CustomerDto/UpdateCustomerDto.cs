namespace ModPos.TechnicalService.DtoLayer.Dtos.CustomerDto
{
    public class UpdateCustomerDto
    {
        public int CustomerId { get; set; }
        public string CustomerName { get; set; }
        public string CustomerSurname { get; set; }
        public string PhoneNumber { get; set; }
        public string CustomerEmail { get; set; }
        public string Address { get; set; }
    }
}
