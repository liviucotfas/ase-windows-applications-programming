using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;
using System.Xml.Serialization;
using Newtonsoft.Json;
using SerializationBinaryXMLTextFile.Entities;

namespace SerializationBinaryXMLTextFile
{
	public partial class MainForm : Form
	{
		#region Attributes
		private List<Participant> _participants;
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


		#region Binary
		private void btnSerializeBinary_Click(object sender, EventArgs e)
		{
			using (FileStream stream = File.Create("SerializedBinary.bin"))
			{
                var binaryWriter = new BinaryWriter(stream);
                foreach (var participant in _participants)
                {
                    binaryWriter.Write(participant.LastName);
                    binaryWriter.Write(participant.FirstName);
                    binaryWriter.Write(participant.BirthDate.ToBinary());
                }
            }	
		}

		private void btnDeserializeBinary_Click(object sender, EventArgs e)
		{
			using (FileStream stream = File.OpenRead("SerializedBinary.bin"))
			{
                var binaryReader = new BinaryReader(stream);
                _participants = new List<Participant>();
                while (stream.Position < stream.Length)
                {
                    var lastName = binaryReader.ReadString();
                    var firstName = binaryReader.ReadString();
                    var birthDate = DateTime.FromBinary(binaryReader.ReadInt64());
                    _participants.Add(new Participant(lastName, firstName, birthDate));
                }
                DisplayParticipants();
			}
		}
		#endregion

		#region XML
		private void btnSerializeXML_Click(object sender, EventArgs e)
		{
			XmlSerializer serializer = new XmlSerializer(typeof(List<Participant>));
			using (FileStream stream = File.Create("SerializedXML.xml"))
				serializer.Serialize(stream, _participants);
		}

		private void btnDeserializeXML_Click(object sender, EventArgs e)
		{
			XmlSerializer serializer = new XmlSerializer(typeof(List<Participant>));
			using (FileStream stream = File.OpenRead("SerializedXML.xml"))
			{
				_participants = (List<Participant>)serializer.Deserialize(stream);
				DisplayParticipants();
			}
		}
		#endregion

		#region JSON
		private void btnSerializeJSON_Click(object sender, EventArgs e)
		{
			JsonSerializer serializer = new JsonSerializer();
			using (StreamWriter writer = File.CreateText("SerializedJSON.json"))
			{
                serializer.Serialize(writer, _participants);
			}
		}

		private void btnDeserializeJSON_Click(object sender, EventArgs e)
		{
			JsonSerializer serializer = new JsonSerializer();
			using (StreamReader reader = new StreamReader("SerializedJSON.json"))
			{
				_participants = (List<Participant>)serializer.Deserialize(reader, typeof(List<Participant>));
				DisplayParticipants();
			}
		}
		#endregion

		private void btnTextFile_Click(object sender, EventArgs e)
		{
            // Create an instance of the open file dialog box.
            SaveFileDialog saveFileDialog = new SaveFileDialog();
			saveFileDialog.Filter = "Text File | *.txt";
			saveFileDialog.Title = "Save as text file";

			if (saveFileDialog.ShowDialog() == DialogResult.OK)
			{
				//Approach 1
				//StreamWriter sw = new StreamWriter(saveFileDialog.FileName);
				//try
				//{
				//	sw.WriteLine("LastName,FirstName,BirthDate");

				//	foreach (var participant in _participants)
				//	{
				//		sw.WriteLine("{0}, {1}, {2}"
				//			, participant.LastName
				//			, participant.FirstName
				//			, participant.BirthDate.ToShortDateString());
				//	}
				//}
				//finally
				//{
				//	sw.Dispose();
				//}

				//2. Approach 2 - recommended
				// generates the try{} finally{} in Version 1
				using (StreamWriter sw = new StreamWriter(saveFileDialog.FileName))
				{
					sw.WriteLine("LastName,FirstName,BirthDate");

					foreach (var participant in _participants)
					{
						sw.WriteLine("\"{0}\", \"{1}\", \"{2}\""
                            , participant.LastName.Replace("\"", "\"\"")
							, participant.FirstName.Replace("\"", "\"\"")
                            , participant.BirthDate.ToShortDateString());
					}
				}
			}
		}
		#endregion		
	}
}
