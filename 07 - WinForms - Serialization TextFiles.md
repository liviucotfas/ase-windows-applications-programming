# Windows Forms – Serialization, Text Files

<!-- vscode-markdown-toc -->
* 1. [Objectives](#Objectives)
* 2. [Serialization/Deserialization](#SerializationDeserialization)
	* 2.1. [JSON Serialization](#JSONSerialization)
	* 2.2. [XML Serialization](#XMLSerialization)
* 3. [ TextFiles](#TextFiles)
* 4. [Bibliography](#Bibliography)

<!-- vscode-markdown-toc-config
	numbering=true
	autoSave=true
	/vscode-markdown-toc-config -->
<!-- /vscode-markdown-toc -->

##  1. <a name='Objectives'></a>Objectives
- implement `JSON` serialization / deserialization;
- implement `XML` serialization / deserialization;
- understand the differences between the `XML` and `JSON` serializations;
- writing to text files;
- uising the `OpenFileDialog` and the `SaveFileDialog`.

	> In the past, binary serialization was also used. This was however deprecated as of .NET 8

##  2. <a name='SerializationDeserialization'></a>Serialization/Deserialization

**Documentation**
- Serialization in .NET: <https://docs.microsoft.com/en-us/dotnet/standard/serialization/>

**Activity**
> :octocat: The complete sample is available in the "code samples" folder:  “SerializationJSONXMLTextFile”

1.  Create a copy of the “ListViewBasicSample” project and name it “SerializationJSONXMLTextFile”

2.  Create the following UI

	![UI JSON Serialization](docs/7/ui-binary.png)

###  2.1. <a name='JSONSerialization'></a>JSON Serialization
	> JSON is a data interchange format used as an industry standard. JSON stands for "JavaScript Object Notation" and the name comes from the syntax it uses, which is inspired by the way objects are declared in JavaScript. It stores data in a structured way using key-value pairs. Keys (also called properties) are always strings, whereas values can be numbers, strings, booleans, arrays or objects. 

3. Add a menu for JSON Serialization” (“Serialize” - `btnSerializeJSON`, “Deserialize” - `btnDeserializeJSON`), “XML Serialization” (“Serialize” - `btnSerializeXML`, “Deserialize” - `btnDeserializeXML`) and “TextFile” (“Export” – `btnExport`). 

4. Install the `System.Text.Json` package from the NuGet package manager.
	> Note that you need to include the reference to the package in the files where you aim to use the `JsonSerializer` class.

5.  Handle the `Click` event for the `btnSerializeJSON` button as follows

	```c#
	private void btnSerialize_Click(object sender, EventArgs e){
		var json = JsonSerializer.Serialize(_participants);

		using (StreamWriter sw = new StreamWriter(File.Create("serialized.json")))
		{
			sw.WriteLine(json);
		}
	}
	```

6. Check what happens when the `using` statement is compiled.  
   > `using` statement: https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/using-statement
     	     	
7. Handle the `Click` event for the `btnDeserializeJSON` button as follows

	```C#
	private void btnDeserialize_Click(object sender, EventArgs e){
		using (StreamReader sr = new StreamReader(File.OpenRead("serialized.json")))
		{
			var json = sr.ReadToEnd();
			_participants = JsonSerializer.Deserialize<List<Participant>>(json);
			DisplayParticipants();
		}
	}
	```

**Assignments (for you to try)**
1. Modify the project in order to automatically serialize the current list of participants when the application is closed. The list should be automatically deserialized and displayed when the application starts. The application should not throw an exception if the serialization file has been deleted in the mean time.

###  2.2. <a name='XMLSerialization'></a>XML Serialization

8. Add a parameterless constructor to the `Participant` class. Change the access modifier for the class from `internal` to `public`. An exception will be thrown otherwise.

9. Handle the `Click` event for the `btnSerializeXML` button as follows.

	```C#
	XmlSerializer serializer = new XmlSerializer(typeof(List<Participant>));

	using (FileStream stream = File.Create("SerializedXML.xml"))
		serializer.Serialize(stream, _participants);
	```

10. Handle the `Click` event for the `btnDeserializeXML` button as follows.

	```C#
	XmlSerializer serializer = new XmlSerializer(typeof(List<Participant>));
	
	using (FileStream stream = File.OpenRead("SerializedXML.xml"))
	{
		_participants = (List<Participant>)serializer.Deserialize(stream);
		DisplayParticipants();
	}
	```

**Assignments (for you to try)**
1. Also implement JSON serialization using the alternative NuGet package available at: https://www.nuget.org/packages/Newtonsoft.Json/ . This package is often used for legacy projects. For new projects try to use the `System.Text.Json` package.
2. Add at least 10 entries in the application. Serialize the data in Binary, XML and JSON format. Compare the sizes of the resulting files. Open the files using Notepad (or any other text editor) and compare their content. 


##  3. <a name='TextFiles'></a> TextFiles

11. Handle the `Click` event for the `btnExport` button as follows

	> Further details about the CSV file format: https://en.wikipedia.org/wiki/Comma-separated_values

	```c#
	// Create an instance of the open file dialog box.
	SaveFileDialog saveFileDialog = new SaveFileDialog();
	saveFileDialog.Filter = "Text File | *.txt";
	saveFileDialog.Title = "Save as text file";

	if (saveFileDialog.ShowDialog() == DialogResult.OK)
	{
		//Approach 1
		//StreamWriter sw = new StreamWriter(saveFileDialog.FileName);
		//try
		//{
		//	sw.WriteLine("LastName,FirstName,BirthDate");

		//	foreach (var participant in _participants)
		//	{
		//		sw.WriteLine("{0}, {1}, {2}"
		//			, participant.LastName
		//			, participant.FirstName
		//			, participant.BirthDate.ToShortDateString());
		//	}
		//}
		//finally
		//{
		//	sw.Dispose();
		//}

		//2. Approach 2 - recommended
		// When compiled, this code in this approach is converted to: try{} finally{}
		using (StreamWriter sw = File.CreateText(saveFileDialog.FileName))
		// Equivalent to:
		// using (StreamWriter sw = new StreamWriter(saveFileDialog.FileName))
		{
			sw.WriteLine("LastName,FirstName,BirthDate");

			foreach (var participant in _participants)
			{
				sw.WriteLine("\"{0}\", \"{1}\", \"{2}\""
                            , participant.LastName.Replace("\"", "\"\"")
							, participant.FirstName.Replace("\"", "\"\"")
                            , participant.BirthDate.ToShortDateString());
			}
		}
	}
	```
**Assignments (for you to try)**
1. Also allow the user the save the file using the *.csv file format.
   > `SaveFileDialog`: https://docs.microsoft.com/en-us/dotnet/api/system.windows.forms.savefiledialog
2. Add the option to import new participants from a *.csv or *.txt file selected using an OpenFileDialog. The participants imported from the text file should be added to the list of existing participants in the application. Note: The *csv file can be created using either any text editor or using Excel


**Activity**

> :octocat: The complete sample is available in the "code samples" folder: “TextFileSample”

1. Check the following application that is writting the names of all the directories in the `C:` drive to a text file 

	```C#
	static void Main(string[] args)
	{
		// Get the directories currently on the C drive.
		DirectoryInfo[] cDirs = new DirectoryInfo(@"c:\").GetDirectories();

		// Write each directory name to a file.
		using (StreamWriter sw = new StreamWriter("CDriveDirs.txt"))
		{
			foreach (DirectoryInfo dir in cDirs)
			{
				sw.WriteLine(dir.Name);
			}
		}

		// Read and show each line from the file.
		string line = "";
		using (StreamReader sr = new StreamReader("CDriveDirs.txt"))
		{
			while ((line = sr.ReadLine()) != null)
			{
				Console.WriteLine(line);
			}
		}
	}
	```
**Activity**
1. Try to implement an application similar to the `Windows Folder Organizer` available in the `Microsoft Store`.
 
##  4. <a name='Bibliography'></a>Bibliography
- https://docs.microsoft.com/en-us/dotnet/standard/serialization/
