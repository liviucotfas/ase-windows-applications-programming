namespace Collections
{
	internal class Person
	{
		#region Properties
		public string Name { get; set; }
		public int Age { get; set; }
		#endregion

		public Person(string name, int age)
		{
			Name = name;
			Age = age;
		}

		public override string ToString()
		{
			return string.Format("Name: {0}, Age: {1}", Name, Age);
		}
	}
}
