using System;

namespace DatabaseCommandSQLServer2Entities.Entities
{
	public class Participant
	{
		public long? Id { get; set; }
		public string LastName { get; set; }
		public string FirstName { get; set; }
		public DateTime BirthDate { get; set; }
		public int RaceId { get; set; }

		public Participant(string lastName, string firstName, DateTime birthDate, int raceId)
		{
			LastName = lastName;
			FirstName = firstName;
			BirthDate = birthDate;
			RaceId = raceId;
		}

		public Participant(long id, string lastName, string firstName, DateTime birthDate, int raceId) 
			:this(lastName, firstName, birthDate, raceId)
		{
			Id = id;
		}
	}
}
