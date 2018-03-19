using System;

namespace EventsPropertyTrigger
{
	internal class Program
	{
		private static void Main()
		{
			var stock = new Stock("MSFT");
			stock.PriceChanged += Stock_PriceChanged;
			stock.Price = 30;
			stock.Price = 60;
			stock.Price = 90;
		}

		private static void Stock_PriceChanged(decimal oldPrice, decimal newPrice)
		{
			Console.WriteLine("MSFT: {0} {1}", oldPrice, newPrice);
		}
	}
}
