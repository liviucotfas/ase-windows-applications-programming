using System;

namespace ConstructorDestructor
{
	internal interface IKnownProgrammingLanguages
	{
		string[] KnownProgrammingLanguages { get; set; }
		bool Knows(string language);
	}
}
