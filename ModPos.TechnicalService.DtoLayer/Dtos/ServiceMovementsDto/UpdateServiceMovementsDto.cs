﻿namespace ModPos.TechnicalService.DtoLayer.Dtos.ServiceMovementsDto
{
    public class UpdateServiceMovementsDto
    {
        public int ServiceMovementsId { get; set; }
        public int ServiceId { get; set; }
        public int ProductId { get; set; }
        public int ProductQuantity { get; set; }
        public decimal ServicePrice { get; set; }
        public decimal Currency { get; set; }
        public string ServiceTransactionType { get; set; }
        

    }

    
}
