using Domain.Models;
using NewConsoleProject.Controllers;

public class Program
{
    public static void Main(string[] args)
    {
        Controller userController = new Controller();

        Console.WriteLine("Welcome to Code Academy!");

        while (true)
        {
            Console.WriteLine("Please select one option:");
            Console.WriteLine("1 - Register");
            Console.WriteLine("2 - Login");
            Console.WriteLine("3 - Exit");

            int option = int.Parse(Console.ReadLine());

            switch (option)
            {
                case 1:
                    userController.Register();
                    break;
                case 2:
                    userController.Login();
                    break;
                case 3:
                    Console.WriteLine("Goodbye!");
                    return;
                default:
                    Console.WriteLine("Invalid option. Please try again.");
                    break;
            }
        }
    }


    public static void Login()
    {
        Console.WriteLine("Login");
        Console.WriteLine("Please enter your Email:");
        string email = Console.ReadLine();

        Console.WriteLine("Please enter your Password:");
        string password = Console.ReadLine();

        User user = User.Find(u => u.Email == email && u.Password == password);

        if (user == null)
        {
            Console.WriteLine("Invalid email or password. Please try again.");
            return;
        }

        Console.WriteLine("Login successful. Redirecting to main menu...");
        MainMenu();
    }

    public static void MainMenu()
    {
        bool exit = false;

        while (!exit)
        {
            Console.WriteLine("Main Menu");
            Console.WriteLine("Please select one option:");
            Console.WriteLine("1 - Group Operations");
            Console.WriteLine("2 - Student Operations");
            Console.WriteLine("3 - Logout");

            string option = Console.ReadLine();

            switch (option)
            {
                case "1":
                    GroupOperations();
                    break;
                case "2":
                    StudentOperations();
                    break;
                case "3":
                    exit = true;
                    break;
                default:
                    Console.WriteLine("Invalid option. Please try again.");
                    break;
            }
        }
    }

    public static void GroupOperations()
    {
        // Implement group operations here
    }

    public static void StudentOperations()
    {
        // Implement student operations here
    }
}