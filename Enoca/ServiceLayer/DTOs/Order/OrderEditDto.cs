using ServiceLayer.DTOs.Firma;
using ServiceLayer.DTOs.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.DTOs.Order
{
    public class OrderEditDto
    {
        public string Id { get; set; }
        public FirmaDto Firm { get; set; }
        public ProductDto Product { get; set; }
        public string Name { get; set; }
        public DateTime OrderDate { get; set; } = DateTime.UtcNow;
    }
}
