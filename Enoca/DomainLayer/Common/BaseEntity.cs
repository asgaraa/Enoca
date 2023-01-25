using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainLayer.Common
{
    public class BaseEntity
    {
        [Key]
        public string Id { get; set; }
        public bool SoftDelete { get; set; }
        public DateTime CreatTime { get; set; } = DateTime.Now;
    }
}
