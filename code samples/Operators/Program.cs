using System;

namespace Operators
{
	internal class Program
	{
		private static void Main()
		{
			var p = new Person("Name1", 21);
			var p2 = new Person("Name2", 22);

			//TODO
			//personList[0] = ((Person)personList[0]) + 10;

			//int age = p; //cast implicit
			int age = (int)p; //cast explicit
			Console.WriteLine("Age: {0}", age);

			if(p<p2)
				Console.WriteLine("p.Age < p2.Age");

			//TODO
			#region Explicit Cast Example
			/*int totalAge = 0;
			foreach (Person p in personList)
				totalAge+= (int) p;
			Console.WriteLine(totalAge);*/
			#endregion
		}
	}
}
