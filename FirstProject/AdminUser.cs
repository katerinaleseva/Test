using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstProject
{
    class AdminUser : User
    {
        public AdminUser(string username) : base(username)
        {
            this.Role = "Admin User";
        }

        public AdminUser(string username, string role, string fullname, string lastName) : base(username, role, fullname, lastName)
        {
            this.Role = "Admin User";
        }
    }
}
