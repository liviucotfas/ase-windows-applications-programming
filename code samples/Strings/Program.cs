using System;
using System.Diagnostics;
using System.Text;

namespace StringBuilderString
{
	internal class Program
	{
		private static void Main(string[] args)
		{
			SystemDataTypes();

			//1. Imutable
			//StringImmutable();

			//2. Operator==
			//StringEqual();

			//3. StringBuilder
			StringBuilderPerformance();

			//Ex 4
			//http://msdn.microsoft.com/en-us/library/t3c3bfhx(v=vs.90).aspx  out
		}

		private static void SystemDataTypes()
		{
			Console.Write("First Name: ");

			//declare the variable
			//string firstName;
			//store the input from the keyboard
			//firstName = Console.ReadLine();

			//written more concisely
			string? firstName = Console.ReadLine();

			Console.WriteLine("");

			DateTime currentTime = DateTime.Now;

			//{0} and {1} are replaced with the arguments
			//Console.WriteLine(string.Format("Hello {0}! Today is {1}.", firstName, DateTime.Now));
			//written more concisely
			Console.WriteLine("Hello {0}! Today is {1}.", firstName, currentTime);

			Console.ReadLine();
		}

		private static void StringImmutable()
		{
			/*Strings are immutable--the contents of a string object cannot be changed after the object is created, although the syntax makes it appear as if you can do this. For example, when you write this code, the compiler actually creates a new string object to hold the new sequence of characters, and that new object is assigned to b. */

			string s1 = "abc";
			string s2 = s1;
			s1 = s1.Replace("abc", "ba");
			Console.WriteLine(s1);
			Console.WriteLine(s2);

			String s3 = "abc";
			String s4 = s3;
			s3 += "d";
			Console.WriteLine(s3);
			Console.WriteLine(s4);

			Console.ReadLine();
		}

		private static void StringEqual()
		{
			string a = "hello";

			string b = "h";
			// Append to contents of 'b'
			b += "ello";

			Console.WriteLine(a == b); //will return true because operator== is overloaded
			Console.WriteLine((object)a == b);  //will return false because the objects are different

			Console.ReadLine();
		}

		private static void StringBuilderPerformance()
		{
			Console.WriteLine("###StringBuilderPerformance");

			const int noOfRepetitions = 50000;

			var regularString = string.Empty;

			// For a more precise measurement, use a performance counter instead of a Stopwatch
			var watch = Stopwatch.StartNew();
			for (var i = 0; i < noOfRepetitions; i++)
			{
				regularString += "a";
			}
			watch.Stop();
			var elapsedMs = watch.ElapsedMilliseconds;

			Console.WriteLine("Using System.String: {0}ms", elapsedMs);

			var stringBuilder = new StringBuilder();

			watch = Stopwatch.StartNew();
			for (var i = 0; i < noOfRepetitions; i++)
			{
				stringBuilder.Append("a");
			}
			regularString = stringBuilder.ToString();
			watch.Stop();
			elapsedMs = watch.ElapsedMilliseconds;

			Console.WriteLine("Using System.Text.StringBuilder: {0}ms", elapsedMs);

			Console.ReadLine();
		}
	}
}
