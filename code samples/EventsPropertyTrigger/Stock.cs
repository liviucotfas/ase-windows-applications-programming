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
}
