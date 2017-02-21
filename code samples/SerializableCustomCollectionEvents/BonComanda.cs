using System;
using System.Globalization;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;

namespace SerializableCustomCollectionEvents
{
	public partial class BonComanda : Form
	{
		public BonComanda()
		{
			InitializeComponent();
			ModelAplicatie.Comenzi.ModificareColectie += AfiseazaNrComenzi;
			ModelAplicatie.Comenzi.ModificareColectie += AfiseazaComenzi;
		}

		private void Form1Load(object sender, EventArgs e)
		{
			tbData.Text = DateTime.Now.ToString("dd/MM/yyyy");
			tbOra.Text = DateTime.Now.Hour.ToString(CultureInfo.InvariantCulture) + ":" + DateTime.Now.Minute.ToString(CultureInfo.InvariantCulture);
		}

		private void BtnSalvareClick1(object sender, EventArgs e)
		{
			ModelAplicatie.Comenzi.Adauga(new Comanda(tbNume.Text,tbPrenume.Text,cbMasina.SelectedItem.ToString()));
			//AfiseazaNrComenzi();
		}

		void AfiseazaNrComenzi(object sender, EventArgs e)
		{
			toolStripOrderCount.Text = ModelAplicatie.Comenzi.Lungime.ToString(CultureInfo.InvariantCulture);
		}

		void AfiseazaComenzi(object sender, EventArgs e)
		{
			lvComenzi.Items.Clear();
			foreach (Comanda comanda in ModelAplicatie.Comenzi)
			{
				lvComenzi.Items.Add(new ListViewItem(new[] { comanda.Nume, comanda.Prenume, comanda.Masina, comanda.Data.ToString(CultureInfo.InvariantCulture) }));
				lvComenzi.Items[lvComenzi.Items.Count - 1].Tag = comanda;
			}
		}

		private void BtnDeleteClick(object sender, EventArgs e)
		{
			if (lvComenzi.SelectedItems.Count == 1)
			{
				ModelAplicatie.Comenzi.Sterge((Comanda)lvComenzi.SelectedItems[0].Tag);
			}
			else
			{
				MessageBox.Show("Selectati o comanda!");
			}
		}

		private void BtnEditClick(object sender, EventArgs e)
		{
			if (lvComenzi.SelectedItems.Count == 1)
			{
				new Editare((Comanda)lvComenzi.SelectedItems[0].Tag).ShowDialog();
			}
			else
			{
				MessageBox.Show("Selectati o comanda!");
			}
		}

		private void BtnSalveazaClick(object sender, EventArgs e)
		{
			Stream stream = null;
			try
			{
				stream = File.Open("Serializare.dat", FileMode.Create);
				var bf = new BinaryFormatter();
				foreach (Comanda comanda in ModelAplicatie.Comenzi)
				    bf.Serialize(stream, comanda);
			}
			catch (IOException ex)
			{
				MessageBox.Show(ex.Message);
			}
			finally
			{
				if (stream != null) stream.Close();
			}
		}

		private void BtnRestaureazaClick(object sender, EventArgs e)
		{
			//Golim lista
			ModelAplicatie.Comenzi.Goleste();
			//Deserializam din fisier
			Stream stream = null;
			try
			{
				//preiau datele din fisier intr-un stream
				stream = File.Open("Serializare.dat", FileMode.Open);
				var bf = new BinaryFormatter();
				while (stream.Position < stream.Length)
					ModelAplicatie.Comenzi.Adauga((Comanda)bf.Deserialize(stream));
			}
			catch (IOException ex)
			{
				MessageBox.Show(ex.Message);
			}
			finally
			{
				if (stream != null) stream.Close();
			}
		}
	}
}