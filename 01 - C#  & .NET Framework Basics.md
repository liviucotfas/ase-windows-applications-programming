# C# & .NET Framework Basics

<!-- vscode-markdown-toc -->
* 1. [Objectives](#Objectives)
* 2. [Introduction](#Introduction)
* 3. [First C# Program](#FirstCProgram)
* 4. [Reading and Writing using System.Console](#ReadingandWritingusingSystem.Console)
* 5. [Specifying an Application Error Code](#SpecifyinganApplicationErrorCode)
* 6. [Processing Command-Line Arguments](#ProcessingCommand-LineArguments)
* 7. [Data Types](#DataTypes)
	* 7.1. [Value types](#Valuetypes)
	* 7.2. [Reference types](#Referencetypes)
	* 7.3. [Implicitly Typed Local Variables](#ImplicitlyTypedLocalVariables)
* 8. [Working with Strings](#WorkingwithStrings)
	* 8.1. [Immutable](#Immutable)
	* 8.2. [operator==](#operator)
	* 8.3. [StringBuilder](#StringBuilder)
* 9. [Arrays](#Arrays)
	* 9.1. [Default Element Initialization](#DefaultElementInitialization)
	* 9.2. [Multidimensional Arrays](#MultidimensionalArrays)
		* 9.2.1. [Rectangular arrays](#Rectangulararrays)
		* 9.2.2. [Jagged arrays](#Jaggedarrays)
* 10. [Bibliography](#Bibliography)

<!-- vscode-markdown-toc-config
	numbering=true
	autoSave=true
	/vscode-markdown-toc-config -->
<!-- /vscode-markdown-toc -->

##  1. <a name='Objectives'></a>Objectives
- understand the basic structure of a `Console` application
- decompile a .NET application
- read and write information from/to the `Console`

##  2. <a name='Introduction'></a>Introduction

* API Browser: https://docs.microsoft.com/en-us/dotnet/api/?view=netframework-4.7.1
* Official Samples: https://code.msdn.microsoft.com
##  3. <a name='FirstCProgram'></a>First C# Program
Every C# application must contain a single Main method specifying where program execution should begin.
Observations:
* in C#, Main is capitalized, while Java uses lowercase main;
* note the static modifier which has a similar behavior to C++.

##### Activity: 
1.	create a new Microsoft .NET Project in Visual Studio;
2.	add the following code.
	```C#
	using System; //referenced namespace

	namespace NameSpaceProgram 
	{
		internal class Program
		{
			private static void Main(string[] args)
			{
				//HelloWorld application
				Console.WriteLine("Hello World!");
				Console.ReadLine();
			} //end main
		}//end class
	} //end namespace
	```
##### Activity: 
1.	download dotPeak from https://www.jetbrains.com/decompiler/;
2.	decompile the HelloWorld application.

##  4. <a name='ReadingandWritingusingSystem.Console'></a>Reading and Writing using System.Console
Documentation: https://docs.microsoft.com/en-us/dotnet/api/system.console

Frequently used methods:
-	`Write` / `WriteLine`;
-	`Read` / `ReadLine`.

Formatting Console Output:
```C#
int foo = 10;
int bar = 20;
//String concatenation:
Console.WriteLine("foo: " + foo + " bar: "+ bar);
//Composite formatting:
Console.WriteLine("foo: {0} bar: {1}", foo, bar);
Console.WriteLine("{1}, {0}, {2}", 10, 20, 30);
//String interpolation: https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/tokens/interpolated
Console.WriteLine($"{foo}{bar}");
//Format
Console.WriteLine("c format: {0:c}", foo);
```

##  5. <a name='SpecifyinganApplicationErrorCode'></a>Specifying an Application Error Code
the Main() method can only return int or void;

**Activity:**
1.	Replace the code from the previous activity with the following one.

	```C#
	static int Main(string[] args)
	{
		Console.WriteLine("Hello World!");
		Console.ReadLine();
		// Return an arbitrary error code.
		return -1;
	}
	```
2. Create the following `batch` script and call it from the `Console`
	```
	@echo off

	NameofYourApp 

	@if "%ERRORLEVEL%" == "0" goto success
	:fail
	echo This application has failed!
	echo return value = %ERRORLEVEL%
	goto end
	:success
	echo This application has succeeded!
	echo return value = %ERRORLEVEL%
	goto end
	:end
	echo All Done.
	```
##  6. <a name='ProcessingCommand-LineArguments'></a>Processing Command-Line Arguments
the Main() method has an optional string array argument to represent command-line parameters.
##### Activity:
1. replace the code from the previous activity with the following one.

	```C#
	public static void Main(string[] args)
	{
		foreach (string arg in args)
		{
			Console.WriteLine("Argument: {0}", arg);
		}
	}
	```
2. Run the application using the `Console` as follows.
	```
	NameofYourApp.exe /arg1 -arg2
	```

##  7. <a name='DataTypes'></a>Data Types
![Data Types](docs/1/datatypes.png)

Some of these types have shorthand defined in C#, as shown in the following table.

![Data Types](docs/1/datatypes2.png)

###  7.1. <a name='Valuetypes'></a>Value types
-	structure, enum, primitive types (derived from System.ValueType)
-	allocated: on the stack;
-	lifetime: can be created and destroyed very quickly, as its lifetime is determined by the defining scope;

###  7.2. <a name='Referencetypes'></a>Reference types
-	class, delegate, interface
-	allocated: in the heap;
-	lifetime: has a lifetime that is determined by a large number of factors


Table Comparison between value types and reference types

|                                                  | Value type                                                                                            | Reference Type                                                                                         |
|--------------------------------------------------|-------------------------------------------------------------------------------------------------------|--------------------------------------------------------------------------------------------------------|
| Where are objects allocated?                     | Allocated on the stack.                                                                               | Allocated on the managed heap.                                                                         |
| How is a variable represented?                   | Value type variables are local copies.                                                                | Reference type variables are pointing to the memory occupied by the allocated instance.                |
| What is the base type?                           | Implicitly extends System.ValueType.                                                                  | Can derive from any other type (except System.ValueType), as long as that type is not “sealed”.        |
| Can this type function as a base to other types? | No. Value types are always sealed and cannot be inherited from.                                       | Yes. If the type is not sealed, it may function as a base to other types.                              |
| Default parameter passing behavior               | Variables are passed by value (i.e., a copy of the variable is passed into the called function).      | For value types, the object is copied-by-value. For reference types, the reference is copied-by-value. |
| Own constructor for this type                    | Yes, but the default constructor is reserved (i.e., the custom constructors must all have arguments). | Yes                                                                                                    |
| When do variables of this type die?              | When they fall out of the defining scope.                                                             | When the object is garbage collected.                                                                  |

##### Activity:
1. Add the following method to the program in the previous activity;

	```C#
	private static void SystemDataTypes()
	{
		Console.Write("First Name: ");

		//declare the variable
		//string firstName;
		//store the input from the keyboard
		//firstName = Console.ReadLine();

		//written more concisely
		string firstName = Console.ReadLine();

		Console.WriteLine("");

		DateTime currentTime = DateTime.Now;

		//{0} and {1} are replaced with the arguments
		//Console.WriteLine(string.Format("Hello {0}! Today is {1}.", firstName, DateTime.Now));
		//written more concisely
		Console.WriteLine("Hello {0}! Today is {1}.", firstName, currentTime);

		Console.ReadLine();
	}
	```

2.  Call it from the Main method.

###  7.3. <a name='ImplicitlyTypedLocalVariables'></a>Implicitly Typed Local Variables

Local variables can be given an inferred "type" of **var** instead of an
explicit type. The var keyword instructs the compiler to infer the type of the
variable from the expression on the right side of the initialization statement.

> Documentation: <https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/implicitly-typed-local-variables>

**Activity:**

-   Use **var** for variable declarations instead of **string** or **DateTime**
    in the previous activity.

##  8. <a name='WorkingwithStrings'></a>Working with Strings

###  8.1. <a name='Immutable'></a>Immutable

-   Strings are **immutable:** after the initial value is assigned to a string
    object, the character data cannot be changed. A brand new string is created
    each time we modify the initial string.

##### Activity:

```C#
internal class Program
{
	private static void Main(string[] args)
	{
		//Ex1
		string s1 = "abc";
		string s2 = s1;
		s1=s1.Replace("abc", "ba");
		Console.WriteLine(s1);
		Console.WriteLine(s2);

		//Ex2
		String s3 = "abc";
		String s4 = s3;
		s3 += "d";
		Console.WriteLine(s3);
		Console.WriteLine(s4);

	/*Strings are immutable--the contents of a string object cannot be changed after the object is created, although the syntax makes it appear as if you can do this. */
	}
}
```

###  8.2. <a name='operator'></a>operator==
- The **operator==** is overloaded.

##### Activity:

```C#
using System;
using System.Text;

namespace ExempluString
{
	internal class Program
	{
		private static void Main(string[] args)
		{
			//2. Operator==
			string a = "hello";
			
			string b = "h";
			// Append to contents of 'b'
			b += "ello";
			
			Console.WriteLine(a == b); //will return true because operator== is overloaded
			Console.WriteLine((object)a == b);	//will return false because the objects are different
	
		}
	}
}
```

###  8.3. <a name='StringBuilder'></a>StringBuilder

For routines that perform extensive string manipulation (such as apps that modify a string numerous times in a loop), modifying a string repeatedly can exact a significant performance penalty. The alternative is to use StringBuilder, which is a mutable string class. Mutability means that once an instance of the class has been created, it can be modified by appending, removing, replacing, or inserting characters.

Usage example: email containing phone logs or calendar entries, text based reports

Documentation:
<https://msdn.microsoft.com/en-us/library/system.text.stringbuilder%28v=vs.110%29.aspx>

##### Activity

-   Compare the time required to perform the same operation using System.String
    and System.Text.StringBuilder

```C#
private static void StringBuilderPerformance()
{
	Console.WriteLine("###StringBuilderPerformance");

	const int noOfRepetitions = 50000;

	var regularString = string.Empty;

	// For a more precise measurement, use a performance counter instead of a Stopwatch
	var watch = Stopwatch.StartNew();
	for (var i = 0; i < noOfRepetitions; i++)
	{
		regularString += "a";
	}
	watch.Stop();
	var elapsedMs = watch.ElapsedMilliseconds;

	Console.WriteLine("Using System.String: {0}ms", elapsedMs);

	var stringBuilder = new StringBuilder();

	watch = Stopwatch.StartNew();
	for (var i = 0; i < noOfRepetitions; i++)
	{
		stringBuilder.Append("a");
	}
	regularString = stringBuilder.ToString();
	watch.Stop();
	elapsedMs = watch.ElapsedMilliseconds;

	Console.WriteLine("Using System.Text.StringBuilder: {0}ms", elapsedMs);

	Console.ReadLine();
} 
```

1.  Check the “StartNew “ method in the source code for the “Stopwatch” class:
    http://referencesource.microsoft.com/\#System/services/monitoring/system/diagnosticts/Stopwatch.cs,ceb0ba9cc88de82e

##  9. <a name='Arrays'></a>Arrays

An array represents a fixed number of variables (called elements) of a particular type. The elements in an array are always stored in a contiguous block of memory, providing highly efficient access. All arrays inherit from the **System.Array** class, providing common services for all arrays.

Some of the most important properties and methods:

-   *Length*: the number of elements in an array;

-   *GetLength(dim)*: gets a 32-bit integer that represents the number of
    elements in the specified dimension of the Array;

-   *Rank*: gets the rank (number of dimensions) of the Array. For example, a
    one-dimensional array returns 1, a two-dimensional array returns 2, and so
    on.;

-   **Clone():** Creates a shallow copy of the Array (note that System.Array
    implements ICloneable);

-   *and many others…*

Questions

-   Which is the base class for System.Array?

###  9.1. <a name='DefaultElementInitialization'></a>Default Element Initialization

Creating an array always preinitializes the elements with default values:

-   **null** for reference types;

-   **0** for numeric types;

-   Etc.

##### Activity
```C#
private void Array()
{
	//1. Declaration and assignment
	//declaration
	int[] intArray;

	// allocation
	intArray = new int[3]; //all values will be 0

	// declaration and assignment
	//var doubleArray = new double[]{ 34.23, 23.2 };
	var doubleArray = new[] { 34.23, 10.2, 23.2 }; //data type (double) is inferred

	//2. Accessing elements
	var arrayElement = doubleArray[0];
	doubleArray[1] = 5.55;

	// for
	for (var i = 0; i < intArray.Length; i++)
		Console.WriteLine(intArray[i]);

	// foreach
	foreach (var value in doubleArray)
		Console.WriteLine(value);

	//3. Other methods
	Array.Sort(doubleArray); //Note: double implements IComparable<double>

	// for
	for (var i = 0; i < doubleArray.Length; i++)
		Console.WriteLine("doubleArray[{0}]={1}", i, doubleArray[i]);
}
```

Questions

-   What kind of method is **Sort()** // what modifiers do you expect it to have

###  9.2. <a name='MultidimensionalArrays'></a>Multidimensional Arrays

####  9.2.1. <a name='Rectangulararrays'></a>Rectangular arrays

Rectangular arrays are declared using commas to separate each dimension (ex: [dim1, dim2, …, dimn]).

##### Activity

```C#
private void RectangularArray()
{
	// declaration and allocation
	var cub = new int[5, 2, 7];

	// declaration and assignment
	var matrix = new[,]{
			{ 4, 23,  5,  2 },
			{ 1,  6, 13, 29 }
		};

	// for
	for (var i = 0; i < matrix.GetLength(0); i++)
	{
		for (var j = 0; j < matrix.GetLength(1); j++)
			Console.Write(" {0}", matrix[i, j]);
		Console.WriteLine();
	}
}
```

####  9.2.2. <a name='Jaggedarrays'></a>Jagged arrays

Jagged arrays are declared using successive square brackets to represent each dimension.

```C#
private void JaggedArray()
{
	int[][] jaggedArray =
	{
		new int[] {0, 1, 2},
		new int[] {3, 4},
		new int[] {6, 7, 8, 9}
	};
}
```

##### Activity

1.  Write the code needed for displaying `jaggedArray` in the Console


##  10. <a name='Bibliography'></a>Bibliography
