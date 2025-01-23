using System;
using System.Collections.Generic;
using Microsoft.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;
using DatabaseCommand.Entities;
using DatabaseCommandSQLServer2Entities.Entities;

namespace DatabaseCommandSQLServer2Entities
{
    public partial class MainForm : Form
    {
		#region Attributes
		//Best practice
		//Define the connection string in the settings of the application
		//string ConnectionString = Properties.Settings.Default.Database;
		private const string ConnectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Participants;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
	    private readonly List<Race> _races;
		private readonly List<Participant> _participants;
	    #endregion

		public MainForm()
        {
            InitializeComponent();

	        _races = new List<Race>();
			_participants = new List<Participant>();
        }

		#region Methods
	    private void LoadRaces()
	    {
		    _races.Add(new Race(1, "RELAY"));
		    _races.Add(new Race(2, "10K"));
		    _races.Add(new Race(3, "HALFMARATHON"));
		    _races.Add(new Race(4, "MARATHON"));
	    }

	    private void DisplayRaces()
	    {
		    cbRace.DisplayMember = "Name";
		    foreach (var race in _races)
		    cbRace.Items.Add(race);
	    }

		private void DisplayParticipants()
		{
			lvParticipants.Items.Clear();

			foreach (Participant participant in _participants)
			{
				var listViewItem = new ListViewItem(participant.LastName);
				listViewItem.SubItems.Add(participant.FirstName);
				listViewItem.SubItems.Add(participant.BirthDate.ToShortDateString());

				var race = _races.FirstOrDefault(x => x.RaceId == participant.RaceId);
				if(race!=null)
					listViewItem.SubItems.Add(race.Name);

				listViewItem.Tag = participant;

				lvParticipants.Items.Add(listViewItem);
			}
		}

	    private void LoadParticipants()
		{
			const string query = "SELECT * FROM Participant";

			using (SqlConnection connection = new SqlConnection(ConnectionString))
			{
				connection.Open();
				
				SqlCommand command = new SqlCommand(query , connection);
				SqlDataReader reader = command.ExecuteReader();
				try
				{
					while (reader.Read())
					{
						var participant = new Participant(
							(int) reader["Id"], 
							(string) reader["LastName"],
							(string) reader["FirstName"], 
							(DateTime) reader["BirthDate"],
							(int)reader["raceId"]);
						_participants.Add(participant);
					}
				}
				finally
				{
					// Always call Close when done reading.
					reader.Close();
				}
			}
		}

	    private void AddParticipant(Participant participant)
	    {
		    var query = "insert into Participant(LastName, FirstName, BirthDate, RaceId)" +
							  " values(@lastName,@firstName,@birthDate, @raceId); SELECT SCOPE_IDENTITY();";

			using (SqlConnection connection = new SqlConnection(ConnectionString))
		    {
				//1. Open the connection
			    connection.Open();

			    //2. Add the new participant to the database
				var command = new SqlCommand(query , connection);
				command.Parameters.AddWithValue("@lastName", participant.LastName);
				command.Parameters.AddWithValue("@firstName", participant.FirstName);
				command.Parameters.AddWithValue("@birthDate", participant.BirthDate.Date);
				command.Parameters.AddWithValue("@raceId", participant.RaceId);

				participant.Id = (int)(decimal)command.ExecuteScalar();

				//3. Add the new participant to the local collection
				_participants.Add(participant);
		    }
	    }

	    private void DeleteParticipant(Participant participant)
	    {
			const string query = "DELETE FROM Participant WHERE Id=@id";

		    using (SqlConnection connection = new SqlConnection(ConnectionString))
		    {
				//Remove from the database
			    connection.Open();

				SqlCommand command = new SqlCommand(query , connection);
				command.Parameters.AddWithValue("@id",participant.Id);

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
				LoadRaces();
				DisplayRaces();
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
			//1. Validate input
			var lastName = tbLastName.Text;
			var firstName = tbFirstName.Text;
			var birthDate = dtpBirthDate.Value;
			var race = cbRace.SelectedItem;

			//... other validations

			if (race == null)
			{
				MessageBox.Show("Please choose a race!");
				return;
			}

			//2. Add the participant
			var participant = new Participant(
				lastName, 
				firstName, 
				birthDate, 
				((Race)race).RaceId);

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