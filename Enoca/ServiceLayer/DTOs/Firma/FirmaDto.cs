namespace ServiceLayer.DTOs.Firma
{
	public class FirmaDto
	{
		public string Name { get; set; }
		public bool OrderAccess { get; set; }
		public DateTime OrderStartTime { get; set; }
		public DateTime OrderEndTime { get; set; }
		//public List<ProductDto> Products { get; set; }
	}
}
