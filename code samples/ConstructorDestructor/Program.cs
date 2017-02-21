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
			SoftwareDeveloper softwareDeveloper = new SoftwareDeveloper("SoftwareDeveloper1");
			Employee employeeReference = (Employee) softwareDeveloper; //same instance as above

			//Normal method
			Console.Write("\n###Hide");
			softwareDeveloper.PrintWageNormal();
			employeeReference.PrintWageNormal();

			//Virtual method
			Console.Write("\n###Override");
			softwareDeveloper.PrintWageVirtual();
			employeeReference.PrintWageVirtual();

			//Abstract method
			Console.WriteLine("\n###Abstract");
			softwareDeveloper.PrintWageAbstract();
			employeeReference.PrintWageAbstract();

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
			softwareDeveloper.KnownProgrammingLanguages = new[] {"C#", "Java"};

			var manager = new Manager("Manager1");

			var contractor = new Contractor("Contractor1");
			contractor.KnownProgrammingLanguages = new[] {"C#"};

			Person[] persons = new Person[] {softwareDeveloper, manager, contractor};

			Console.WriteLine("###Using \"is\"");
			foreach (var person in persons)
			{
				if (person is IKnownProgrammingLanguages)
				{
					Console.WriteLine("{0}: {1}",
						person.Name,
						string.Join(", ", ((IKnownProgrammingLanguages) person).KnownProgrammingLanguages));
				}
			}
			Console.WriteLine();

			Console.WriteLine("###Using \"as\"");
			foreach (var person in persons)
			{
				//IKnownProgrammingLanguages castToInterface = person as IKnownProgrammingLanguages;
				var castToInterface = person as IKnownProgrammingLanguages;
				
				if (castToInterface != null)
				{
					Console.WriteLine("{0}: {1}",
						person.Name, 
						string.Join(", ", castToInterface.KnownProgrammingLanguages));
				}
			}
		}
	}
}
