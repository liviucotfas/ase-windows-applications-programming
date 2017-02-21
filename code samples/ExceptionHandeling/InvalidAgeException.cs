using System;

namespace ExceptionHandling
{
	public class InvalidAgeException : Exception
	{
		public int Age { get; set; }

		public InvalidAgeException(int age)
		{
			Age = age;
		}

		public override string Message
		{
			get
			{
				return "The age " + Age + " is invalid";
			}
		}
	}
}
