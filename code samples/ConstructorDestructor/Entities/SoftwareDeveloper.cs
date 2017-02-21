using System;
using System.Linq;

namespace ConstructorDestructor.Entities
{
	internal class SoftwareDeveloper : Employee, IKnownProgrammingLanguages
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

		#region IKnownProgrammingLanguages
		public string[] KnownProgrammingLanguages { get; set; }
		public bool Knows(string language)
		{
			return KnownProgrammingLanguages.Contains(language);
		}
		#endregion

		public SoftwareDeveloper(string name) : base(name)
		{
		}
	}
}
