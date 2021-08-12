using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookLibrary
{
    public class Login
    {
        Dictionary<string, string> credentials;
        public Login()
        {
            //ideally a reference to a data base but for now it's hard coded
            credentials = new Dictionary<string, string>();
            credentials.Add("Admin", "Password");
        }
        public bool login(string username, string password)
        {
            string enteredPassword;
            if(credentials.TryGetValue(username, out enteredPassword))
            {
                if (enteredPassword == password)
                {
                    return true;
                }
                else
                {
                    return false; //wrong password
                }
            }
            else
            {
                return false; //wrong username
            }
        }
    }
}
