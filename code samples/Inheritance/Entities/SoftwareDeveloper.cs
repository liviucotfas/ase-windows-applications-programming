using System;
using System.Linq;

namespace ConstructorDestructor.Entities
{
	internal class SoftwareDeveloper : Employee, IDeveloper
	{
		#region Normal/Virtual/Abstract Methods
		public new void PrintWageNormal()
		{
			Console.WriteLine("SoftwareDeveloper - PrintWageNormal");
		}

		public override void PrintWageVirtual()
		{
			Console.WriteLine("SoftwareDeveloper - CalculateBonusVirtual");
		}

		public override void PrintWageAbstract()
		{
			Console.WriteLine("SoftwareDeveloper - PrintWageAbstract");
		}
		#endregion

		#region IDeveloper
		public string[] Languages { get; set; }
		public bool Knows(string language)
		{
			return Languages.Contains(language);
		}
		#endregion

		public SoftwareDeveloper(string name) : base(name)
		{
		}
	}
}
