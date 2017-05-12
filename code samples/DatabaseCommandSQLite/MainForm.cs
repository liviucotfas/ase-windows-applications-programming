using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Windows.Forms;
using DataBaseCommand.Entities;

namespace DataBaseCommand
{
    public partial class MainForm : Form
    {
		#region Attributes
		//Best practice
		//Define the connection string in the settings of the application
		//private string connectionString = Properties.Settings.Default.Database;
	    private const string ConnectionString = "Data Source=database.db";
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

		public void LoadParticipants()
		{
			const string stringSql = "SELECT * FROM Participant";

			using(SQLiteConnection connection = new SQLiteConnection(ConnectionString))
			{
				connection.Open();

				var command = new SQLiteCommand(stringSql, connection);

				SQLiteDataReader sqlReader = command.ExecuteReader();
				try
				{
					while (sqlReader.Read())
					{
						_participants.Add(new Participant((long) sqlReader["Id"], (string) sqlReader["LastName"],
							(string) sqlReader["FirstName"], DateTime.Parse((string) sqlReader["BirthDate"])));
					}
				}
				finally
				{
					// Always call Close when done reading.
					sqlReader.Close();
				}
			}
		}

		public void AddParticipant(Participant participant)
		{
			var queryString = "insert into Participant(LastName, FirstName, BirthDate)" +
			                  " values(@lastName,@firstName,@birthDate);  " +
			                  "SELECT last_insert_rowid()";

			using (SQLiteConnection connection = new SQLiteConnection(ConnectionString))
			{
				connection.Open();

				//1. Add the new participant to the database
				var command = new SQLiteCommand(queryString, connection);
				var lastNameParameter = new SQLiteParameter("@lastName");
				lastNameParameter.Value = participant.LastName;
				var firstNameParameter = new SQLiteParameter("@firstName");
				firstNameParameter.Value = participant.FirstName;
				var birthDateParameter = new SQLiteParameter("@birthDate");
				birthDateParameter.Value = participant.BirthDate;

				command.Parameters.Add(lastNameParameter);
				command.Parameters.Add(firstNameParameter);
				command.Parameters.Add(birthDateParameter);

				participant.Id = (long)command.ExecuteScalar();

				//2. Add the new participants to the local collection
				_participants.Add(participant);
			}
		}

		public void DeleteParticipant(Participant participant)
	    {
			const string stringSql = "DELETE FROM Participant WHERE Id=@id";

			using (SQLiteConnection connection = new SQLiteConnection(ConnectionString))
		    {
			    connection.Open();

				//Remove from the database
				SQLiteCommand command = new SQLiteCommand(stringSql, connection);

				var idParameter = new SQLiteParameter("@id");
				idParameter.Value = participant.Id;
				command.Parameters.Add(idParameter);

				command.ExecuteNonQuery();

				//Remove from the local copy
				_participants.Remove(participant);
			}
		}
		#endregion

		#region Events
		private void MainForm_Load(object sender, EventArgs e)
		{
			try
			{
				LoadParticipants();
				DisplayParticipants();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		private void btnAdd_Click(object sender, EventArgs e)
		{
			var lastName = tbLastName.Text;
			var firstName = tbFirstName.Text;
			var birthDate = dtpBirthDate.Value;

			var participant = new Participant(lastName, firstName, birthDate);

			try
			{
				AddParticipant(participant);
				DisplayParticipants();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
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
				try
				{
					DeleteParticipant((Participant) lvParticipants.SelectedItems[0].Tag);
					DisplayParticipants();
				}
				catch (Exception ex)
				{
					MessageBox.Show(ex.Message);
				}
			}
		}
		#endregion
	}
}