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
		private ListViewGroup _lvgChildren;
		private ListViewGroup _lvgAdults;
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

				//approximate calculation of the age 
				if ((DateTime.Now - participant.BirthDate).TotalDays/365 >= 18)
				{
					listViewItem.ImageKey = "adult.png";
					listViewItem.Group = _lvgAdults;
				}
				else
				{
					listViewItem.ImageKey = "child.png";
					listViewItem.Group = _lvgChildren;
				}

				lvParticipants.Items.Add(listViewItem);
			}
		}
		#endregion

		#region Events
		private void MainForm_Load(object sender, EventArgs e)
		{
			_lvgChildren = new ListViewGroup("Children", HorizontalAlignment.Left);
			_lvgAdults = new ListViewGroup("Adults", HorizontalAlignment.Left);
			_lvgChildren.Header = "Children";
			_lvgChildren.Name = "lvgChildren";
			_lvgAdults.Header = "Adults";
			_lvgAdults.Name = "lvgAdult";
			lvParticipants.Groups.AddRange(new[] { _lvgChildren, _lvgAdults });
		}

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
