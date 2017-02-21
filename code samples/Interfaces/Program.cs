using System;

namespace StandardInterfaces
{
	internal class Program
	{
		private static void Main(string[] args)
		{
			//ReferenceTypeArray();

			DeepCopyCopyConstructor();
		}

		private static void ReferenceTypeArray()
		{
			var p1 = new Person("Name3", 42);
			var p2 = new Person("Name1", 23);
			var p3 = new Person("Name2", 32);

			var pArray = new Person[] { p1, p2, p3 };

			Array.Sort(pArray);

			//IComparable implementation is called automatically by methods such as Array..::.Sort

			foreach (var person in pArray)
			{
				Console.WriteLine(person);
			}
		}

		private static void ShallowCopyEqualOperator()
		{
			//Operator= - Shallow copy
			var p1 = new PersonLuckyNumbers("Name 1", 21, new []{13, 26, 39});
			var p2 = p1;

			p1.Age = 12;
			p1.LuckyNumbers[0] = 1;

			Console.WriteLine(p1);
			Console.WriteLine(p2);
		}

		private static void DeepCopyCopyConstructor()
		{
			var p1 = new PersonLuckyNumbers("Name 1", 21, new[] { 13, 26, 39 });
			Console.WriteLine();
			var p2 = new PersonLuckyNumbers(p1);

			p1.Age = 12;
			p1.LuckyNumbers[0] = 1;

			Console.WriteLine(p1);
			Console.WriteLine(p2);
		}
	}
}
