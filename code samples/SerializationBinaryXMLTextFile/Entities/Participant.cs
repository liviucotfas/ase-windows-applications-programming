using System;

namespace SerializationBinaryXMLTextFile.Entities
{
	[Serializable]
	public class Participant
	{
		public string LastName { get; set; }
		public string FirstName { get; set; }
		public DateTime BirthDate { get; set; }

		public Participant()
		{
			
		}

		public Participant(string lastName, string firstName, DateTime birthDate):this()
		{
			LastName = lastName;
			FirstName = firstName;
			BirthDate = birthDate;
		}
	}
}
