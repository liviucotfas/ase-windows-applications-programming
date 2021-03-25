using System;

namespace StandardInterfaces
{
	internal class Student : Person, ICloneable
	{
		#region Properties
		public int[] Marks { get; set; }
		#endregion

		public Student(string name, int age, int[] marks) : base(name, age)
		{
			Console.WriteLine("Student->Student(string name, int age, int[] marks)");
			Marks = marks;
		}

		/// <summary>
		/// Copy constructor
		/// </summary>
		/// <param name="other"></param>
		public Student(Student other)
			: base(other)
		{
			Console.WriteLine("Student->Student(Student other)");

			//Marks = new int[other.Marks.Length];
			//for (var i = 0; i < other.Marks.Length; i++)
			//{
			//	Marks[i] = other.Marks[i];
			//}
			Marks = (int[])other.Marks.Clone();
		}

		#region ICloneable
		public override object Clone()
		{
			// First get a shallow copy.
			var newPerson = (Student)this.MemberwiseClone();

			// Then fill in the gaps.
			//newPerson.Marks = new int[Marks.Length];
			//for (var i=0; i< Marks.Length; i++)
			//{
			//	newPerson.Marks[i] = Marks[i];
			//}
			newPerson.Marks = (int[])Marks.Clone();

			return newPerson;
		}
		#endregion

		#region Overrides
		public override string ToString()
		{
			var marks = Marks != null ? string.Join(" ", Marks) : string.Empty;
			return string.Format("Name: {0}, Age: {1}, Marks: {2}", Name, Age, marks);
		}
		#endregion
	}
}
