# Windows Forms – Introduction, Menus, Events

##	 Contents

1. [Application Class](#application-class)
2. [Form Class and Control Class](#form-class-controll-class)
	1. [Partial Classes](#partial-classes)
	2. [Properties](#properties)
3. [Menus](#menus)
4. [Mouse and Keyboard Events](#mouse-and-keyboard-events)
	1. [Mouse Events](#mouse-events)
	2. [Keyboard Events](#keyboard-events)

## <a name="application-class"></a>Application Class

**Assignment**

1. Create a new project with the name “MouseEvents”2. Change the name of the default form to “MainForm”

## <a name="form-class-controll-class"></a>Form Class and Controll Class

![Class Diagram](https://raw.githubusercontent.com/cristianfrasineanu/ase-windows-applications-programming/master/docs/5/class-diagram.png)

### <a name="partial-classes"></a> Partial Classes

It is possible to split the definition of a [class](https://msdn.microsoft.com/en-us/library/0b0thckt.aspx) or a [struct](https://msdn.microsoft.com/en-us/library/ah19swz4.aspx), an [interface](https://msdn.microsoft.com/en-us/library/87d83y5b.aspx) or a method over two or more source files. Each source file contains a section of the type or method definition, and all parts are combined when the application is compiled.

**Assignment**

1. Open the “*.Designer.cs” file associated to the form
### <a name="properties"></a> Properties

Frequently used properties:

* **Design**: Name, etc.
* **Appearence**: Text, ForeColor, BackColor, Font, etc.

## <a name="menus"></a> Menus

**Assignment**	![C#](https://raw.githubusercontent.com/cristianfrasineanu/ase-windows-applications-programming/master/media/image1.png) Sample Code available at <http://online.ase.ro> – “SimpleWebBrowser” Sample

1. Create the following application  
![Browser App Preview](https://raw.githubusercontent.com/cristianfrasineanu/ase-windows-applications-programming/master/docs/5/browser-app-preview.png)
2. Create a setup file for the application, that can be redistributed to other users

> You need to right click on the project in the “Solution Explorer” window and choose the publish option

## <a name="mouse-and-keyboard-events"></a> Mouse and Keyboard Events
### <a name="mouse-events"></a> Mouse Events


| Event         | Event argument | Description              |
| :------------ |:-------------- | :----------------------  |
| Click         | EventArgs      | Raised when the control is clicked. |
| DoubleClick   | EventArgs      | Raised when the control is double-clicked. |
| MouseEnter    | EventArgs      | Raised when the mouse cursor enters the control.|
| MouseHover    | EventArgs      | Raised when the mouse cursor hovers over the control.|
| MouseLeave    | EventArgs      |  Raised when the mouse cursor leaves the control. |
| MouseDown     | MouseEventArgs |  Raised when the mouse cursor is over the control and a mouse button is pressed. |
| MouseMove     | MouseEventArgs | Raised when the mouse cursor is moved over the control. |
| MouseWheel    | MouseEventArgs | Raised when the control has focus and the mouse wheel is rotated. |
| MouseUp       | MouseEventArgs | Raised when the mouse cursor is over the control and a mouse button is released. |

![Info](https://raw.githubusercontent.com/cristianfrasineanu/ase-windows-applications-programming/master/media/image2.png) [Click](https://msdn.microsoft.com/en-us/library/system.windows.forms.control.click%28v=vs.110%29.aspx) events are logically higher-level events of a control. They are often raised by other actions, such as pressing the ENTER key when the control has focus.

Depressing a mouse button when the cursor is over a control typically raises the following series of events from the control:
* MouseDown event* Click event* MouseClick event* MouseUp event

**Assignment**

![Info](https://raw.githubusercontent.com/cristianfrasineanu/ase-windows-applications-programming/master/media/image2.png) Sample code available at <http://online.ase.ro> – “MouseEvents” Sample

1. Create the following UI  
![Mouse Events UI](https://raw.githubusercontent.com/cristianfrasineanu/ase-windows-applications-programming/master/docs/5/mouse-events.png)
2. Add the following code

```c#
public partial class MainForm : Form{	public MainForm()	{		InitializeComponent();	}	private void btnReset_Click(object sender, EventArgs e)	{		lbl.Text = "";		txt.Text = "";	}	//similar: lbl_MouseHover, lbl_MouseLeave, lbl_Click, lbl_DoubleClick	private void lbl_MouseEnter(object sender, EventArgs e)	{		lbl.Text = "MouseEnter";		TextBoxDraw("###Label MouseEnter");	}	//similar: lbl_MouseMove, lbl_MouseUp, lbl_MouseWheel	private void lbl_MouseDown(object sender, MouseEventArgs e)	{		lbl.Text = "MouseDown";		var str = "###Label MouseDown";		str += Environment.NewLine + "Button:  " + e.Button;		str += Environment.NewLine + "Clicks:  " + e.Clicks;		str += Environment.NewLine + "Delta:  " + e.Delta;		str += Environment.NewLine + "X:  " + e.X;		str += Environment.NewLine + "Y:  " + e.Y;		TextBoxDraw(str);	}	//similar: OnMouseHover, OnMouseLeave	protected override void OnMouseEnter(EventArgs e)	{		base.OnMouseEnter(e);		TextBoxDraw("###Form MouseEnter");	}	private void TextBoxDraw(string str)	{		txt.AppendText(Environment.NewLine + str);	}}
```

### <a name="keyboard-events"></a> Keyboard Events

| Event         | Event argument | Description              |
| :------------ |:-------------- | :----------------------  |
| KeyDown       | KeyEventArgs   | Raised when a key is pressed. The KeyDown event occurs prior to the KeyPress event. |
| KeyPress      | KeyPressEventArgs | Raised when a character generating key is pressed. The KeyPress event occurs after the KeyDown event and before the KeyUp event. |
| KeyUp         | KeyEventArgs    | Raised when a key is released. |

**Assignment**

We want to create a numeric only TextBox that can be used to build a simple calculator application, such as the one bellow.  
![Text Box Example](https://raw.githubusercontent.com/cristianfrasineanu/ase-windows-applications-programming/master/docs/5/text-box.png)

![Info](https://raw.githubusercontent.com/cristianfrasineanu/ase-windows-applications-programming/master/media/image2.png) Sample code available at <http://online.ase.ro> – “KeyEvents” Sample
1. Create a new project with the name “KeyEventsNumericTextBox”
2. Add a TextBox and name it “tbNumericTextBox”
3. Add the following event handler at the end of this document4. Change the previous event handler in order to allow the use of the “BackSpace” key5. Change the previous event handler in order to allow the digit separator for the current culture

```c#private void tbNumericTextBox_KeyPress(object sender, KeyPressEventArgs e){	OnKeyPress(e);	if (!char.IsDigit(e.KeyChar))	{		// Consume this invalid key		e.Handled = true;	}}
```