using Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.DTOs
{
    public class CarDetailDto:IDto
    {
        public int CarId { get; set; }
        public string BrandName { get; set; }
        public string ColorName { get; set; }
        public string ModelYear { get; set; }
        public string Description { get; set; }
        public decimal DailyPrice { get; set; }
        public string FirsName { get; set; }
        public string CompanyName { get; set; }



    }
}
