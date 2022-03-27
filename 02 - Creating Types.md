# Creating Types

<!-- vscode-markdown-toc -->
* 1. [Table of Contents](#TableofContents)
* 2. [Objectives](#Objectives)
* 3. [Enums](#Enums)
* 4. [Structures](#Structures)
* 5. [Classes](#Classes)
* 6. [Standard Interfaces](#StandardInterfaces)
	* 6.1. [IComparable\<T\> / IComparer\<T\>](#IComparableTIComparerT)
	* 6.2. [ICloneable](#ICloneable)
* 7. [Operators](#Operators)
* 8. [Class Inheritance](#ClassInheritance)
	* 8.1. [Abstract classes](#Abstractclasses)
	* 8.2. [Custom Interfaces](#CustomInterfaces)
* 9. [Bibliography](#Bibliography)

<!-- vscode-markdown-toc-config
	numbering=true
	autoSave=true
	/vscode-markdown-toc-config -->
<!-- /vscode-markdown-toc -->
##  1. <a name='TableofContents'></a>Table of Contents
- [Enums](#enums)
- [Structures](#structures)
- [Classes](#classes)
- [Standard Interfaces](#standard-interfaces)
- [Operators](#operators)
- [Class Inheritance](#class-inheritance)

##  2. <a name='Objectives'></a>Objectives
- Declaring enums
- Declaring structures
- Declaring classes
- Encapsulation using properties;
- Classes with multiple constructors


##  3. <a name='Enums'></a>Enums
The **enum** keyword is used to declare an enumeration, a distinct type that consists of a set of named constants called the enumerator list. By default, the
first enumerator has the value 0, and the value of each successive enumerator is increased by 1.

##### Assignment

1. Add the following enumeration
	```C#
	internal enum OccupationEnum
	{
		Child = 0,
		Student,
		Employee
	}
	```

2. In the Main method try to cast from

    -   UserAccountTypeEnum.SoftwareDeveloper to System.Int32

    -   System.Int32 to UserAccountTypeEnum

##  4. <a name='Structures'></a>Structures

A Structure (struct in C\#) type is a value type that is typically used to encapsulate small groups of related variables.

##### Assignment

1.  Add the PersonStruct defined below

	```C#
	internal struct PersonStruct
	{
		#region Attributes
		public int Age;
		public string Name;
		public OccupationEnum Occupation;
		#endregion

		public PersonStruct(int age, string name, OccupationEnum occupation)
		{
			Age = age;
			Name = name;
			Occupation = occupation;
		}

		public override string ToString()
		{
			return string.Format("Name: {0}, Age: {1},  Occupation: {2}", Name, Age, Occupation);
		}
	}
	```

2.  Add the ValueTypeAssignment method in Program.cs and call it from the Main() method.

	```C#
	private static void ValueTypeAssignment()
	{
		Console.WriteLine("###Assigning value types\n");
		var personStruct1 = new PersonStruct(1, "name1", OccupationEnum.Student);
		var personStruct2 = personStruct1;
		
		Console.WriteLine(personStruct1); // automatically calls .ToString(). The method is defined in System.Object and overridden in PersonStruct
		Console.WriteLine(personStruct2);

		// Change personStruct1.Name and print again. personStruct2.Name is not changed.
		personStruct1.Name = "NewName";
		Console.WriteLine(personStruct1);
		Console.WriteLine(personStruct2);
	}
	```

Questions

-   Why is it possible to override the `ToString` method?

##  5. <a name='Classes'></a>Classes

##### Assignment

1.  Add the PersonClass class defined below.

	```C#
	internal class PersonClass
	{
		#region Properties

		#region Age - Without using Properties
		private int _age;
		public int GetAge()
		{
			return _age; // "this._age" is implicit
		}
		public void SetAge(int value)
		{
			_age = value; // "this._age" is implicit
		}
		#endregion

		#region Name - Using properties
		private string _name;
		//Read/Write property
		public string Name
		{
			get { return _name; }
			set { _name = value; }
		}

		//Readonly property
		public string Name2
		{
			get { return _name; }
		}
		#endregion

		#region Occupation - Using auto-property
		public OccupationEnum Occupation { get; set; }
		#endregion
		#endregion

		public PersonClass(int age)
		{
			Console.WriteLine("Constructor(default)");
			_age = age; //equivalent with this._age = age;
		}

		public PersonClass(int age, string name, OccupationEnum occupation):this(age)
		{
			Console.WriteLine("Constructor(parameters)");
			Name = name;
			Occupation = occupation;
		}

		//Copy constructor - https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/how-to-write-a-copy-constructor
		public PersonClass(PersonClass previousPerson) : this(previousPerson.GetAge(), previousPerson.Name, previousPerson.Occupation)
		{
			Console.WriteLine("Copy Constructor");
		}
		
		//Destructor
		~PersonClass()
		{
			Console.WriteLine("Destructor");
		}

		public override string ToString()
		{
			return string.Format("Name: {0}, Age: {1},  Occupation: {2}", Name, _age, Occupation);
		}
	}
	```

2.  Add the ReferenceTypeAssignment method in Program.cs and call it from the Main() method.

	```C#
	private static void ReferenceTypeAssignment()
	{
		Console.WriteLine("Assigning reference types\n");
		var personClass1 = new PersonClass(1, "name1", OccupationEnum.Student);
		var personClass2 = personClass1;

		Console.WriteLine(personClass1); // automatically calls .ToString(). The method is defined in System.Object and overridden in PersonClass
		Console.WriteLine(personClass2);

		// Change personClass1.Name and _age and print again. personClass2.Name and _age have changed.
		personClass1.Name = "NewUserName";
		personClass1.SetAge(22);
		Console.WriteLine("\n=> Changed personClass1.Name and personClass1._age\n");
		Console.WriteLine(personClass1);
		Console.WriteLine(personClass2);
	}
	```

Question

-   Can the `PersonClass()` constructor be made private? (can we have private constructors?)

##  6. <a name='StandardInterfaces'></a>Standard Interfaces

###  6.1. <a name='IComparableTIComparerT'></a>IComparable\<T\> / IComparer\<T\>

##### Assignment

1.  Create a new project with the name “StandardInterfaces”

2.  Add the following `Person` class

	Hint: You can generate the constructor by choosing the corresponding option in Visual Studio.

	```C#
	internal class Person
	{
		#region Properties
		public string Name { get; set; }
		public int Age { get; set; }
		#endregion

		public Person(string name, int age)
		{
			Name = name;
			Age = age;
		}
	}
	```

3.  Add the following method in the `Program` class and call it from the `Main()` method (Note: an exception will be thown when you run the project)

	```C#
	private static void ReferenceTypeArray()
	{
		var p1 = new Person("Name3", 42);
		var p2 = new Person("Name1", 23);
		var p3 = new Person("Name2", 32);

		var pArray = new Person[] { p1, p2, p3 };

		Array.Sort(pArray);

		//IComparable implementation is called automatically by methods such as Array..::.Sort

		foreach (var person in pArray)
		{
			Console.WriteLine(person);
		}
	}
	```

4.  Implement the `IComparable<Person>` interface for the `Person` class.

	```C#
	internal class Person : IComparable<Person>
	{
		#region Properties
		public string Name { get; set; }
		public int Age { get; set; }
		#endregion

		public Person(string name, int age)
		{
			Name = name;
			Age = age;
		}

		public int CompareTo(Person other)
		{
			//Note: string.CompareTo is culture-specific
			return Name.CompareTo(other.Name);	
		}
	}
	```

5. Change the `IComparable<Person>` implementation in order to sort the persons in descending order, based on their age
6. Change the `IComparable<Person>` implementation in order to sort the persons using 2 criteria at the same time (name and age)
7. Add a new class to the project that implements the `IComparer<Person>` interface in order to sort the persons in ascending order based on their name
8. Add a new class to the project that implements the `IComparer<Person>` interface in order to sort the persons in descending order based on their name

###  6.2. <a name='ICloneable'></a>ICloneable

1.  Based on the `Person` class, derive the `Student` class.

	```C#
	internal class Student : Person
	{
		public int[] Marks { get; set; }

		public Student(string name, int age, int[] marks) : base(name, age)
		{
			Marks = marks;
		}
	}
	```

2.  Add the following method in the `Program` class and call it from the `Main` method

	```C#
	private static void ShallowCopyEqualOperator()
	{
		var p1 = new Student("Name 1", 21, new []{10, 10, 10});
		var p2 = p1;

		p1.Age = 12;
		p1.Marks[0] = 2;

		Console.WriteLine(p1);
		Console.WriteLine(p2);
	}
	```

3.  Run the application and notice the values in the two objects

4.  Implement the `ICloneable` interface for the `Student` class as follows (shallow copy only)

	```C#
	internal class Student : Person, ICloneable
	{
		public int[] Marks { get; set; }

		public Student(string name, int age, int[] marks) : base(name, age)
		{
			Marks = marks;
		}

		public object Clone()
		{
			// First get a shallow copy.
			var clone = (Student)MemberwiseClone();
			
			return clone;
		}
	}
	```

5.  Add the following method in the `Program` class and call it from the `Main` method

	```C#
	private static void DeepCopyICloneable()
	{
		var p1 = new Student("Name 1", 21, new[] { 10, 10, 10 });
		Console.WriteLine();
		var p2 = p1.Clone();

		p1.Age = 12;
		p1.Marks[0] = 1;

		Console.WriteLine(p1);
		Console.WriteLine(p2);
	}
	```

5. Run the application and check the values in the two objects using the Watch window (run the application in Debug mode)

6. Change the implementation of the `Clone()` method in order to perform a **deep copy**

	```C#
	public object Clone()
	{
		// First get a shallow copy.
		var newPerson = (Student)MemberwiseClone();

		// Then fill in the gaps.
		newPerson.Marks = new int[Marks.Length];
		for (var i=0; i< Marks.Length; i++)
		{
			newPerson.Marks[i] = Marks[i];
		}
		//newPerson.Marks = (int[])Marks.Clone();

		return newPerson;
	}
	```
7. Change only the line in which you call the `Clone` method in the `DeepCopyICloneable` method as follows.

	```C#
	//Cast to base type
	var p2 = ((Person)p1).Clone();
	```
8. Run the application and check the values in the two objects. What happened? How would you fix the code? (hint: `virtual`).

##  7. <a name='Operators'></a>Operators
-   can be overload by defining static member functions using the operator keyword.
-   not all operators can be overloaded and others have restrictions
-   further reading: [link](https://msdn.microsoft.com/en-us/library/8edha89s(v=vs.140).aspx)

| Operators                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                        | Overloadability                                                                                                                                                                                                                      |
|------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------|--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------|
| [+](https://msdn.microsoft.com/en-us/library/k1a63xkz.aspx), [-](https://msdn.microsoft.com/en-us/library/wch5w409.aspx), [!](https://msdn.microsoft.com/en-us/library/f2kd6eb2.aspx), [\~](https://msdn.microsoft.com/en-us/library/d2bd4x66.aspx), [++](https://msdn.microsoft.com/en-us/library/36x43w8w.aspx), [--](https://msdn.microsoft.com/en-us/library/wc3z3k8c.aspx), [true](https://msdn.microsoft.com/en-us/library/eahhcxk2.aspx), [false](https://msdn.microsoft.com/en-us/library/67bxt5ee.aspx)                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                 | These unary operators can be overloaded.                                                                                                                                                                                             |
| [+](https://msdn.microsoft.com/en-us/library/k1a63xkz.aspx), [-](https://msdn.microsoft.com/en-us/library/wch5w409.aspx), [\*](https://msdn.microsoft.com/en-us/library/z19tbbca.aspx), [/](https://msdn.microsoft.com/en-us/library/3b1ff23f.aspx), [%](https://msdn.microsoft.com/en-us/library/0w4e0fzs.aspx), [&](https://msdn.microsoft.com/en-us/library/sbf85k1c.aspx), [\|](https://msdn.microsoft.com/en-us/library/kxszd0kx.aspx), [\^](https://msdn.microsoft.com/en-us/library/zkacc7k1.aspx), [\<\<](https://msdn.microsoft.com/en-us/library/a1sway8w.aspx), [\>\>](https://msdn.microsoft.com/en-us/library/xt18et0d.aspx)                                                                                                                                                                                                                                                                                                                                                                                                                        | These binary operators can be overloaded.                                                                                                                                                                                            |
| [==](https://msdn.microsoft.com/en-us/library/53k8ybth.aspx), [!=](https://msdn.microsoft.com/en-us/library/3tz250sf.aspx), [\<](https://msdn.microsoft.com/en-us/library/z5wecxwa.aspx), [\>](https://msdn.microsoft.com/en-us/library/yxk8751b.aspx), [\<=](https://msdn.microsoft.com/en-us/library/hx063734.aspx), [\>=](https://msdn.microsoft.com/en-us/library/a59bsyk4.aspx)                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                             | The comparison operators can be overloaded                                                                                                                                                                                           |
| [&&](https://msdn.microsoft.com/en-us/library/2a723cdk.aspx), [\|\|](https://msdn.microsoft.com/en-us/library/6373h346.aspx)                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                     | The conditional logical operators cannot be overloaded, but they are evaluated using & and \|, which can be overloaded.                                                                                                              |
| [[]](https://msdn.microsoft.com/en-us/library/a3hd7ste.aspx)                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                     | The array indexing operator cannot be overloaded, but you can define indexers.                                                                                                                                                       |
| [(T)x](https://msdn.microsoft.com/en-us/library/0z4503sa.aspx)                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                   | The cast operator cannot be overloaded, but you can define new conversion operators (see [explicit](https://msdn.microsoft.com/en-us/library/xhbhezf4.aspx) and [implicit](https://msdn.microsoft.com/en-us/library/z5z9kes2.aspx)). |
| [+=](https://msdn.microsoft.com/en-us/library/sa7629ew.aspx), [-=](https://msdn.microsoft.com/en-us/library/2y9zhhx1.aspx), [\*=](https://msdn.microsoft.com/en-us/library/s2bkaksf.aspx), [/=](https://msdn.microsoft.com/en-us/library/d31sybc9.aspx), [%=](https://msdn.microsoft.com/en-us/library/ydwa9zh0.aspx), [&=](https://msdn.microsoft.com/en-us/library/e669ax02.aspx), [\|=](https://msdn.microsoft.com/en-us/library/h5f1zzaw.aspx), [\^=](https://msdn.microsoft.com/en-us/library/0zbsw2z6.aspx), [\<\<=](https://msdn.microsoft.com/en-us/library/ayt2kcfb.aspx), [\>\>=](https://msdn.microsoft.com/en-us/library/23as4533.aspx)                                                                                                                                                                                                                                                                                                                                                                                                              | assignment operators cannot be overloaded, but +=, for example, is evaluated using +, which can be overloaded.                                                                                                                       |
| [=](https://msdn.microsoft.com/en-us/library/sbkb459w.aspx), [.](https://msdn.microsoft.com/en-us/library/6zhxzbds.aspx), [?:](https://msdn.microsoft.com/en-us/library/ty67wk28.aspx), [??](https://msdn.microsoft.com/en-us/library/ms173224.aspx), [-\>](https://msdn.microsoft.com/en-us/library/s8bz4d5h.aspx), [=\>](https://msdn.microsoft.com/en-us/library/bb311046.aspx), [f(x)](https://msdn.microsoft.com/en-us/library/0z4503sa.aspx), [as](https://msdn.microsoft.com/en-us/library/cscsdfbt.aspx), [checked](https://msdn.microsoft.com/en-us/library/74b4xzyw.aspx), [unchecked](https://msdn.microsoft.com/en-us/library/a569z7k8.aspx), [default](https://msdn.microsoft.com/en-us/library/xwth0h0d.aspx), [delegate](https://msdn.microsoft.com/en-us/library/0yw3tz5k.aspx), [is](https://msdn.microsoft.com/en-us/library/scekt9xw.aspx), [new](https://msdn.microsoft.com/en-us/library/51y09td4.aspx), [sizeof](https://msdn.microsoft.com/en-us/library/eahchzkf.aspx), [typeof](https://msdn.microsoft.com/en-us/library/58918ffs.aspx) | These operators cannot be overloaded.                                                                                                                                                                                                |

##### Activity

> :octocat: Sample code available – Check the “Operators” Sample 

1.  For the standard Person class overload the \>, \< and explicit (int) operators

	```C#
	#region Operators
	// operator de conversie explicita la int
	public static explicit operator int(Person p)
	{
		return p.Age;
	}

	public static bool operator <(Person p1, Person p2)
	{
		return p1.Age < p2.Age;
	}

	public static bool operator >(Person p1, Person p2)
	{
		return p1.Age > p2.Age;
	}
	#endregion
	```

2.  Use the operators in the `Main` method

	```C#
	private static void Main(string[] args)
	{
		var p = new Person("Name1", 21);
		var p2 = new Person("Name2", 22);

		//int age = p; //error
		int age = (int)p;
		Console.WriteLine("Age: {0}", age);

		if(p<p2)
			Console.WriteLine("p.Age < p2.Age");
	}
	```

3.  Implement the implicit (int) cast

##### Activity

1.  Add the following `Fraction` class
	```C#
	class Fraction
	{
		int num, den;
		public Fraction(int num, int den)
		{
			this.num = num;
			this.den = den;
		}

		// overload operator +
		public static Fraction operator +(Fraction a, Fraction b)
		{
			return new Fraction(a.num * b.den + b.num * a.den,
			a.den * b.den);
		}

		// overload operator *
		public static Fraction operator *(Fraction a, Fraction b)
		{
			return new Fraction(a.num * b.num, a.den * b.den);
		}

		// user-defined conversion from Fraction to double
		public static implicit operator double(Fraction f)
		{
			return (double)f.num / f.den;
		}
	}
	```

2.  Add the following method in the `Program` class and call it from the `Main()` method.
	```C#
	static void Main()
	{
		Fraction a = new Fraction(1, 2);
		Fraction b = new Fraction(3, 7);
		Fraction c = new Fraction(2, 3);
		Console.WriteLine((double)(a * b + c));
	}
	```

##  8. <a name='ClassInheritance'></a>Class Inheritance

###  8.1. <a name='Abstractclasses'></a>Abstract classes

![Figure 1 Class hierarchy](docs/2/inheritance.png)

##### Activity

Let’s imagine that you are asked to develop an application that handles the wage
and bonus calculations for the persons that work in a certain software
development company. The categories of persons are: Software Developer,
Managers.

> :octocat: Sample code available – Check the "Inheritance" Sample 

1.  Create a new project that will include the classes shown in Figure 1.

2.  Add an abstract Person class (keep in mind that we only consider the three types of person categories mentioned above)

	```C#
	internal abstract class Person
	{
		public string Name { get; set; }

		public Person(string name)
		{
			Name = name;
		}
	}
	```

3.  Add an abstract `Employee` class

	> Hint: You can generate the constructor of the `Employee` class by clicking on `Person` and choosing the corresponding option from the contextual menu.

	```C#
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
	```

4.  Add a SoftwareDeveloper class

	```C#
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
	```

5.  Add the following method to the “Program” class and call it from the “Main()” method. Inside the method declare a SoftwareDeveloper object and
    call the CalculateBonusAbstract, CalculateBonusNormal and CalculateBonusVirtual

	```C#
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
	```

6.  In the previous method declare an array of `Employee[]` and call the previously mentioned methods

###  8.2. <a name='CustomInterfaces'></a>Custom Interfaces

##### Activity

Let’s imagine that the company starts to work with external contractors. You are required to add this category of persons to the previously developed application. Moreover, the management is interested to quickly find what programming languages a Software Developers or Contractor knows.

1.  Add the `Contractor` class

	```C#
	internal class Contractor : Person
	{		

	}
	```

2.  Add the `IDeveloper` interface

	```C#
	internal interface IDeveloper
	{
		string[] Languages { get; set; }
		bool Knows(string language);
	}
	```

3.  Derive the `SoftwareDevloper` and `Contractor` classes from the `IDeveloper` interface

4.  Add a new method to the `Program` class and call it from the `Main()` method. Inside the method define an array of persons and populate it with the three categories of persons in the company (SofwareDeveloper, Manager, Contractor).

5.  In the previous method iterate the list of persons and display the known programming languages for each person

6.  Search for all the persons that know “C\#”.

##  9. <a name='Bibliography'></a>Bibliography
