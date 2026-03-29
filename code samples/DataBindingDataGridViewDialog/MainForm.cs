using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;
using DataBindingDataGridViewDialog.ViewModels;

namespace DataBindingDataGridViewDialog
{
	public partial class MainForm : Form
	{
		#region Attributes
		private readonly BindingList<ParticipantViewModel> _participants;
		#endregion

		public MainForm()
		{
			InitializeComponent();

			_participants = new BindingList<ParticipantViewModel>();
		}

		#region Events

		private void MainForm_Load(object sender, EventArgs e)
		{
			dgvParticipants.DataSource = _participants;
		}
		private void btnAdd_Click(object sender, EventArgs e)
		{
			string firstName = tbFirstName.Text;
			string lastName = tbLastName.Text;
			DateTime birthDate = dtpBirthDate.Value;

			var participant = new ParticipantViewModel(lastName, firstName, birthDate);
			_participants.Add(participant);
		}

		private void btnEdit_Click(object sender, EventArgs e)
		{
			if (dgvParticipants.SelectedRows.Count == 0)
			{
				MessageBox.Show("Choose a participant");
				return;
			}

			DataGridViewRow row = dgvParticipants.SelectedRows[0];
			ParticipantViewModel participant = (ParticipantViewModel)row.DataBoundItem!;

			EditForm editForm = new EditForm(participant);
			editForm.ShowDialog();
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
				DataGridViewRow row = dgvParticipants.SelectedRows[0];
				ParticipantViewModel participant = (ParticipantViewModel)row.DataBoundItem!;
				_participants.Remove(participant);
			}
		}
		#endregion


	}
}
