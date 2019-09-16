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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        static private LoginAuthenticator Authenticator = new LoginAuthenticator();
        private void BtnLogin_Click(object sender, EventArgs e)
        {
            var username = txtUsername.Text;
            var password = txtPassword.Text;
            var userType = cbUserType.Text;

            if (userType == "Admin")
            {
                if (Authenticator.IsValidForAdmin(username, password))
                {
                    MessageBox.Show("Login Successful", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    AdminForm admin = new AdminForm();
                    admin.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Incorrect Username or Password", "Close Window", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                if (Authenticator.IsValidForUser(username, password))
                {
                    MessageBox.Show("Login Successful", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    UserForm user = new UserForm();
                    user.Show();
                    this.Hide();

                }
                else
                {
                    MessageBox.Show("Incorrect Username or Password", "Close Window", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
