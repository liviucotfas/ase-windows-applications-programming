using System;

namespace ValidationCustomExceptions.Entities
{
	public class InvalidBirthDateException : Exception
	{
		public DateTime BirthDate { get; set; }

		public InvalidBirthDateException(DateTime birthDay)
		{
			BirthDate = birthDay;
		}

		public override string Message
		{
			get
			{
				return "The birthDate " + BirthDate + " is invalid";
			}
		}
	}
}
