using System;
using UdemyTask.Models;
namespace UdemyTask
{
    class Program
    {
        public static void Main()
        {


            Console.Write("Email:");
            string Email = Console.ReadLine();
            Console.Write("Password:");
            string password = Console.ReadLine();
            User user = new User(Email, password);
            Console.Write("Fullname:");
            user.FullName = Console.ReadLine();
            Console.WriteLine("1.ShowInfo");
            Console.WriteLine("2. Create new Group");
            int menunum = Convert.ToInt32(Console.ReadLine());
            switch (menunum)
            {
                case 1:
                    user.ShowInfo();
                    return;
                case 2:
                    Console.Write("GroupNo:");
                    string GroupNo = Console.ReadLine();
                    Console.Write("StudentLimit:");
                    int StudentLimit = Convert.ToInt32(Console.ReadLine());
                    Group group = new Group(GroupNo, StudentLimit);
                    int num;
                    do
                    {


                        Console.WriteLine("  1. Show all students");
                        Console.WriteLine(" 2. Get student by id");
                        Console.WriteLine("3. Add student");
                        Console.WriteLine("0. Quit");
                        num = Convert.ToInt32(Console.ReadLine());
                        switch (num)
                        {
                            case 1:
                                group.GetAllStudent();
                                return;
                            case 2:
                                group.GetStudent(Convert.ToInt32(Console.ReadLine()));
                                return;
                            case 3:
                                Console.Write("Fullname:");
                                string FullName = Console.ReadLine();
                                Console.Write("Point:");
                                int point = Convert.ToInt32(Console.ReadLine());
                                group.AddStudent(FullName, point);
                                return;
                            default:
                                return;
                        }
                    } while (num != 0);
                    return;

                default:
                    return;




            }

        }
    }    
}

