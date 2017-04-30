using System;
using System.Data;
using System.Data.SQLite;
using System.Windows.Forms;

namespace DataBaseDataAdapter
{
    public partial class MainForm : Form
    {
	    private readonly SQLiteConnection _dbConnection ;
		private readonly SQLiteDataAdapter _dbDataAdapter;
	    private readonly DataSet _dsParticipants;

        public MainForm()
        {
	        InitializeComponent();

			//Best practice
			//Define the connection string in the settings of the application and retrieve it using ConfigurationManager.AppSettings["ConnectionString"]
			//var dbConnection = new SQLiteConnection(ConfigurationManager.AppSettings["ConnectionString"]);
			_dbConnection = new SQLiteConnection("Data Source = database.db");

			_dsParticipants = new DataSet();

			var selectCommand = new SQLiteCommand("SELECT Id, LastName, FirstName, BirthDate FROM Participant", _dbConnection);
			
	        _dbDataAdapter = new SQLiteDataAdapter(selectCommand);
			_dbDataAdapter.RowUpdated += _dbDataAdapter_RowUpdated;

			var deleteCommand = new SQLiteCommand("DELETE FROM Participant WHERE Id = @Id", _dbConnection);
			deleteCommand.Parameters.Add(new SQLiteParameter("@Id"));
			_dbDataAdapter.DeleteCommand = deleteCommand;

			var insertCommand = new SQLiteCommand("INSERT INTO Participant (LastName, FirstName, BirthDate) VALUES (@LastName, @FirstName, @BirthDate);", _dbConnection);
			insertCommand.Parameters.Add(new SQLiteParameter("@LastName"));
			insertCommand.Parameters.Add(new SQLiteParameter("@FirstName"));
			insertCommand.Parameters.Add(new SQLiteParameter("@BirthDate"));
			_dbDataAdapter.InsertCommand = insertCommand;

			var updateCommand = new SQLiteCommand("UPDATE Participant SET LastName = @LastName, FirstName=@FirstName, BirthDate = @BirthDate WHERE Id = @Id", _dbConnection);
			updateCommand.Parameters.Add(new SQLiteParameter("@LastName", DbType.String, "LastName"));
			updateCommand.Parameters.Add(new SQLiteParameter("@FirstName", DbType.String, "LastName"));
			updateCommand.Parameters.Add(new SQLiteParameter("@BirthDate", DbType.String, "LastName"));
			updateCommand.Parameters.Add(new SQLiteParameter("@Id", DbType.Int64, "Id"));
			_dbDataAdapter.UpdateCommand = updateCommand;
		}

		#region Events
		private void MainForm_Load(object sender, EventArgs e)
		{
			try
			{
				_dbDataAdapter.Fill(_dsParticipants, "Participant");
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}

			//DataBinding Grid
			dgvParticipants.DataSource = _dsParticipants.Tables["Participant"];
			//dgvParticipants.Columns["Id"].Visible = false;
		}

		private void btnAdd_Click(object sender, EventArgs e)
		{
			DataRow newParticipantRow = _dsParticipants.Tables["Participant"].NewRow();

			newParticipantRow["LastName"] = tbLastName.Text;
			newParticipantRow["FirstName"] = tbFirstName.Text;
			newParticipantRow["BirthDate"] = dtpBirthDate.Value;

			_dsParticipants.Tables["Participant"].Rows.Add(newParticipantRow);
		}

		private void btnPersistChanges_Click(object sender, EventArgs e)
		{
			try
			{
				_dbDataAdapter.Update(_dsParticipants, "Participant");
				//_dsParticipants.AcceptChanges();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		private void _dbDataAdapter_RowUpdated(object sender, System.Data.Common.RowUpdatedEventArgs e)
		{
			//https://msdn.microsoft.com/en-us/library/ks9f57t0%28v=vs.110%29.aspx
			if (e.StatementType == StatementType.Insert)
			{
				var getIdCommand = new SQLiteCommand("SELECT last_insert_rowid()", _dbConnection);
				e.Row["Id"] = (long)getIdCommand.ExecuteScalar();
			}
		}
		#endregion
	}
}
