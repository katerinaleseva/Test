﻿using System;


namespace FirstProject
{
    class Program
    {
        static void Main(string[] args)

        {
            User userA = new User();  
            User userB = new User();

            userA.Username = "test.user";
            Console.WriteLine("Username A: " + userA.Username);
            Console.WriteLine("Username B: " + userB.Username);
            Console.WriteLine("Role A: " + userA.Role);
            Console.WriteLine("Role B: " + userB.Role);

        }
    }
}