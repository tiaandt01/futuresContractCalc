namespace FrontEnd.Models
{
	public class FuturesContract
	{
		public string Symbol { get; init; } = default!;
		public string Name { get; init; } = default!;
		public decimal TickSize { get; init; }
		public decimal TickValue { get; init; }
		public decimal PointValue { get; init; }
	}
}
