using System;


namespace FirstProject
{
    class Program
    {
        static void Main(string[] args)

        {
            User userA = new User("test.user");  
            User userB = new User("user.b");
            AdminUser adminC = new AdminUser("test.admin");

            userA.Role = "Regular User";
            adminC.FirstNAme = "test";
            adminC.LastName = "last";
            adminC.AddTask("Task C");
            Console.WriteLine(adminC.Fullname + " "+ adminC.Role);
            
           
            /*
            userA.Username = "test.user";
            /*Console.WriteLine("Username A: " + userA.Username);
            Console.WriteLine("Username B: " + userB.Username);
            Console.WriteLine("Role A: " + userA.Role);
            Console.WriteLine("Role B: " + userB.Role);

            userA.FirstNAme = "First Name A";
            userA.LastName = "Last Name A";

            userB.FirstNAme = "First Name B";
            userB.LastName = "Last Name B";


            userA.Password = "123";
            userA.Password = "321";
            

            userA.Age = 21;

            userA.ViewProfile();
            userB.ViewProfile();

            bool passwordForAChanged = userA.ChangePassword("123", "1234");
            Console.WriteLine(passwordForAChanged);


            passwordForAChanged = userA.ChangePassword("123", "1234");
            Console.WriteLine(passwordForAChanged);

            passwordForAChanged = userA.ChangePassword("123", "1234");
            Console.WriteLine(passwordForAChanged);

            bool passwordForBChanged = userB.ChangePassword("abc", "478");
            Console.WriteLine(passwordForBChanged); */
           


        }
    }
}
