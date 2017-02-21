using System;
using System.Globalization;
using System.Threading;
using System.Windows.Forms;

namespace Globalization
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            //First, retrive all NeutralCultures. For more information check http://msdn.microsoft.com/en-us/library/system.globalization.cultureinfo.aspx
            var neutralCultures = CultureInfo.GetCultures(CultureTypes.NeutralCultures);

            //We need to specify how the comparison will be done: (x,y)=>String.CompareOrdinal(x.EnglishName, y.EnglishName)
            //Another option is to use the Sort method overload that accepts a class implementing IComparer interface as shown in one of the previous Examples
            //More info: http://msdn.microsoft.com/en-us/library/system.array.sort.aspx
            Array.Sort(neutralCultures, (x,y)=>String.CompareOrdinal(x.EnglishName, y.EnglishName));
            
            //Databind the cultures array to the combobox in the interface
            cbCulture.DataSource = neutralCultures;
            //Choose what field from the CultureInfo objects will be displayed
            cbCulture.DisplayMember = "EnglishName";
        }

        private void CbCultureSelectedIndexChanged(object sender, EventArgs e)
        {
            //Set the UI culture to the culture selected from the cobobox
            // we could have also used cbCulture.SelectedItem insted of acessing the sender
            Thread.CurrentThread.CurrentUICulture = (CultureInfo)((ComboBox) sender).SelectedItem;
            //Set the thread culture
            Thread.CurrentThread.CurrentCulture = (CultureInfo)((ComboBox)sender).SelectedItem;

            //Display information using the selected culture
            ShowInfo();
        }

        public void ShowInfo()
        {
            var today = DateTime.Today;
            tbDate.Text = today.ToString("D");

            const int currencyValue = 1000000000;
            tbCurrency.Text = currencyValue.ToString("C");
        }
    }
}
