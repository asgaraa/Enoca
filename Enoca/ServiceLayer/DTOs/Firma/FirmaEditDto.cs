namespace ServiceLayer.DTOs.Firma
{
	public class FirmaEditDto
	{
		public string Id { get; set; }
		public bool OrderAccess { get; set; }
		public DateTime OrderStartTime { get; set; }
		public DateTime OrderEndTime { get; set; }

	}
}
