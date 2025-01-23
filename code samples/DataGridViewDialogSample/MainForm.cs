using System;
using System.Collections.Generic;
using System.Windows.Forms;
using DialogSample.Entities;

namespace DialogSample
{
	public partial class MainForm : Form
	{
		#region Attributes
		private readonly List<Participant> _participants;
		#endregion

		public MainForm()
		{
			InitializeComponent();

			_participants = new List<Participant>();
		}

		#region Methods
		private void DisplayParticipants()
		{
			dgvParticipants.Rows.Clear();

			foreach (Participant participant in _participants)
			{
				int rowId = dgvParticipants.Rows.Add(new object[]
				{
					participant.LastName,
					participant.FirstName,
					participant.BirthDate
				});

				dgvParticipants.Rows[rowId].Tag = participant;
			}
		}
		#endregion

		#region Events
		private void btnAdd_Click(object sender, EventArgs e)
		{
			string firstName = tbFirstName.Text;
			string lastName = tbLastName.Text;
			DateTime birthDate = dtpBirthDate.Value;

			var participant = new Participant(lastName, firstName, birthDate);
			_participants.Add(participant);

			DisplayParticipants();
		}

		private void btnEdit_Click(object sender, EventArgs e)
		{
			if (dgvParticipants.SelectedRows.Count == 0)
			{
				MessageBox.Show("Choose a participant");
				return;
			}

			DataGridViewRow row = dgvParticipants.SelectedRows[0];
			Participant participant = (Participant)row.Tag!;

			EditForm editForm = new EditForm(participant);
			if (editForm.ShowDialog() == DialogResult.OK)
				DisplayParticipants();
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
				Participant participant = (Participant)row.Tag!;
				_participants.Remove(participant);
				DisplayParticipants();
			}
		}
		#endregion
	}
}
