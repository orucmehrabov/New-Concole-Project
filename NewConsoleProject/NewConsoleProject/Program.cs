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
}