using System;
using System.Diagnostics;
using System.Windows.Forms;
using ValidationCustomExceptions.Entities;
using ValidationExceptionHandeling.Entities;

namespace ValidationCustomExceptions
{
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();
		}

		#region Events
		private void tbLastName_Validating(object sender, System.ComponentModel.CancelEventArgs e)
		{
			if (!IsLastNameValid())
			{
				e.Cancel = true; //prevents the user from changing the focus to another control
				errorProvider.SetError((Control)sender, "Last Name is empty!");
			}
		}

		private void tbLastName_Validated(object sender, EventArgs e)
		{
			errorProvider.SetError((Control)sender, string.Empty);
		}

		private void tbFirstName_Validating(object sender, System.ComponentModel.CancelEventArgs e)
		{
			if (!IsFirstNameValid())
			{
				e.Cancel = true; //prevents the user from changing the focus to another control

				errorProvider.SetError((Control) sender, "First Name is empty!");
			}
		}
		
		private void tbFirstName_Validated(object sender, EventArgs e)
		{
			//https://docs.microsoft.com/en-us/dotnet/api/system.windows.forms.errorprovider.clear
			errorProvider.SetError((Control)sender, string.Empty);
		}

		private void btnAdd_Click(object sender, EventArgs e)
		{

			//https://docs.microsoft.com/en-us/dotnet/api/system.windows.forms.containercontrol.validatechildren
			if (!ValidateChildren())
			{
				//An ErrorProvider control should
				MessageBox.Show("The form contains errors!",
					"Error",
					MessageBoxButtons.OK,
					MessageBoxIcon.Error);

				return;
			}

			try
			{
				string firstName = tbFirstName.Text.Trim();
				string lastName = tbLastName.Text.Trim();
				DateTime birthDate = dtpBirthDate.Value;
				string ssn = tbSSN.Text.Trim();
				GenderEnum gender = GenderEnum.Male;
				if (rbFemale.Checked)
					gender = GenderEnum.Female;
				var participant = new Participant(lastName, firstName, birthDate, gender, ssn);
				//TODO Logic for adding the participant to the ListView
			}
			catch (InvalidBirthDateException ex)
			{
				//Expected exception
				MessageBox.Show(string.Format("The birth date {0} is invalid!", ex.BirthDate));
			}
			catch (Exception)
			{
				//UnExpected exception
				MessageBox.Show("An exception has been encountered! Please contact the technical support.");

				//Log the exception using:
				// - Log4Net
				// - Application Insights
			}
			finally
			{
				Debug.WriteLine("Always executed");
			}
		}
		#endregion

		#region Methods
		private bool IsLastNameValid()
		{
			return !string.IsNullOrWhiteSpace(tbLastName.Text.Trim());
		}

		private bool IsFirstNameValid()
		{
			return !string.IsNullOrWhiteSpace(tbFirstName.Text.Trim());
		}
		#endregion
	}
}
