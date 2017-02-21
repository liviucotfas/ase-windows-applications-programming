using System;

namespace EventsPropertyTriggerEventArgs
{
	public class PriceChangedEventArgs : EventArgs
	{
		public readonly decimal LastPrice;
		public readonly decimal NewPrice;
		public PriceChangedEventArgs(decimal lastPrice, decimal newPrice)
		{
			LastPrice = lastPrice;
			NewPrice = newPrice;
		}
	}

	public class Stock
	{
		private string _symbol;
		private decimal _price;

		public Stock(string symbol)
		{
			_symbol = symbol;
		}

		public event EventHandler<PriceChangedEventArgs> PriceChanged;
		protected virtual void OnPriceChanged(PriceChangedEventArgs e)
		{
			if (PriceChanged != null) PriceChanged(this, e);
		}
		public decimal Price
		{
			get { return _price; }
			set
			{
				if (_price == value) return;
				decimal oldPrice = _price;
				_price = value;

				OnPriceChanged(new PriceChangedEventArgs(oldPrice, _price));
			}
		}
	}

	internal class Program
	{
		private static void Main()
		{
			var stock = new Stock("MSFT");
			stock.PriceChanged += Stock_PriceChanged1; ;
			stock.Price = 30;
			stock.Price = 60;
			stock.Price = 90;
		}

		private static void Stock_PriceChanged1(object sender, PriceChangedEventArgs e)
		{
			Console.WriteLine("MSFT: {0} {1}", e.LastPrice, e.NewPrice);
		}
	}
}
