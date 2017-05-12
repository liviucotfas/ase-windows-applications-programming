using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace DataBaseDataAdapter
{
    public partial class MainForm : Form
    {
	    private readonly OleDbConnection _dbConnection ;
		private readonly OleDbDataAdapter _dbDataAdapter;
	    private readonly DataSet _dsParticipants;

        public MainForm()
        {
	        InitializeComponent();

			//Best practice
			//Define the connection string in the settings of the application
			//var dbConnection = new OleDbConnection(Properties.Settings.Default.Database);
			_dbConnection = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=\"Database.mdb\";Persist Security Info=True");

			_dsParticipants = new DataSet();

	        _dbDataAdapter = new OleDbDataAdapter();

			var selectCommand = new OleDbCommand("SELECT Id, LastName, FirstName, BirthDate FROM Participant", _dbConnection);
	        _dbDataAdapter.SelectCommand = selectCommand;

			var deleteCommand = new OleDbCommand(
				"DELETE FROM Participant WHERE Id = @Id", _dbConnection);
			deleteCommand.Parameters.Add(
				new OleDbParameter("@Id", OleDbType.BigInt, 0, "Id"));
			_dbDataAdapter.DeleteCommand = deleteCommand;

			var insertCommand = new OleDbCommand("INSERT INTO Participant (LastName, FirstName, BirthDate) VALUES (@LastName, @FirstName, @BirthDate);", _dbConnection);
			insertCommand.Parameters.Add(
				new OleDbParameter("@LastName", OleDbType.VarChar, 0, "LastName"));
			insertCommand.Parameters.Add(
				new OleDbParameter("@FirstName", OleDbType.VarChar, 0, "FirstName"));
			insertCommand.Parameters.Add(
				new OleDbParameter("@BirthDate", OleDbType.DBDate, 0, "BirthDate"));
			_dbDataAdapter.InsertCommand = insertCommand;

			var updateCommand = new OleDbCommand("UPDATE Participant SET LastName = @LastName, FirstName=@FirstName, BirthDate = @BirthDate WHERE Id = @Id", _dbConnection);
			updateCommand.Parameters.Add(
				new OleDbParameter("@LastName", OleDbType.VarChar, 0, "LastName"));
			updateCommand.Parameters.Add(
				new OleDbParameter("@FirstName", OleDbType.VarChar, 0, "FirstName"));
			updateCommand.Parameters.Add(
				new OleDbParameter("@BirthDate", OleDbType.DBDate, 0, "BirthDate"));
			updateCommand.Parameters.Add(
				new OleDbParameter("@Id", OleDbType.BigInt, 0, "Id"));
			_dbDataAdapter.UpdateCommand = updateCommand;

	        _dbDataAdapter.RowUpdated += _dbDataAdapter_RowUpdated;
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
			DataRow newParticipantRow = 
				_dsParticipants.Tables["Participant"].NewRow();

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
				var getIdCommand = new OleDbCommand("SELECT @@Identity", _dbConnection);
				e.Row["Id"] = (int)getIdCommand.ExecuteScalar();
			}
		}
		#endregion
	}
}
