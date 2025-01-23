using DataBaseCommand.Entities;
using System.Data.SQLite;

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
	    private void DisplayParticipants()
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

	    private void LoadParticipants()
		{
			const string query = "SELECT * FROM Participant";

			using(SQLiteConnection connection = new SQLiteConnection(ConnectionString))
			{
				connection.Open();

				var command = new SQLiteCommand(query, connection);

				using (SQLiteDataReader reader = command.ExecuteReader())
				{
					while (reader.Read())
					{
						long id = (long)reader["Id"];
						string lastName = (string)reader["LastName"];
						string firstName = (string)reader["FirstName"];
						DateTime birthDate = DateTime.Parse((string)reader["BirthDate"]);

						Participant participant = new Participant(id, lastName, firstName, birthDate);
						_participants.Add(participant);
					}
				}
			}
		}

	    private void AddParticipant(Participant participant)
		{
			var query = "insert into Participant(LastName, FirstName, BirthDate)" +
			                  " values(@lastName,@firstName,@birthDate);  " +
			                  "SELECT last_insert_rowid()";

			using (SQLiteConnection connection = new SQLiteConnection(ConnectionString))
			{
				connection.Open();

				//1. Add the new participant to the database
				var command = new SQLiteCommand(query, connection);
				command.Parameters.AddWithValue("@lastName", participant.LastName);
				command.Parameters.AddWithValue("@firstName", participant.FirstName);
				command.Parameters.AddWithValue("@birthDate", participant.BirthDate);

				participant.Id = (long)command.ExecuteScalar();

				//2. Add the new participants to the local collection
				_participants.Add(participant);
			}
		}

	    private void DeleteParticipant(Participant participant)
	    {
			const string query = "DELETE FROM Participant WHERE Id=@id";

			using (SQLiteConnection connection = new SQLiteConnection(ConnectionString))
		    {
			    connection.Open();

				//Remove from the database
				SQLiteCommand command = new SQLiteCommand(query, connection);
				command.Parameters.AddWithValue("@id", participant.Id);

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
					ListViewItem selectedItem = lvParticipants.SelectedItems[0];
					Participant participant = (Participant)selectedItem.Tag!;

					DeleteParticipant(participant);

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