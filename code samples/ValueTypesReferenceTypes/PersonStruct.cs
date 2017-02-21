namespace EnumStructClass
{
	internal struct PersonStruct
	{
		#region Attributes
		public int Age;
		public string Name;
		public OccupationEnum Occupation;
		#endregion

		public PersonStruct(int age, string name, OccupationEnum occupation)
		{
			Age = age;
			Name = name;
			Occupation = occupation;
		}

		public override string ToString()
		{
			return string.Format("Name: {0}, Age: {1},  Occupation: {2}", Name, Age, Occupation);
		}
	}
}
