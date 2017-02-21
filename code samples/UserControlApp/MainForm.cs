using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace ClockUserControlAppSample
{
    public partial class MainForm : Form
    {
        [DllImport("kernel32.dll")]
        static extern void Beep(int nota, int durata);

        public MainForm()
        {
            InitializeComponent();
        }

        private void ceas1_Suna(object sender, EventArgs e)
        {
            int DO = 262;
            Beep(DO, 200);
        }

        private void tbOra_MouseDown(object sender, MouseEventArgs e)
        {
            //se fixeaza sursa de date
            tbOra.DoDragDrop(tbOra.Text, DragDropEffects.Copy | DragDropEffects.Move);
        }

        private void ceas1_DragEnter(object sender, DragEventArgs e)
        {

            if (e.Data.GetDataPresent(DataFormats.Text))
                e.Effect = DragDropEffects.Copy;
            else
                e.Effect = DragDropEffects.None;
        }

        private void ceas1_DragDrop(object sender, DragEventArgs e)
        {
            string[] sir;
            string date = e.Data.GetData(DataFormats.Text).ToString();
            sir = date.Split(':');
            _clockUserControl.Ora = int.Parse(sir[0]);
            _clockUserControl.Min = int.Parse(sir[1]);
            //Setam acceasi ora/min si pentru alarma =>va porni alarma
            _clockUserControl.OraAlarm = _clockUserControl.Ora;
            _clockUserControl.MinAlarm = _clockUserControl.Min;
            _clockUserControl.Invalidate();
        }

        private void btnGetSystemTime_Click(object sender, EventArgs e)
        {
            _clockUserControl.Ora = DateTime.Now.Hour;
            _clockUserControl.Min = DateTime.Now.Minute;
            _clockUserControl.Sec = DateTime.Now.Second;
        }
    }
}