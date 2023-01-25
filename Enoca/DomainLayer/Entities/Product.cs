using DomainLayer.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainLayer.Entities
{
    public class Product:BaseEntity
    {
        public Firm Firma { get; set; }
        public string Name { get; set; }
        public bool Stok { get; set; }
        public double Price { get; set; }
    }
}
