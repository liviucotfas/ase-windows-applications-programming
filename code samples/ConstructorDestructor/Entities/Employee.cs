using System;

namespace ConstructorDestructor.Entities
{
	internal abstract class Employee : Person
	{
		#region Normal/Virtual/Abstract Methods
		public void PrintWageNormal()
		{
			Console.WriteLine("Employee - PrintWageNormal");
		}

		public virtual void PrintWageVirtual()
		{
			Console.WriteLine("Employee - PrintWageVirtual");
		}

		public abstract void PrintWageAbstract();
		#endregion

		public Employee(string name) : base(name)
		{
		}
	}
}
