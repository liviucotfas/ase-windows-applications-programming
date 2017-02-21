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
		public void DisplayParticipants()
		{
			lvParticipants.Items.Clear();

			foreach (Participant participant in _participants)
			{
				var listViewItem = new ListViewItem(participant.LastName);
				listViewItem.SubItems.Add(participant.FirstName);
				listViewItem.SubItems.Add(participant.BirthDate.ToShortDateString());
				listViewItem.Tag = participant;
				lvParticipants.Items.Add(listViewItem);
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
			if (lvParticipants.SelectedItems.Count == 0)
			{
				MessageBox.Show("Choose a participant");
				return;
			}

			EditForm editForm = new EditForm((Participant)lvParticipants.SelectedItems[0].Tag);
			if (editForm.ShowDialog() == DialogResult.OK)
				DisplayParticipants();
		}

		private void btnDelete_Click(object sender, EventArgs e)
		{
			if (lvParticipants.SelectedItems.Count == 0)
			{
				MessageBox.Show("Choose a participant");
				return;
			}

			if (MessageBox.Show("Are you sure?", "Delete participant", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) ==
			    DialogResult.Yes)
			{
				_participants.Remove((Participant) lvParticipants.SelectedItems[0].Tag);
				DisplayParticipants();
			}
		}
		#endregion
	}
}
