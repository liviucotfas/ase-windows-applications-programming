# Windows Forms – Serialization, Text Files
## Contents


 1. [Binary Serialization](#binary-serialization)
 2. [XML Serialization](#xml-serialization)
 3. [TextFiles](#text-files)

## <a name="serialization-deserialization"></a> 1. Serialization/Deserialization

##### Activity

![](media/image1.png) Sample code available at <http://online.ase.ro> – “SerializationBinaryXMLTextFile” Sample

1.  Create a copy of the “ListViewBasicSample” project and name it “SerializationBinaryXMLTextFile”

2.  Create the following UI

![UI Binary Serialization](docs/7/ui-binary.png)

### <a name="binary-serialization"></a> 1.1. Binary Serialization

3. Add a menu for “Binary Serialization” (“Serialize” - btnSerializeBinary, “Deserialize” - btnDeserializeBinary), “XML Serialization” (“Serialize” - btnSerializeXML, “Deserialize” - btnDeserializeXML) and “TextFile” (“Export” – btnExport). 

4. Decorate the “Participant” class with the [Serializable] attribute, as follows. Un exception will be thrown otherwise.

```c#
[Serializable]
internal class Participant
{
  …………………
```
     	
5.  Handle the “Click” event for the “btnSerializeBinary” button as follows

```c#
private void btnSerialize_Click(object sender, EventArgs e){
      BinaryFormatter formatter = new BinaryFormatter();
      using (FileStream s = File.Create("serialized.bin"))
            formatter.Serialize(s, _participants);
}
```
     	     	
6. Remove the **readonly** modifier from the declaration of the “_participants” attribute in the “MainForm” class. The project will not compile otherwise.

7. Handle the “Click” event for the “btnDeserializeBinary” button as follows

```C#
private void btnDeserialize_Click(object sender, EventArgs e){
      BinaryFormatter formatter = new BinaryFormatter();
      using (FileStream s = File.OpenRead("serialized.bin"))	{
            _participants = (List<Participant>)formatter.Deserialize(s);
            DisplayParticipants();
      }
}
```

### <a name="xml-serialization"></a> 1.2. XML Serialization

8. Add a parameterless constructor to the “Participant” class. Change the access modifier for the class from “internal” to “public”. Un exception will be thrown otherwise.

9. Handle the “Click” event for the “btnSerializeXML” button as follows.

```C#
XmlSerializer serializer = new XmlSerializer(typeof(List<Participant>));
using (StreamWriter writer = new StreamWriter("SerializedXML.xml"))
{
      serializer.Serialize(writer, _participants);
}
```

10. Handle the “Click” event for the “btnDeserializeXML” button as follows.

```C#
XmlSerializer serializer = new XmlSerializer(typeof(List<Participant>));

using (StreamReader streamReader = new StreamReader("SerializedXML.xml"))
{
      _participants = (List<Participant>)serializer.Deserialize(streamReader);
      DisplayParticipants();
}
```

### <a name="text-files"></a> 1.3. TextFiles

11. Handle the “Click” event for the “btnExport” button as follows

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
	// generates the try{} finally{} in Version 1
	using (StreamWriter sw = new StreamWriter(saveFileDialog.FileName))
	{
		sw.WriteLine("LastName,FirstName,BirthDate");

		foreach (var participant in _participants)
		{
			sw.WriteLine("{0}, {1}, {2}"
				, participant.LastName
				, participant.FirstName
				, participant.BirthDate.ToShortDateString());
		}
	}
}
```

##### Activity

![](media/image1.png) Sample code available at <http://online.ase.ro> – “TextFileSample” Sample

```c#
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
##### Homework
1. Modify the project in order to automatically serialize the current list of participants when the application is closed. The list should be automatically deserialized and displayed when the application starts. The application should not throw an exception if the serialization file has been deleted in the mean time.
2. Add the option to import new participants from a *.csv or *.txt file selected using an OpenFileDialog. The participants imported from the text file should be added to the list of existing participants in the application. Note: The *csv file can be created using either any text editor or using Excel
