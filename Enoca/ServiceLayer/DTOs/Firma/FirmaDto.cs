using ServiceLayer.DTOs.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.DTOs.Firma
{
    public class FirmaDto
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public bool OrderAccess { get; set; }
        public DateTime OrderStartTime { get; set; }
        public DateTime OrderEndTime { get; set; }
        //public List<ProductDto> Products { get; set; }
    }
}
