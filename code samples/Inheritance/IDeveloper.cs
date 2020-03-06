using System;

namespace ConstructorDestructor
{
	internal interface IDeveloper
	{
		string[] Languages { get; set; }
		bool Knows(string language);
	}
}
