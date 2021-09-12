using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TanksMenu
{
    public class User
    {
        public int Id { get; set; }

        public string Email { get; set; }

        public string Password { get; set; }

        public User(string email, string password)
        {
            this.Email = email;
            this.Password = password;
        }
    }
}