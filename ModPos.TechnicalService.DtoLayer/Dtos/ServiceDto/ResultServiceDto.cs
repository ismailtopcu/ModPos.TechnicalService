using ModPos.TechnicalService.DtoLayer.Dtos.CustomerDto;
using ModPos.TechnicalService.DtoLayer.Dtos.ServiceMovementsDto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModPos.TechnicalService.DtoLayer.Dtos.ServiceDto
{
	public class ResultServiceDto
	{
		public int ServiceId { get; set; }
		public string ServiceCode { get; set; }
		public string ServiceNumber { get; set; }
		public DateTime ServiceDate { get; set; }
		public ResultCustomerDto Customer { get; set; }
		public string ServiceDescription { get; set; }
		public string ServiceStatus { get; set; }
		public List<ResultServiceMovementsDto> ServiceMovements { get; set; }

		public decimal ServiceTotalAmount
		{
			get
			{
				if (ServiceMovements == null)
				{
					return 0;
				}
				else
				{
					return ServiceMovements.Sum(x => x.ServiceLineAmount);
				}
			}
		}
	}
}
