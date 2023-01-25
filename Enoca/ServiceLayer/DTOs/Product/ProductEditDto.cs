using ServiceLayer.DTOs.Firma;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.DTOs.Product
{
    public class ProductEditDto
    {
        public string Id { get; set; }
        public FirmaDto Firma { get; set; }
        public string Name { get; set; }
        public bool Stok { get; set; }
        public double Price { get; set; }
    }
}
