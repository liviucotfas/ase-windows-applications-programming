# Windows Forms – Clipboard

**Activity**

![C#](media/image1.png) Sample Code available at <http://online.ase.ro> – “ClipboardSample” Sample

1. Create a new project with the name “ClipboardSample”
2. Create the following UI:  
![Clipboard UI Example](docs/8/clipboard-ui-example.jpg)
3. Handle the Click event on the “Copy Text” button as follows:    
	
	```c#
	//Copy text from text box onto the clipboard
	Clipboard.SetText(tbCopy.Text);
	```
4. Handle the Click event on the “Paste Text” button as follows:
	
	```c#
	//If clipboard has text, paste it into the text box
	if (Clipboard.ContainsText())
	{
		tbPaste.Text = Clipboard.GetText();
	}
	else
	{
		MessageBox.Show("Clipboard does not contain any text");
	}
	```
5. Check the rest of the sample online
