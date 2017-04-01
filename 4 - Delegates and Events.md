Delegates and Events
=========
## Table of Contents
- [Delegates](#delegates)
- [Events](#events)
- [Other](#other)

| ![./media/image1.png](./media/image1.png) | Sample code available – Check the “Delegates” Sample |
|------------------------------------------|----------------------------------------------------------------------|

# Delegates

#### Assignment

1.  Create a new project with the name “Delegates”

	```C#
	 // This delegate can point to any method, taking two integers and returning an integer.
	public delegate int BinaryOp(int x, int y);

	// 
	public class SimpleMath
	{
		public static int Add(int x, int y)
		{ return x + y; }
		public static int Subtract(int x, int y)
		{ return x - y; }
	}

	internal class Program
	{
		private static void Main()
		{
			Console.WriteLine("***** Delegate Example *****\n");

			//Definire si instantiere delegat
			BinaryOp b = new BinaryOp(SimpleMath.Add);
			//BinaryOp b = new BinaryOp(SimpleMath.Subtract));
			//b += new BinaryOp(SimpleMath.Subtract);

			//Apel prin delegat
			Console.WriteLine("10 + 10 is {0}", b(10, 10));
			Console.ReadLine();
		}
	}
	```

#  Events

## Custom Events

| ![./media/image1.png](./media/image1.png) | Sample code available – Check the “EventsPropertyTrigger” Sample |
|------------------------------------------|----------------------------------------------------------------------------------|

#### Assignment

1.  Create a new project with the name “EventsPropertyTrigger”

	```C#
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
	```

## Standard Event Pattern

| ![./media/image1.png](./media/image1.png) | Sample code available – Check the “EventsPropertyTriggerEventArgs” Sample |
|------------------------------------------|-------------------------------------------------------------------------------------------|


#### Assignment

1.  Create a new project with the name “EventsPropertyTriggerEventArgs”

	```C#
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
	```

| ![./media/image2.png](./media/image2.png) | More event samples available |
|------------------------------------------|---------------------------------------------------------------------------------|

#  Other

##  Method Parameters

The **ref** keyword causes an argument to be passed by reference, not by value.
The effect of passing by reference is that any change to the parameter in the
called method is reflected in the calling method. For example, if the caller
passes a local variable expression or an array element access expression, and
the called method replaces the object to which the ref parameter refers, then
the caller’s local variable or the array element now refer to the new object.

| ![./media/image3.png](./media/image3.png) | Further reading: [link](https://msdn.microsoft.com/en-us/library/14akc2c7.aspx) |
|------------------------------------------|---------------------------------------------------------------------------------|


The **out** keyword causes arguments to be passed by reference. This is like the
ref keyword, except that ref requires that the variable be initialized before it
is passed. To use an out parameter, both the method definition and the calling
method must explicitly use the out keyword.

| ![./media/image3.png](./media/image3.png) | Further reading: [link](https://msdn.microsoft.com/en-us/library/t3c3bfhx.aspx) |
|------------------------------------------|---------------------------------------------------------------------------------|


#### Assignment

| ![./media/image1.png](./media/image1.png) | Sample code available – Check the “MethodParameters” Sample |
|------------------------------------------|---------------------------------------------------------------------------------|

```C#
private static void IncrementNormal(int i)
{
	i = i + 1;
}

private static void IncrementRef(ref int i)
{
	i = i + 1;
}

private static void IncrementOut(int i, out int result)
{
	result = i + 1;
}

private static void Main()
{
	//Normal
	var val = 1;
	IncrementNormal(val);
	Console.WriteLine(val);

	//Ref
	val = 1;
	IncrementRef(ref val);
	Console.WriteLine(val); // Output: 2

	//out
	val = 1;
	int result;
	IncrementOut(val, out result);
	Console.WriteLine(result); // Output: 2
}
```

## Static class

| ![./media/image3.png](./media/image3.png) | Further reading: [link](https://msdn.microsoft.com/en-us/library/79b3xss3.aspx) |
|------------------------------------------|---------------------------------------------------------------------------------|

## Nullable types

| ![./media/image3.png](./media/image3.png) | Further reading: [link](https://msdn.microsoft.com/en-us/library/1t3y8s4s.aspx) |
|------------------------------------------|---------------------------------------------------------------------------------|


## Boxing / Unboxing

| ![./media/image3.png](./media/image3.png) | Further reading: [link](https://msdn.microsoft.com/en-us/library/yz2be5wk.aspx) |
|------------------------------------------|---------------------------------------------------------------------------------|

