using System.Linq;

namespace ConstructorDestructor.Entities
{
	internal class Contractor : Person, IKnownProgrammingLanguages
	{
		#region IKnownProgrammingLanguages
		public string[] KnownProgrammingLanguages { get; set; }
		public bool Knows(string language)
		{
			return KnownProgrammingLanguages.Contains(language);
		}
		#endregion

		public Contractor(string name) : base(name)
		{
		}
	}
}
