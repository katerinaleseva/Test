using System;


namespace FirstProject
{
    class Program
    {
        static void Main(string[] args)

        {
            User userA = new User();  
            User userB = new User();

            userA.Username = "test.user";
            /*Console.WriteLine("Username A: " + userA.Username);
            Console.WriteLine("Username B: " + userB.Username);
            Console.WriteLine("Role A: " + userA.Role);
            Console.WriteLine("Role B: " + userB.Role);*/

            userA.FirstNAme = "First Name A";
            userA.LastName = "Last Name A";

            userB.FirstNAme = "First Name B";
            userB.LastName = "Last Name B";


            userA.Password = "123";
            userA.Password = "321";
            

            userA.Age = 21;

            userA.ChangePassword("123", "1234");
            userA.ChangePassword("123", "1234");



        }
    }
}
