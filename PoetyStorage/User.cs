using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoetyStorage
{
    class User
    {
        public int userid { get; set; }
        public string login { get; set; }
        public string password { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public bool admin { get; set; }

        public User()
        {
            this.userid = 0;
            this.login = "";
            this.password = "";
            this.firstName = "";
            this.lastName = "";
            this.admin = false;
        }

        public User(int userid, string login, string password, string firstname, string lastname, bool admin)
        {
            this.userid = userid;
            this.login = login;
            this.password = password;
            this.firstName = firstname;
            this.lastName = lastname;
            this.admin = false;
        }
    }
}
