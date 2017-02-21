using System;

namespace ClipboardSample.Entities
{
	internal class Participant
	{
		public string LastName { get; set; }
		public string FirstName { get; set; }
		public DateTime BirthDate { get; set; }

		public Participant(string lastName, string firstName, DateTime birthDate)
		{
			LastName = lastName;
			FirstName = firstName;
			BirthDate = birthDate;
		}

		public override string ToString()
		{
			return string.Format("{0} {1} {2}", LastName, FirstName, BirthDate);
		}
	}
}
