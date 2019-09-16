using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace LoginForm
{
    public partial class AdminLogin : Form
    {
        public AdminLogin()
        {
            InitializeComponent();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string path = @"C:\Users\admin\Desktop\integrate\header.txt";
            File.Create(path);



        }

        private void button2_Click(object sender, EventArgs e)
        {
            string path = @"D:\siemens_project_work\14 sep\header.txt";
            File.WriteAllText(path, headerTxtBox.Text);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            string path = @"D:\siemens_project_work\14 sep\header.txt";
            var str = File.ReadAllText(path);
            headerTxtBox.Text = str;
        }
    }
}
