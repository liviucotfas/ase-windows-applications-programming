using System;

namespace EventsPropertyTrigger
{
	public delegate void PriceChangedHandler(decimal oldPrice, decimal newPrice);

	internal class Stock
	{
		private string _symbol;
		private decimal _price;

		public Stock(string symbol)
		{
			_symbol = symbol;
		}

		public event PriceChangedHandler PriceChanged;

		public decimal Price
		{
			get { return _price; }
			set
			{
				if (_price == value) return; // Exit if nothing has changed
				decimal oldPrice = _price;
				_price = value;
				if (PriceChanged != null) // If invocation list not
					PriceChanged(oldPrice, _price); // empty, fire event.
			}
		}
	}

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
