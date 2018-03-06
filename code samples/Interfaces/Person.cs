using System;

namespace StandardInterfaces
{
	internal class Person : IComparable<Person>, ICloneable
	{
		#region Properties
		public string Name { get; set; }
		public int Age { get; set; }
		#endregion

		public Person()
		{
			Console.WriteLine("Person->Person()");
		}

		public Person(string name, int age)
		{
			Console.WriteLine("Person->Person(string name, int age)");
			Name = name;
			Age = age;
		}

		public Person(Person person): this(person.Name, person.Age)
		{
			Console.WriteLine("Person->(Person person)");
		}

		public int CompareTo(Person other)
		{
			//Note: string.CompareTo is culture-specific
			return Name.CompareTo(other.Name);
		}

		public override string ToString()
		{
			return string.Format("Name: {0}, Age: {1}", Name, Age);
		}

		public virtual object Clone()
		{
			var newPerson = (Person)MemberwiseClone();
			return newPerson;
		}
	}
}
