using System;
using System.ComponentModel;
using System.Data.SQLite;
using System.Windows.Forms;
using DatabaseCommandSQLiteDataGridView.Entities;

namespace DatabaseCommandSQLiteDataGridView
{
	public partial class MainForm : Form
    {
		#region Attributes
		//Best practice
		//Define the connection string in the settings of the application
		//private string connectionString = Properties.Settings.Default.Database;
	    private const string ConnectionString = "Data Source=database.db";
		private readonly BindingList<Participant> _participants;
		#endregion

		public MainForm()
        {
            InitializeComponent();

			_participants = new BindingList<Participant>();
        }

		#region Methods
	    private void LoadParticipants()
		{
			const string query = "SELECT * FROM Participant";

			using(SQLiteConnection connection = new SQLiteConnection(ConnectionString))
			{
				connection.Open();

				var command = new SQLiteCommand(query, connection);

				SQLiteDataReader reader = command.ExecuteReader();
				try
				{
					while (reader.Read())
					{
						_participants.Add(new Participant((long) reader["Id"], (string) reader["LastName"],
							(string) reader["FirstName"], DateTime.Parse((string) reader["BirthDate"])));
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
			var query = "insert into Participant(LastName, FirstName, BirthDate)" +
			                  " values(@lastName,@firstName,@birthDate);  " +
			                  "SELECT last_insert_rowid()";

			using (SQLiteConnection connection = new SQLiteConnection(ConnectionString))
			{
				connection.Open();

				//1. Add the new participant to the database
				var command = new SQLiteCommand(query, connection);
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

	    private void DeleteParticipant(Participant participant)
	    {
			const string query = "DELETE FROM Participant WHERE Id=@id";

			using (SQLiteConnection connection = new SQLiteConnection(ConnectionString))
		    {
			    connection.Open();

				//Remove from the database
				SQLiteCommand command = new SQLiteCommand(query, connection);

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
				dgvParticipants.DataSource = _participants;
				LoadParticipants();
				//DisplayParticipants();
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
				//DisplayParticipants();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
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
				try
				{
					DeleteParticipant((Participant)dgvParticipants.SelectedRows[0].DataBoundItem!);
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