using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LUS.UserInterfaceLayer
{
    class LoginAuthenticator
    {
        private Dictionary<string, string> AdminCredentials = new Dictionary<string, string>();
        private Dictionary<string, string> UserCredentials = new Dictionary<string, string>();

        public LoginAuthenticator()
        {
            //change the path
            var AdminLogins = File.ReadAllLines(ConfigurationManager.AppSettings["ADMIN_LOGINS_csv"]);
            foreach (var AdminLogin in AdminLogins)
            {
                var EachAdmin = AdminLogin.Split(',');
                AdminCredentials.Add(EachAdmin[0].Trim(), EachAdmin[1].Trim());

            }
           
            var UserLogins = File.ReadAllLines(ConfigurationManager.AppSettings["USER_LOGINS_csv"]);
            foreach (var UserLogin in UserLogins)
            {
                var EachUser = UserLogin.Split(',');
                UserCredentials.Add(EachUser[0].Trim(), EachUser[1].Trim());

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
}
