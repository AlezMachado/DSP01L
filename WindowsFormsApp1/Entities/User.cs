using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Entities
{
    public class User
    {
        private string name;
        private string lastName;
        private string userName;
        private string password;

        public string Name { get => name; set => name = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public string UserName { get => userName; set => userName = value; }
        public string Password { get => password; set => password = value; }

        public void Register(string n, string ln, string us, string p)
        {
            name = n;
            lastName = ln; 
            userName = us; 
            password = p;
        }

        public bool Login (string us, string p)
        {
            if (userName == us && password == p) return true;
            else return false;
        }
    }
}
