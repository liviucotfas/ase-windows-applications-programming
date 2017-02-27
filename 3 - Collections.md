Collections
===========
##Table of Contents
- [ArrayList](#arraylist)
- [List\<T\>](#listt)
- [Queues, Stacks, and Sets](#queues,-stacks,-and-sets)
- [Custom Collections](#custom-collections)


| ![./media/image1.png](./media/image1.png) | Sample code available – Check the “StandardCollections” Sample |
|------------------------------------------|--------------------------------------------------------------------------------|

##  ArrayList
#### Assignment
1.  Create a new project with the name “StandardCollections”
2.  Add the following method in the “Program” class and call it from the Main
    method

	```C#
	 private static void ArrayListExample()
	{
		var words = new ArrayList();
		words.Add("melon");
		words.Add("avocado");
		string first = (string)words[0];

		//int first = (int)words[0];
	}
	```
## List\<T\>

3.  Add the following method in the “Program” class and call it from the Main method

	```C#
	private static void ListExample()
	{
		// New string-typed list
		var words = new List<string>();
		words.Add("melon");
		words.Add("avocado");
		words.AddRange(new[] { "banana", "plum" });
		
		// Insert at start
		words.Insert(0, "lemon"); 
		
		// Insert at start
		words.InsertRange(0, new[] { "peach", "nashi" }); 
		words.Remove("melon");
		
		// Remove the 4th element
		words.RemoveAt(3); 
		
		// Remove first 2 elements
		words.RemoveRange(0, 2);
		
		// Remove all strings starting in 'n':
		words.RemoveAll(x => x.StartsWith("n"));
		
		for (var i=0; i<words.Count; i++)
		{
			Console.WriteLine(words[i]);
		}

		foreach (var word in words)
		{
			Console.WriteLine(word);
		}
	}
	```

4.  Add the following “Person” class

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
5.  Add the following method in the “Program” class and call it from the Main     method

	```C#
	private static void ListPersonExample()
	{
		var personList = new List<Person>();

		var rnd = new Random();
		for (var i = 0; i < 10; i++)
		{
			personList.Add(new Person("Persoana " + i, rnd.Next(100)));
		}

		//Which interface is needed for Array.Sort(personList)

		foreach (var p in personList) //equivalent to foreach (var p in personList)
			Console.WriteLine(p);
	}
	```

## Queues, Stacks, and Sets

-   [Queue](https://msdn.microsoft.com/en-us/library/system.collections.queue(v=vs.110).aspx)
    ,
    [Stack\<T\>](https://msdn.microsoft.com/en-us/library/3278tedw(v=vs.110).aspx),
    [LinkedList\<T\>](https://msdn.microsoft.com/en-us/library/he2s3bh7(v=vs.110).aspx)

-   [SortedList\<TKey, TValue\>](https://msdn.microsoft.com/en-us/library/ms132319.aspx)
    and many others:
    [link](https://msdn.microsoft.com/en-us/library/mt481475(v=vs.110).aspx)

##  Custom Collections

| ![./media/image1.png](./media/image1.png) | Sample code available – Check the “CustomCollections” Sample |
|------------------------------------------|------------------------------------------------------------------------------|

#### Assignment

1.  Add the following “PersonCollection” class
	```C#
	internal class PersonCollection :IEnumerable<Person>
	{
		private Person[] _personArray;

		//Indexer [int]
		public Person this[int index]
		{
			get { return _personArray[index]; }
			set { _personArray[index] = value; }
		}

		//Indexer [string]
		public Person this[string name]
		{
			get { return _personArray.FirstOrDefault(x=>x.Name == name); }
		}

		public int Length
		{
			get { return _personArray.Length; }
		}

		public PersonCollection()
		{
			_personArray = new []
			{
				new Person("name1", 1),
				new Person("name2", 2),
				new Person("name3", 3)
			};
		}
		
		public IEnumerator<Person> GetEnumerator()
		{
			return new PersonEnumerator(this);
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}
	}
	```
2.  Add the following “PersonEnumerator” class
	```C#
	internal class PersonEnumerator : IEnumerator<Person>
	{
		private int _nIndex;
		private PersonCollection _personCollection;

		public PersonEnumerator(PersonCollection personCollection)
		{
			_personCollection = personCollection;
			_nIndex = -1;
		}

		public bool MoveNext()
		{
			_nIndex++;
			return _nIndex < _personCollection.Length;
		}

		public void Reset()
		{
			_nIndex = -1;
		}

		public Person Current
		{
			get { return _personCollection[_nIndex]; }
		}

		object IEnumerator.Current
		{
			get { return Current; }
		}

		public void Dispose()
		{
			
		}
	}
	```
3.  Add the following method in the “Program” class and call it from the Main method

	```C#
	private static void PersonCollectionExample()
	{
		var personList = new PersonCollection();

		foreach (var p in personList)
			Console.WriteLine(p);
	}
	```
