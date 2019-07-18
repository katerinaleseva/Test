using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstProject
{
    class User
    {
        private string username;
        private string role = "Regular user";

        public string Username
        {
            get { return username; }
            set { username = value; }

        }

        public string Role
        {
            get { return role; }
            set { role = value; }

        }
    }
}
