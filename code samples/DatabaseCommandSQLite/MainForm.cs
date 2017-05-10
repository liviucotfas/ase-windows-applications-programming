using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Windows.Forms;
using DataBaseCommand.Entities;

namespace DataBaseCommand
{
    public partial class MainForm : Form
    {
		#region Attributes
		private readonly SQLiteConnection _dbConnection;
	    private readonly List<Participant> _participants;
		#endregion

		public MainForm()
        {
            InitializeComponent();

			_participants = new List<Participant>();

			//Best practice
			//Define the connection string in the settings of the application
			//_dbConnection = new SQLiteConnection(Properties.Settings.Default.Database);
			_dbConnection = new SQLiteConnection("Data Source=database.db");
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
			try
			{
				_dbConnection.Open();
				SQLiteCommand sqlCommand = new SQLiteCommand(stringSql, _dbConnection);
				SQLiteDataReader sqlReader = sqlCommand.ExecuteReader();
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
			finally
			{
				if (_dbConnection.State != ConnectionState.Closed) _dbConnection.Close();
			}
		}

		public void AddParticipant(Participant participant)
		{
			var dbCommand = new SQLiteCommand();
			dbCommand.Connection = _dbConnection;
			dbCommand.CommandText = "insert into Participant(LastName, FirstName, BirthDate)" +
			                        " values(@lastName,@firstName,@birthDate);  " +
			                        "SELECT last_insert_rowid()";

			try
			{
				//1. Add the new participant to the database
				_dbConnection.Open();
				dbCommand.Transaction = _dbConnection.BeginTransaction();

				var lastNameParameter = new SQLiteParameter("@lastName");
				lastNameParameter.Value = participant.LastName;
				var firstNameParameter = new SQLiteParameter("@firstName");
				firstNameParameter.Value = participant.FirstName;
				var birthDateParameter = new SQLiteParameter("@birthDate");
				birthDateParameter.Value = participant.BirthDate;

				dbCommand.Parameters.Add(lastNameParameter);
				dbCommand.Parameters.Add(firstNameParameter);
				dbCommand.Parameters.Add(birthDateParameter);

				participant.Id = (long)dbCommand.ExecuteScalar();

				dbCommand.Transaction.Commit();

				//2. Add the new participants to the local collection
				_participants.Add(participant);
			}
			catch (Exception)
			{
				dbCommand.Transaction.Rollback();
				throw;
			}
			finally
			{
				if (_dbConnection.State != ConnectionState.Closed)
					_dbConnection.Close();
			}
		}

		public void DeleteParticipant(Participant participant)
	    {
			const string stringSql = "DELETE FROM Participant WHERE Id=@id";
			try
			{
				//Remove from the database
				_dbConnection.Open();
				SQLiteCommand sqlCommand = new SQLiteCommand(stringSql, _dbConnection);
				var idParameter = new SQLiteParameter("@id");
				idParameter.Value = participant.Id;
				sqlCommand.Parameters.Add(idParameter);

				sqlCommand.ExecuteNonQuery();

				//Remove from the local copy
				_participants.Remove(participant);
			}
			finally
			{
				if (_dbConnection.State != ConnectionState.Closed) _dbConnection.Close();
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