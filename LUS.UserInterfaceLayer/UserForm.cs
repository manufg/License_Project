using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LUS.UserInterfaceLayer
{
    public partial class UserForm : Form
    {
        public UserForm()
        {
            InitializeComponent();
        }

        private void BtnBrowseFile_Click(object sender, EventArgs e)
        {
            DialogResult resDialog = dlgOpenDir.ShowDialog();
            if (resDialog.ToString() == "OK")
            {
                txtFilePath.Text = dlgOpenDir.SelectedPath;
            }
        }

        private void BtnWatchFile_Click(object sender, EventArgs e)
        {

        }

        private void BtnLog_Click(object sender, EventArgs e)
        {

        }
    }
}
