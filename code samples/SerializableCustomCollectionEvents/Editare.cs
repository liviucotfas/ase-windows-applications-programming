using System;
using System.Windows.Forms;

namespace SerializableCustomCollectionEvents
{
    public partial class Editare : Form
    {
    	readonly Comanda _comanda;

        public Editare(Comanda comanda)
        {
            InitializeComponent();
            _comanda = comanda;
            tbNume.Text = comanda.Nume;
            tbPrenume.Text = comanda.Prenume;
        }

        private void BtnSalvareClick(object sender, EventArgs e)
        {
            _comanda.Nume = tbNume.Text;
            _comanda.Prenume = tbPrenume.Text;
            Close();
        }
    }
}