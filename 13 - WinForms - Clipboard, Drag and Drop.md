# Windows Forms – Clipboard, Drag and Drop
<!-- vscode-markdown-toc -->
* 1. [Objectives](#Objectives)
* 2. [Clipboard](#Clipboard)
* 3. [Drag and Drop](#DragandDrop)
* 4. [Bibliography](#Bibliography)

<!-- vscode-markdown-toc-config
	numbering=true
	autoSave=true
	/vscode-markdown-toc-config -->
<!-- /vscode-markdown-toc -->

##  1. <a name='Objectives'></a>Objectives

##  2. <a name='Clipboard'></a>Clipboard
**Documentation**
> https://docs.microsoft.com/en-us/dotnet/framework/winforms/advanced/how-to-retrieve-data-from-the-clipboard

**Activity**

> :octocat: Sample Code available – Check the "ClipboardSample" Sample 

##  3. <a name='DragandDrop'></a>Drag and Drop
**Documentation**
> https://docs.microsoft.com/en-us/dotnet/framework/winforms/drag-and-drop-functionality-in-windows-forms

**Activity**

> :octocat: Sample Code available – Check the “DragDropSample” Sample 

1. Create a new project with the name “DragDropSample”
2. Create the UI shown below  
![Drag and Drop](docs/9/drag-and-drop.jpg)
3. Set the “AllowDrop” property of the ListView to true  
![AllowDrop Property True](docs/9/allowdrop-property.jpg)
4. Handle the `MouseDown` event for the `TextBox` as follows:
	
	```c#
	textBox1.DoDragDrop(textBox1.Text, DragDropEffects.Copy);
	```
5. Handle the `DragEnter` event for the ListView as follows:

	```c#
	// Display some information about the DragDrop information in the
	// richTextBox1 control to show some of the information available.
	richTextBox1.Text = "Allowed Effect: " + e.AllowedEffect +
	"\r\nAvailable Formats:\r\n";
	
	// Data may be available in more than one format, so loop through
	// all available formats and display them in richTextBox1.
	foreach (string availableFormat in e.Data.GetFormats(true))
	{
		richTextBox1.Text += "\t" + availableFormat + "\r\n";
	}
	
	// This control will use any dropped data to add items to the listbox.
	// Therefore, only data in a text format will be allowed. Setting the
	// autoConvert parameter to true specifies that any data that can be
	// converted to a text format is also acceptable.
	if (e.Data.GetDataPresent(DataFormats.Text, true))
	{
		// Some controls in this sample allow both Copy and Move effects.
		// If a Move effect is allowed, this implementation assumes a Move
		// effect unless the CTRL key was pressed, in which case a Copy
		// effect is assumed. This follows standard DragDrop conventions.
		if ((e.AllowedEffect & DragDropEffects.Move) == DragDropEffects.Move && (e.KeyState & CtrlKey) != CtrlKey)
		{
			// Show the standard Move icon.
			e.Effect = DragDropEffects.Move;
		}
		else
		{
			// Show the standard Copy icon.
			e.Effect = DragDropEffects.Copy;
		}
	}
	```
6. Handle the “DragDrop” event for the ListView as follows:
	
	```c#
	/// <summary>
	/// The DragDrop event of the target control fires when a drop actually occurs over
	/// the target control. This is where the data being dragged is actually processed.
	///
	/// This event will fire only if the AllowDrop property of the target control has
	/// been set to true.
	/// </summary>
	/// <param name="sender">The source of the event.</param>
	/// <param name="e">A DragEventArgs that contains the event data.</param>
	private void listBox1_DragDrop(object sender, DragEventArgs e)
	{
		if (e.Data.GetDataPresent(DataFormats.Text, true))
		{
			// Create the list item using the data provided by the source control.
			listBox1.Items.Add(e.Data.GetData(DataFormats.Text));
		}
	}
	```

##  4. <a name='Bibliography'></a>Bibliography
- Clipboard: https://docs.microsoft.com/en-us/dotnet/framework/winforms/advanced/how-to-retrieve-data-from-the-clipboard
- Drag and Drop: https://docs.microsoft.com/en-us/dotnet/framework/winforms/drag-and-drop-functionality-in-windows-forms
