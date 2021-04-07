using System;
using System.Collections.Generic;
using System.Windows.Forms;
using ListViewSample.Entities;

namespace ListViewSample
{
	internal partial class MainForm : Form
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

				if (participant.BirthDate < new DateTime(DateTime.Now.Year - 18, DateTime.Now.Month, DateTime.Now.Day) )
				{
					listViewItem.ImageKey = "adult.png";
					listViewItem.Group = lvParticipants.Groups["adults"];
				}
				else
				{
					listViewItem.ImageKey = "child.png";
					listViewItem.Group = lvParticipants.Groups["children"];
				}

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
		private void btnDetails_Click(object sender, EventArgs e)
		{
			lvParticipants.View = View.Details;
		}

		private void btnList_Click(object sender, EventArgs e)
		{
			lvParticipants.View = View.List;
		}
		private void btnLargeIcon_Click(object sender, EventArgs e)
		{
			lvParticipants.View = View.LargeIcon;
		}
		private void btnSmallIcon_Click(object sender, EventArgs e)
		{
			lvParticipants.View = View.SmallIcon;
		}

		private void btnTiles_Click(object sender, EventArgs e)
		{
			lvParticipants.View = View.Tile;
		}
		#endregion
	}
}
