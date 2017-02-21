using System;

namespace EnumStructClass
{
	internal class PersonClass
	{
		#region Properties

		#region Age - Without using Properties
		private int _age;
		public int GetAge()
		{
			return _age; // "this._age" is implicit
		}
		public void SetAge(int value)
		{
			_age = value; // "this._age" is implicit
		}
		#endregion

		#region Name - Using properties
		private string _name;
		//Read/Write property
		public string Name
		{
			get { return _name; }
			set { _name = value; }
		}

		//Readonly property
		public string NameRO
		{
			get { return _name; }
		}
		#endregion

		#region Occupation - Using auto-property
		public OccupationEnum Occupation { get; set; }
		#endregion
		#endregion

		public PersonClass(int age)
		{
			Console.WriteLine("Constructor(default)");
			_age = age; //equivalent with this._age = age;
		}

		public PersonClass(int age, string name, OccupationEnum occupation):this(age)
		{
			Console.WriteLine("Constructor(parameters)");
			Name = name;
			Occupation = occupation;
		}

		//Copy constructor - https://msdn.microsoft.com/en-us/library/ms173116.aspx
		public PersonClass(PersonClass previousPerson) : this(previousPerson.GetAge(), previousPerson.Name, previousPerson.Occupation)
		{
			Console.WriteLine("Copy Constructor");
		}

		//Finalizer
		~PersonClass()
		{
			Console.WriteLine("Finalizer");
		}

		public override string ToString()
		{
			return string.Format("Name: {0}, Age: {1},  Occupation: {2}", Name, _age, Occupation);
		}
	}
}
