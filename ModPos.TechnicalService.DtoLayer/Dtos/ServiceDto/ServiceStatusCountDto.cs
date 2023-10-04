using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModPos.TechnicalService.DtoLayer.Dtos.ServiceDto
{
	public class ServiceStatusCountDto
	{
        public int AcceptedCount { get; set; }
        public int InProgressCount { get; set; }
        public int CompletedCount { get; set; }
        public int CustomerCount { get; set; }
    }
}
