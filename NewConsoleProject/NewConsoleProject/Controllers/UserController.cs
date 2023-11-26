using Domain.Models;

namespace NewConsoleProject.Controllers
{
    public class UserController
    {
        private List<User> users;
        private List<Group> groups;
        private List<Student> students;

        public UserController()
        {
            users = new List<User>();
            groups = new List<Group>();
            students = new List<Student>();
        }

        public void Register()
        {
            Console.WriteLine("Registration");
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Surname: ");
            string surname = Console.ReadLine();
            Console.Write("Age: ");
            int age = int.Parse(Console.ReadLine());
            Console.Write("Email: ");
            string email = Console.ReadLine();
            Console.Write("Password: ");
            string password = Console.ReadLine();
            Console.Write("Confirm Password: ");
            string confirmPassword = Console.ReadLine();

            if (password != confirmPassword || !email.Contains("@ishare"))
            {
                Console.WriteLine("Registration failed. Please try again.");
                return;
            }

            User newUser = new User
            {
                Name = name,
                Surname = surname,
                Age = age,
                Email = email,
                Password = password,
                ConfirmPassword = confirmPassword
            };

            users.Add(newUser);

            Console.WriteLine("Registration success. Please select one option:");
            Console.WriteLine("1 - Login");
            Console.WriteLine("2 - Register");
        }

        public void Login()
        {
            Console.WriteLine("Login");
            Console.Write("Email: ");
            string email = Console.ReadLine();
            Console.Write("Password: ");
            string password = Console.ReadLine();

            User user = users.Find(u => u.Email == email && u.Password == password);

            if (user == null)
            {
                Console.WriteLine("Login failed. Please try again.");
                return;
            }

            Console.WriteLine("Login success. Redirecting to main menu...");
            MainMenu();
        }

        public void MainMenu()
        {
            Console.WriteLine("Main Menu");
            Console.WriteLine("1 - Group Operations");
            Console.WriteLine("2 - Student Operations");
            Console.WriteLine("3 - Logout");

            int option = int.Parse(Console.ReadLine());

            switch (option)
            {
                case 1:
                    GroupOperations();
                    break;
                case 2:
                    StudentOperations();
                    break;
                case 3:
                    Console.WriteLine("Logged out. Goodbye!");
                    break;
                default:
                    Console.WriteLine("Invalid option. Please try again.");
                    MainMenu();
                    break;
            }
        }

        public void GroupOperations()
        {
            Console.WriteLine("Group Operations");
            // Implement group operations here
        }

        public void StudentOperations()
        {
            Console.WriteLine("Student Operations");
            // Implement student operations here
        }
    }
}