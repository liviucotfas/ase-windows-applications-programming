using System.Windows.Forms;
using DialogSample.Entities;

namespace DialogSample
{
	public partial class EditForm : Form
	{
		#region Attributes
		private readonly Participant _participant;
		#endregion
		
		public EditForm(Participant participant)
		{
			_participant = participant;

			InitializeComponent();
		}

		private void EditForm_Load(object sender, System.EventArgs e)
		{
			tbLastName.Text = _participant.LastName;
			tbFirstName.Text = _participant.FirstName;
			dtpBirthDate.Value = _participant.BirthDate;
		}

		private void btnOK_Click(object sender, System.EventArgs e)
		{
			_participant.LastName = tbLastName.Text;
			_participant.FirstName = tbFirstName.Text;
			_participant.BirthDate = dtpBirthDate.Value;
		}
	}
}
