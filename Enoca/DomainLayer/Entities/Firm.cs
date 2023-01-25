using DomainLayer.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainLayer.Entities
{
    public class Firm:BaseEntity
    {
        public string Name { get; set; }
        public bool OrderAccess { get; set; }
        public DateTime OrderStartTime { get; set; }
        public DateTime OrderEndTime { get; set; }
        public List<Product> Products { get; set; }
    }
}
