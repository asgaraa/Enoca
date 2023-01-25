using DomainLayer.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainLayer.Entities
{
    public class Order:BaseEntity
    {
        public string FirmaId { get; set; }
        public Firma Firma { get; set; }
        public string ProductId { get; set; }
        public Product Product { get; set; }
    }
}
