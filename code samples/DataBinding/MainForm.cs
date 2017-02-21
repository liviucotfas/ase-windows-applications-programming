using System;
using System.Windows.Forms;
using DataBindingSample.Entities;
using DataBindingSample.ViewModel;

namespace DataBindingSample
{
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

			tbLastName.DataBindings.Add("Text",_viewModel,"LastName",false,DataSourceUpdateMode.OnPropertyChanged);
			tbFirstName.DataBindings.Add("Text", _viewModel, "FirstName", false, DataSourceUpdateMode.OnPropertyChanged);
			dtpBirthDate.DataBindings.Add("Value", _viewModel, "BirthDate", false, DataSourceUpdateMode.OnPropertyChanged);
		}

		private void btnAdd_Click(object sender, EventArgs e)
		{
			_viewModel.AddParticipant();
		}

		private void btnDelete_Click(object sender, EventArgs e)
		{
			if (dgvParticipants.SelectedRows.Count == 0)
			{
				MessageBox.Show("Choose a participant");
				return;
			}

			if (MessageBox.Show("Are you sure?", "Delete participant", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) ==
				DialogResult.Yes)
			{
				Participant selectedParticipant = (Participant) dgvParticipants.SelectedRows[0].DataBoundItem;
				_viewModel.DeleteParticipant(selectedParticipant);
			}
		}
	}
}
