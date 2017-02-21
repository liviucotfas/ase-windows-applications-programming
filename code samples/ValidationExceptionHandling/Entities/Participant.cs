using System;
using ValidationExceptionHandeling.Entities;

namespace ValidationCustomExceptions.Entities
{
	internal class Participant
	{
		public string LastName { get; set; }
		public string FirstName { get; set; }

		#region BirthDate
		private DateTime _birthDate;
		public DateTime BirthDate {
			get { return _birthDate; }
			set
			{
				if(value >= DateTime.Today)
					throw new InvalidBirthDateException(value);
				_birthDate = value;
			}
		}
		#endregion

		public GenderEnum Gender { get; set; }
		public string SSN { get; set; }

		public Participant(string lastName, string firstName, DateTime birthDate, GenderEnum gender, string ssn)
		{
			LastName = lastName;
			FirstName = firstName;
			BirthDate = birthDate;
			Gender = gender;
			SSN = ssn;
		}
	}
}
