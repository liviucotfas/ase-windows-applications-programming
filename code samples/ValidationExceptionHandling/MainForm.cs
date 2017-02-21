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

		private void MainForm_Load(object sender, EventArgs e)
		{

		}

		#region Events
		private void btnAdd_Click(object sender, EventArgs e)
		{
			string firstName = tbFirstName.Text.Trim();
			string lastName = tbLastName.Text.Trim();
			DateTime birthDate = dtpBirthDate.Value;
			string ssn = tbSSN.Text.Trim();

			GenderEnum gender = GenderEnum.Male;
			if(rbFemale.Checked)
				gender = GenderEnum.Female;

			bool isValid = true;
			
			if (string.IsNullOrWhiteSpace(lastName))
			{
				epLastName.SetError(tbFirstName, "Last Name is empty!");
				isValid = false;
			}

			if (string.IsNullOrWhiteSpace(firstName))
			{
				epFirstName.SetError(tbFirstName, "First Name is empty!");
				isValid = false;
			}

			//TODO: check the birthDate
			//TODO: check the Gender
			//TODO: check the SSN (ex: first digit corresponds to the gender, etc.)

			if (!isValid)
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

		private void tbLastName_Validating(object sender, System.ComponentModel.CancelEventArgs e)
		{
			string lastName = ((TextBox) sender).Text.Trim();

			if (string.IsNullOrWhiteSpace(lastName))
			{
				e.Cancel = true; //prevents the user from changing the focus to another control

				epLastName.SetError((Control)sender, "Last Name is empty!");
			}
		}

		private void tbLastName_Validated(object sender, EventArgs e)
		{
			epLastName.Clear();
		}

		private void tbFirstName_Validating(object sender, System.ComponentModel.CancelEventArgs e)
		{
			string firstName = ((TextBox) sender).Text.Trim();

			if (string.IsNullOrWhiteSpace(firstName))
			{
				e.Cancel = true; //prevents the user from changing the focus to another control

				epFirstName.SetError((Control) sender, "First Name is empty!");
			}
		}
		
		private void tbFirstName_Validated(object sender, EventArgs e)
		{
			epFirstName.Clear();
		}	
		#endregion
	}
}
