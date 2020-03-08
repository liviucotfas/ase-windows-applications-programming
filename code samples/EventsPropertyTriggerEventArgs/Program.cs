using System;

namespace EventsPropertyTriggerEventArgs
{
	internal class Program
	{
		private static void Main()
		{
			var stock = new Stock("MSFT");
			stock.PriceChanged += Stock_PriceChanged; ;
			stock.Price = 30;
			stock.Price = 60;
			stock.Price = 90;
		}

		private static void Stock_PriceChanged(object sender, PriceChangedEventArgs e)
		{
			Console.WriteLine("MSFT: {0} {1}", e.LastPrice, e.NewPrice);
		}
	}
}
