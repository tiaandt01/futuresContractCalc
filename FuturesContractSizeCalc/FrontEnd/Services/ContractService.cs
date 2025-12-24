using FrontEnd.Models;

namespace FrontEnd.Services
{
	public static class ContractService
	{
		public static readonly List<FuturesContract> Contracts = new()
	{
		new() { Symbol = "NQ",  Name = "E-mini Nasdaq", TickSize = 0.25m, TickValue = 5m,   PointValue = 20m },
		new() { Symbol = "MNQ", Name = "Micro Nasdaq",  TickSize = 0.25m, TickValue = 0.5m, PointValue = 2m  },

		new() { Symbol = "ES",  Name = "E-mini S&P 500", TickSize = 0.25m, TickValue = 12.5m, PointValue = 50m },
		new() { Symbol = "MES", Name = "Micro S&P 500",  TickSize = 0.25m, TickValue = 1.25m, PointValue = 5m  },

		new() { Symbol = "YM",  Name = "E-mini Dow", TickSize = 1m, TickValue = 5m,   PointValue = 5m   },
		new() { Symbol = "MYM", Name = "Micro Dow",  TickSize = 1m, TickValue = 0.5m, PointValue = 0.5m },

		new() { Symbol = "CL",  Name = "Crude Oil",       TickSize = 0.01m, TickValue = 10m, PointValue = 1000m },
		new() { Symbol = "MCL", Name = "Micro Crude Oil", TickSize = 0.01m, TickValue = 1m,  PointValue = 100m  },

		new() { Symbol = "GC",  Name = "Gold",       TickSize = 0.10m, TickValue = 10m, PointValue = 100m },
		new() { Symbol = "MGC", Name = "Micro Gold", TickSize = 0.10m, TickValue = 1m,  PointValue = 10m  }
	};
	}
}
