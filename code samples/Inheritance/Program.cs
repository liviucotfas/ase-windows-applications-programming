using System;
using ConstructorDestructor.Entities;

namespace ConstructorDestructor
{
	internal class Program
	{
		private static void Main()
		{
			//AbstractNormalVirtualMethods();
			//AbstractNormalVirtualMethodsArray();
			CustomInterface();
		}

		private static void AbstractNormalVirtualMethods()
		{
			SoftwareDeveloper sd = new SoftwareDeveloper("SoftwareDeveloper1");
			Employee e = (Employee) sd; //same instance as above

			//Normal method
			Console.Write("\n###Hide");
			sd.PrintWageNormal();
			e.PrintWageNormal();

			//Virtual method
			Console.Write("\n###Override");
			sd.PrintWageVirtual();
			e.PrintWageVirtual();

			//Abstract method
			Console.WriteLine("\n###Abstract");
			sd.PrintWageAbstract();
			e.PrintWageAbstract();
		}

		private static void AbstractNormalVirtualMethodsArray()
		{
			var softwareDeveloper = new SoftwareDeveloper("SoftwareDeveloper1");
			var manager = new Manager("Manager1");

			Employee[] employees = new Employee[] {softwareDeveloper, manager};

			foreach (var employee in employees)
				employee.PrintWageNormal();

			foreach (var employee in employees)
				employee.PrintWageVirtual();

			foreach (var employee in employees)
				employee.PrintWageAbstract();
		}

		private static void CustomInterface()
		{
			//var softwareDeveloper = new SoftwareDeveloper {KnownProgrammingLanguages = new[] {"C#", "Java"}};
			var softwareDeveloper = new SoftwareDeveloper("SoftwareDeveloper1");
			softwareDeveloper.Languages = new[] {"C#", "Java"};

			var manager = new Manager("Manager1");

			var contractor = new Contractor("Contractor1");
			contractor.Languages = new[] {"C#"};

			Person[] persons = new Person[] {softwareDeveloper, manager, contractor};

			Console.WriteLine("###Using \"is\"");
			foreach (var person in persons)
			{
				if (person is IDeveloper)
				{
					Console.WriteLine("{0}: {1}",
						person.Name,
						string.Join(", ", ((IDeveloper) person).Languages));
				}
			}
			Console.WriteLine();

			Console.WriteLine("###Using \"as\"");
			foreach (var person in persons)
			{
				//IKnownProgrammingLanguages castToInterface = person as IKnownProgrammingLanguages;
				var castToInterface = person as IDeveloper;
				
				if (castToInterface != null)
				{
					Console.WriteLine("{0}: {1}",
						person.Name, 
						string.Join(", ", castToInterface.Languages));
				}
			}
		}
	}
}
