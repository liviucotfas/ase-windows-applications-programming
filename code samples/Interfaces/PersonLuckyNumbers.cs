using System;

namespace StandardInterfaces
{
	internal class PersonLuckyNumbers : Person, ICloneable
	{
		#region Properties
		public int[] LuckyNumbers { get; set; }
		#endregion

		public PersonLuckyNumbers(string name, int age, int[] luckyNumbers) : base(name, age)
		{
			Console.WriteLine("PersonLuckyNumbers->PersonLuckyNumbers(string name, int age, int[] luckyNumbers)");
			LuckyNumbers = luckyNumbers;
		}

		/// <summary>
		/// Copy constructor
		/// </summary>
		/// <param name="other"></param>
		public PersonLuckyNumbers(PersonLuckyNumbers other)
			: base(other)
		{
			Console.WriteLine("PersonLuckyNumbers->PersonLuckyNumbers(PersonLuckyNumbers other)");

			LuckyNumbers = new int[other.LuckyNumbers.Length];
			for (var i = 0; i < other.LuckyNumbers.Length; i++)
			{
				LuckyNumbers[i] = other.LuckyNumbers[i];
			}
		}

		#region ICloneable
		public new object Clone()
		{
			// First get a shallow copy.
			var newPerson = (PersonLuckyNumbers)MemberwiseClone();

			// Then fill in the gaps.
			newPerson.LuckyNumbers = new int[LuckyNumbers.Length];
			for (var i=0; i< LuckyNumbers.Length; i++)
			{
				newPerson.LuckyNumbers[i] = LuckyNumbers[i];
			}

			return newPerson;
		}
		#endregion

		#region Overrides
		public override string ToString()
		{
			var luckyNumbers = LuckyNumbers != null ? string.Join(" ", LuckyNumbers) : string.Empty;
			return string.Format("Name: {0}, Age: {1}, LuckyNumbers: {2}", Name, Age, luckyNumbers);
		}
		#endregion
	}
}
