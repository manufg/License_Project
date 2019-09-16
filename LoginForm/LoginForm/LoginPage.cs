using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using LUS.BusinessLayer;

namespace LoginForm
{
    public partial class LoginPage : Form
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        static private Authenticator auth = new Authenticator();

        private void btnLogin_Click(object sender, EventArgs e)
        {
            var username = txtUsername.Text;
            var password = txtPassword.Text;
            var userType = cbUserType.Text;

            if (userType == "Admin")
            {
                if (auth.IsValidForAdmin(username, password))
                {
                    MessageBox.Show("Login Successful", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    AdminLogin admin = new AdminLogin();
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
                if (auth.IsValidForUser(username, password))
                {
                    MessageBox.Show("Login Successful", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    UserLogin user = new UserLogin();

                    BusinessLayerComponent businessLayerComponent = new BusinessLayerComponent("D:/License_Project/test_folder");
                     businessLayerComponent.StartWatching();
                    UserLogin userLogin = new UserLogin();
                    userLogin.Show();
                    //frmNotifier frmNotifier = new frmNotifier();
                    //Application.Run(new frmNotifier());
                   // frmNotifier.Show();
                    this.Hide();
                    
                    
                    
                    
                }
                else
                {
                    MessageBox.Show("Incorrect Username or Password", "Close Window", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }




        }

        class Authenticator
        {
            private Dictionary<string, string> AdminCredentials = new Dictionary<string, string>();
            private Dictionary<string, string> UserCredentials = new Dictionary<string, string>();

            public Authenticator()
            {

                var adminLogins = File.ReadAllLines(@"D:\License_Project\files\Admin_Logins.csv");
                foreach (var adminLogin in adminLogins)
                {
                    var parts = adminLogin.Split(',');
                    AdminCredentials.Add(parts[0].Trim(), parts[1].Trim());

                }
                var userLogins = File.ReadAllLines(@"D:\License_Project\files\User_Logins.csv");
                foreach (var userLogin in userLogins)
                {
                    var parts = userLogin.Split(',');
                    UserCredentials.Add(parts[0].Trim(), parts[1].Trim());

                }

            }

            public bool IsValidForAdmin(string username, string password)
            {

                return AdminCredentials.ContainsKey(username) && AdminCredentials[username] == password;

            }
            public bool IsValidForUser(string username, string password)
            {

                return UserCredentials.ContainsKey(username) && UserCredentials[username] == password;

            }
        }


        private void txtUser_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
