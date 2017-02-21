using System;

namespace MethodParameters
{
	internal class Program
	{
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
	}
}
