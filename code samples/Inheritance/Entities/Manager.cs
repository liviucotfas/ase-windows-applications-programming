using System;

namespace ConstructorDestructor.Entities
{
	internal class Manager : Employee
	{
		#region Normal/Virtual/Abstract Methods
		public new void PrintWageNormal()
		{
			Console.WriteLine("Manager - PrintWageNormal");
		}

		public override void PrintWageVirtual()
		{
			Console.WriteLine("Manager - CalculateBonusVirtual");
		}

		public override void PrintWageAbstract()
		{
			Console.WriteLine("Manager - PrintWageAbstract");
		}
		#endregion

		public Manager(string name) : base(name)
		{
		}
	}
}
