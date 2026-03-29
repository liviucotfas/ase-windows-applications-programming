using System.Windows.Forms;
using DataBindingDataGridViewDialog.ViewModels;

namespace DataBindingDataGridViewDialog
{
	public partial class EditForm : Form
	{
		#region Attributes
		private readonly ParticipantViewModel _participant;
		#endregion
		
		public EditForm(ParticipantViewModel participant)
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
