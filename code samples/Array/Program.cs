using System;

namespace Arrays
{
	class Program
	{
		static void Main(string[] args)
		{
			Array();
		}

		private static void Array()
		{
			//1. Declaration and assignment
			//declaration
			int[] intArray;

			// allocation
			intArray = new int[3]; //all values will be 0

			// declaration and assignment
			//var doubleArray = new double[]{ 34.23, 23.2 };
			var doubleArray = new[] { 34.23, 10.2, 23.2 }; //data type (double) is inferred

			//2. Accessing elements
			var arrayElement = doubleArray[0];
			doubleArray[1] = 5.55;

			// for
			for (var i = 0; i < intArray.Length; i++)
				Console.WriteLine(intArray[i]);

			// foreach
			foreach (var value in doubleArray)
				Console.WriteLine(value);

			//3. Other methods
			System.Array.Sort(doubleArray); //Note: double implements IComparable<double>

			// for
			for (var i = 0; i < doubleArray.Length; i++)
				Console.WriteLine("doubleArray[{0}]={1}", i, doubleArray[i]);
		}

		private static void RectangularArray()
		{
			// declaration and allocation
			var cub = new int[5, 2, 7];

			// declaration and assignment
			var matrix = new[,]{
					{ 4, 23,  5,  2 },
					{ 1,  6, 13, 29 }
				};

			// for
			for (var i = 0; i < matrix.GetLength(0); i++)
			{
				for (var j = 0; j < matrix.GetLength(1); j++)
					Console.Write(" {0}", matrix[i, j]);
				Console.WriteLine();
			}
		}

		private void JaggedArray()
		{
			int[][] jaggedArray =
			{
				new int[] {0, 1, 2},
				new int[] {3, 4},
				new int[] {6, 7, 8, 9}
			};
		}
	}
}
