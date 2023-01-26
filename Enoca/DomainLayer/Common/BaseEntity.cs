using System.ComponentModel.DataAnnotations;

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
