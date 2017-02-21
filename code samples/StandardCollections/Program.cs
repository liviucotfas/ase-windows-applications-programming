using System;
using System.Collections;
using System.Collections.Generic;

namespace Collections
{
	internal class Program
	{
		private static void Main()
		{
			//ArrayListExample();
			//ListExample();
			ListPersonExample();
		}

		private static void ArrayListExample()
		{
			var words = new ArrayList();
			words.Add("melon");
			words.Add("avocado");
			string first = (string)words[0];

			//int first = (int)words[0]; // throws an exception
		}

		private static void ListExample()
		{
			// New string-typed list
			var words = new List<string>();
			words.Add("melon");
			words.Add("avocado");
			words.AddRange(new[] { "banana", "plum" });
			
			// Insert at start
			words.Insert(0, "lemon"); 
			
			// Insert at start
			words.InsertRange(0, new[] { "peach", "nashi" }); 
			words.Remove("melon");
			
			// Remove the 4th element
			words.RemoveAt(3); 
			
			// Remove first 2 elements
			words.RemoveRange(0, 2);
			
			// Remove all strings starting in 'n':
			words.RemoveAll(x => x.StartsWith("n"));
			
			for (var i=0; i<words.Count; i++)
			{
				Console.WriteLine(words[i]);
			}

			foreach (var word in words)
			{
				Console.WriteLine(word);
			}
		}

		private static void ListPersonExample()
		{
			var personList = new List<Person>();

			var rnd = new Random();
			for (var i = 0; i < 10; i++)
			{
				personList.Add(new Person("Persoana " + i, rnd.Next(100)));
			}

			//Which interface is needed for Array.Sort(personList)

			foreach (var p in personList) //equivalent to foreach (var p in personList)
				Console.WriteLine(p);
		}
	}
}
