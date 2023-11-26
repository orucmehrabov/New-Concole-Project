using Domain.Models;
using System.Text.RegularExpressions;
using Group = Domain.Models.Group;

namespace NewConsoleProject.Controllers
{
    public class Controller
    {
        private List<User> users;
        private List<Group> groups;
        private List<Student> students;

        public Controller()
        {
            users = new List<User>();
            groups = new List<Group>();
            students = new List<Student>();
        }

        public void Register()
        {
            Console.WriteLine("Registration");
            name:
            Console.Write("Name: ");
            string name = Console.ReadLine();
            if (name.Length < 3)
            {
                Console.WriteLine("Name is Short");
                goto name;
            }
            surname:
            Console.Write("Surname: ");
            string surname = Console.ReadLine();
            if (surname.Length < 3)
            {
                Console.WriteLine("Surname is Short");
                goto surname;
            }
            age:
            Console.Write("Age: ");
            int age = int.Parse(Console.ReadLine());
            if (age<0)
            {
                Console.WriteLine("age cant be minus");
                goto age;

            }
            email:
            Console.Write("Email: ");
            string email = Console.ReadLine();
            string pattern = @"^[a-zA-Z0-9_.+-]+@[a-zA-Z0-9-]+\.[a-zA-Z0-9-.]+$";
            Regex regex = new Regex(pattern);

            if (!(regex.IsMatch(email)))
            {
                Console.WriteLine("Wrong email structure");
                goto email;
            }
            password:
            Console.Write("Password: ");
            string password = Console.ReadLine();
            string pattern1 = @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[^\da-zA-Z]).{8,}$";
            Regex regex1 = new Regex(pattern1);

            if (!(regex1.IsMatch(password)))
            {
                Console.WriteLine("The password is invalid");
                goto password;
            }

            Console.Write("Confirm Password: ");
            string confirmPassword = Console.ReadLine();

            if (password != confirmPassword)
            {
                Console.WriteLine("Registration failed. Please try again.");
                goto password;
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

            void CreateGroup(string name, int capacity)
            {
                Group group = new Group
                {
                    Id = groups.Count + 1,
                    Name = name,
                    Capacity = capacity
                };

                groups.Add(group);
            }

            void DeleteGroup(int id)
            {
                Group group = groups.Find(g => g.Id == id);

                if (group != null)
                {
                    groups.Remove(group);
                }
            }

            void EditGroup(int id, string newName, int newCapacity)
            {
                Group group = groups.Find(g => g.Id == id);

                if (group != null)
                {
                    group.Name = newName;
                    group.Capacity = newCapacity;
                }
            }

            Group GetGroupById(int id)
            {
                return groups.Find(g => g.Id == id);
            }

            List<Group> GetAllGroups()
            {
                return groups;
            }

            List<Group> SearchGroupsByName(string name)
            {
                return groups.FindAll(g => g.Name.Contains(name));
            }

            List<Group> SortGroupsByCapacity()
            {
                groups.Sort((g1, g2) => g1.Capacity.CompareTo(g2.Capacity));
                return groups;
            }

        }

        public void StudentOperations()
        {
            Console.WriteLine("Student Operations");
            void CreateStudent(string fullname, int age)
            {
                Student student = new Student
                {
                    Id = students.Count + 1,
                    FullName = fullname,
                    Age = age
                };

                students.Add(student);
            }

            void DeleteStudent(int id)
            {
                Student student = students.Find(s => s.Id == id);

                if (student != null)
                {
                    students.Remove(student);
                }
            }

            void EditStudent(int id, string newFullname, int newAge)
            {
                Student student = students.Find(s => s.Id == id);

                if (student != null)
                {
                    student.FullName = newFullname;
                    student.Age = newAge;
                }
            }

            Student GetStudentById(int id)
            {
                return students.Find(s => s.Id == id);
            }

            List<Student> GetAllStudents()
            {
                return students;
            }

            List<Student> SearchStudentsByFullname(string fullname)
            {
                return students.FindAll(s => s.FullName.Contains(fullname));
            }

            List<Student> SortStudentsByAge()
            {
                students.Sort((s1, s2) => s1.Age.CompareTo(s2.Age));
                return students;
            }
        }
    }
}