namespace ConstructorDestructor.Entities
{
	internal abstract class Person
	{
		public string Name { get; set; }

		public Person(string name)
		{
			Name = name;
		}
	}
}
