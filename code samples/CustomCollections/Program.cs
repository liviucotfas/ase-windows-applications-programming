using System;

namespace CustomCollections
{
	internal class Program
	{
		private static void Main()
		{
			PersonCollectionExample();
		}

		private static void PersonCollectionExample()
		{
			var personList = new PersonCollection();

			foreach (var p in personList)
				Console.WriteLine(p);
		}
	}
}
