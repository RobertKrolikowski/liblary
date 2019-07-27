using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace library
{
    public class User
    {
        public string firstName{ get; set; }
        public string lastName{ get; set; }
        public string phone { get; set; }
        public string email { get; set; }
        public bool isAdmin { get; set; }

        public User()
        {
            this.firstName = "";
            this.lastName = "";
            this.phone = "";
            this.email = "";
            this.isAdmin = false;
        }

        public User(string firstName, string lastName, string phone, string email, bool isAdmin)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.phone = phone;
            this.email = email;
            this.isAdmin = isAdmin;
        }
    }

    
}
