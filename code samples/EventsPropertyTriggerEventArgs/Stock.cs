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
}
