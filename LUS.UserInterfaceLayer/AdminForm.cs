using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LUS.UserInterfaceLayer
{
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            InitializeComponent();
            string headerFilePath = ConfigurationManager.AppSettings["HEADER_FILEPATH"];
            var licenseInformation = File.ReadAllText(headerFilePath);
            headerTxtBox.Text = licenseInformation;
        }

        private void BtnUpdateHeader_Click(object sender, EventArgs e)
        {
            string headerFilePath = ConfigurationManager.AppSettings["HEADER_FILEPATH"];
            File.WriteAllText(headerFilePath, headerTxtBox.Text);
            //Have to change the header in files
        }
    }
}
