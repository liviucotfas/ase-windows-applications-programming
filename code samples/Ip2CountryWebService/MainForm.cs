using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TranslateWebService
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnTranslate_Click(object sender, EventArgs e)
        {
            net.webservicex.www.GeoIPService geoIpClient = new net.webservicex.www.GeoIPService();
            net.webservicex.www.GeoIP g = geoIpClient.GetGeoIP(txtIp.Text);
            if (g.ReturnCode == 1)
            {
                lbCountry.Text = g.CountryCode + " - " + g.CountryName;
            }
            else
            {
                lbCountry.Text = "Nu am gasit numele tarii!";
            }
        }
    }
}
