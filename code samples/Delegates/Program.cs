using System;

namespace DelegatesEvents
{
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
}
