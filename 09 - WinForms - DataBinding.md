# Windows Forms – DataBinding and Unit Testing

<!-- vscode-markdown-toc -->
* 1. [Objectives](#Objectives)
* 2. [DataBinding](#DataBinding)
	* 2.1. [Data binding types](#Databindingtypes)
	* 2.2. [Change notification](#Changenotification)
	* 2.3. [Activity](#Activity)
* 3. [Unit Testing](#UnitTesting)

<!-- vscode-markdown-toc-config
	numbering=true
	autoSave=true
	/vscode-markdown-toc-config -->
<!-- /vscode-markdown-toc -->

##  1. <a name='Objectives'></a>Objectives
- understand the concept and the utility of data binding;
- understand the differences between simple and complex data binding;
- implement simple data binding;
- implement complex data binding;

##  2. <a name='DataBinding'></a>DataBinding

###  2.1. <a name='Databindingtypes'></a>Data binding types

| Type | Description |
| ---- | ----------- |
| Simple data binding | The ability of a control to bind to a single data element, such as a value in a column in a dataset table. This is the type of binding typical for controls such as a [TextBox][1] control or [Label][2] control, which are controls that typically only displays a single value. In fact, any property on a control can be bound to a field in a database. |
| Complex data binding | The ability of a control to bind to more than one data element, typically more than one record in a database. Complex binding is also called list-based binding. Examples of controls that support complex binding are the [DataGridView][3], [ListBox][4], and [ComboBox][5] controls.|

[1]: https://msdn.microsoft.com/en-us/library/system.windows.forms.textbox(v=vs.110).aspx
[2]: https://msdn.microsoft.com/en-us/library/system.windows.forms.label(v=vs.110).aspx
[3]: https://msdn.microsoft.com/en-us/library/system.windows.forms.datagridview(v=vs.110).aspx
[4]: https://msdn.microsoft.com/en-us/library/system.windows.forms.listbox(v=vs.110).aspx
[5]: https://msdn.microsoft.com/en-us/library/system.windows.forms.combobox(v=vs.110).aspx


###  2.2. <a name='Changenotification'></a>Change notification

  - Ensures that your data source and bound controls always have the most recent data, we must add change notification for data binding. Specifically, we want to ensure that bound controls are notified of changes that were made to their data source, and the data source is notified of changes that were made to the bound properties of a control. 
  
Cases:

  - Simple Binding – [INotifyPropertyChanged][6]
  - Complex data binding - [IBindingList][7]
  
[6]: https://msdn.microsoft.com/en-us/library/system.componentmodel.inotifypropertychanged(v=vs.110).aspx 
[7]: https://msdn.microsoft.com/en-us/library/system.componentmodel.ibindinglist(v=vs.110).aspx

###  2.3. <a name='Activity'></a>Activity

> :octocat: Full source code available, check the `DataBindingSample` sample.

1. Create a copy of the “BasicListView” project and name it “DataBindingSample”

2. Replace the “ListView” control with a “DataGridView” control (Name: dgvParticipants)

3. Add a “ViewModel” folder to your project

4. Add the following “MainFormViewModel” class in the “ViewModel” folder

```c#
internal class MainFormViewModel : INotifyPropertyChanged
{
	#region Properties
  	#region LastName
	private string _lastName;
	public string LastName {
		get { return _lastName; }
		set
		{
			if (_lastName == value)
				return;
			_lastName = value;

			//If we use [CallerMemberName] in the OnPropertyChanged method
			//OnPropertyChanged();
			//If we don't use the [CallerMemberName] in the OnPropertyChanged method
			OnPropertyChanged("LastName");
		}
	}
	#endregion

	#region FirstName
	private string _firstName;
	public string FirstName
	{
		get { return _firstName; }
		set
		{
			if (_firstName == value)
				return;
			_firstName = value;
			OnPropertyChanged();
		}
	}
  	#endregion

	#region FirstName
	private DateTime _birthDate;

	public DateTime BirthDate
	{
		get { return _birthDate; }
		set
		{
			if (_birthDate == value)
				return;
			_birthDate = value;
			OnPropertyChanged();
		}
	}
	#endregion

	public BindingList<Participant> Participants { get; set; }
	#endregion

	public MainFormViewModel()
	{
		Participants = new BindingList<Participant>();
		BirthDate = DateTime.Now;
	}

	#region Methods
	public void AddParticipant()
	{
		Participants.Add(new Participant(LastName, FirstName, BirthDate));
		LastName = FirstName = string.Empty;
		BirthDate = DateTime.Today;
  }
	#endregion

	#region INotifyPropertyChanged
	public event PropertyChangedEventHandler PropertyChanged;

	[NotifyPropertyChangedInvocator]
	// [CallerMemberName] - Allows you to obtain the method or property name of the caller to the method. https://msdn.microsoft.com/en-us/library/system.runtime.compilerservices.callermembernameattribute%28v=vs.110%29.aspx
	protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
	{
		if(PropertyChanged != null)
			PropertyChanged.Invoke(this, new PropertyChangedEventArgs(propertyName));
	}
	#endregion
}
```

5. Update the  “MainForm” so that it is defined as follow.

```c#
 public partial class MainForm : Form
{
	private readonly MainFormViewModel _viewModel;

	public MainForm()
	{
		InitializeComponent();
		Load += MainForm_Load;

		_viewModel = new MainFormViewModel();
	}

	private void MainForm_Load(object sender, EventArgs e)
	{
  		dgvParticipants.DataSource = _viewModel.Participants;
		tbLastName.DataBindings.Add("Text",_viewModel,"LastName");
		tbFirstName.DataBindings.Add("Text", _viewModel, "FirstName");
		dtpBirthDate.DataBindings.Add("Value", _viewModel, "BirthDate");
	}

	private void btnAdd_Click(object sender, EventArgs e)
	{
		_viewModel.AddParticipant();
	}
}
```

![](media/image3.png) Further reading about the MVVM pattern: [link][8]

[8]: https://msdn.microsoft.com/en-us/library/hh848246.aspx

##  3. <a name='UnitTesting'></a>Unit Testing

> Documentation: [link](https://msdn.microsoft.com/en-us/library/hh694602.aspx)

**Activity**
> :octocat: Full source code available, check the `DataBindingSample.Tests` sample.

1. Add a new `Unit Test` project.
2. Add a reference to the project created above.
2. Let's test that the `AddParticipant()` method implemented above is actually adding a participant.

	```C#
	[TestClass]
	public class MainFormViewModelUnitTest
	{
		[TestMethod]
		public void AddParticipantTestMethod()
		{
			//Unit testing basics: https://msdn.microsoft.com/en-us/library/hh694602.aspx

			// arrange
			var viewModel = new MainFormViewModel();

			// act
			viewModel.AddParticipant();

			// assert  
			Assert.AreEqual(viewModel.Participants.Count, 1);
		}
	}
	```
**Assignments (for you to try)**
1. Implement additional unit test methods (ex: check whether the `LastName` property of the added participant is correct).