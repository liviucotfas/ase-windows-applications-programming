using System.Linq;

namespace ConstructorDestructor.Entities
{
	internal class Contractor : Person, IDeveloper
	{
		#region IDeveloper
		public string[] Languages { get; set; }
		public bool Knows(string language)
		{
			return Languages.Contains(language);
		}
		#endregion

		public Contractor(string name) : base(name)
		{
		}
	}
}
