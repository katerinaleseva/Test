﻿using System;
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
        private string firstName;
        private string lastName;
        private string password;
       

        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }


        public string FirstNAme
        {
            get { return firstName; }
            set { firstName = value; }
        }

        public string Fullname
        {
            get
            {
                return this.firstName + " " + this.lastName;
            }
        }

        public string Password
        {
            set
            {
                if (string.IsNullOrEmpty(password))
                {
                    password = value;
                }
                else
                {
                    Console.WriteLine("Password for {0}has already been set. Please use ChangePassword() instead.", this.Username);
                }
            }
        }



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

        public int Age { get; set; }

        public bool ChangePassword(string currentPassword, string newPassword)
        {
            bool passwordHasBeenChanged = false;

            if (string.IsNullOrEmpty(this.password))
            {
                Console.WriteLine("Password for {0} has not been set yet.", this.Username);
            }
            else if (this.password != currentPassword)
            {
                Console.WriteLine("Invalid current password for " + this.Username);
            }
            else
            {
                this.password = newPassword;
                Console.WriteLine("Successfully changed password for "+this.Username);
            }

            return passwordHasBeenChanged;
        }

        public void ViewProfile()
        {
            Console.WriteLine("Full name: " + this.Fullname);
            Console.WriteLine("Age: " + this.Age);
            Console.WriteLine("Username: " + this.Username);
            Console.WriteLine("Role: " + this.Role);
            Console.WriteLine();
        }

        public void ViewMainMenu()
        {
            Console.WriteLine("Logout");
            Console.WriteLine("Home");
            Console.WriteLine("Tasks");
            Console.WriteLine("View profile");
            Console.WriteLine();
        }


    
            
     }
}
