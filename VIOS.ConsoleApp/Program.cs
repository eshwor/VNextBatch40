using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VIOS.DataAccess;

namespace VIOS.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("VIOS Console Application");

                Console.WriteLine("--------------------------------");
                Console.WriteLine("1. Add New User");
                Console.WriteLine("2. Update User");
                Console.WriteLine("3. Delete User");
                Console.WriteLine("4. Display All Users");
                Console.WriteLine("5. Find user by Id");
                Console.WriteLine("6. Exit");

                Console.WriteLine("Enter your choice");
                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        DataAccess.DataAccess data = new DataAccess.DataAccess();
                        UserLogin objUser = new UserLogin();
                        Console.WriteLine("Enter new UserName");
                        string UserName = Console.ReadLine();
                        string Password = Console.ReadLine();
                        objUser.UserName = UserName;
                        objUser.UserPassword = Password;
                        data.AddNewUser(objUser);
                        
                        Console.WriteLine("New User is Created");
                        //Todo
                        break;

                    case 2:
                        Console.WriteLine("User has been updated");
                        //Todo
                        break;
                    case 3:

                        Console.WriteLine("User has been Removed");
                        //Todo
                        break;

                    case 4:
                        Console.WriteLine("List of User");

                        DataAccess.DataAccess data1 = new DataAccess.DataAccess();
                        Console.WriteLine("UserName \tPassword");
                        foreach (var item in data1.GetAllUser())
                        {
                            Console.WriteLine("{0}\t{1}", item.UserName, item.UserPassword);

                        }
                        break;
                    case 5:
                        Console.WriteLine("User Info");
                        //Todo
                        break;
                    case 6:
                        Environment.Exit(0);
                        //Todo
                        break;

                }

                Console.ReadKey();

            }




        }
    }
}
