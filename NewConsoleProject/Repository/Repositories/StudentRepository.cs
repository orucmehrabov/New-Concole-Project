using Domain.Models;
using Repository.Repositories.Interfaces;

namespace Repository.Repositories
{
    public class StudentRepository : IStudentRepository
    {
        public void Create(Student student)
        {
            throw new NotImplementedException();
        }

        public void Delete(int studentId)
        {
            throw new NotImplementedException();
        }

        public void Edit(Student student)
        {
            throw new NotImplementedException();
        }

        public List<Student> GetAll()
        {
            throw new NotImplementedException();
        }

        public Student GetById(int studentId)
        {
            throw new NotImplementedException();
        }

        public List<Student> SearchByName(string studentName)
        {
            throw new NotImplementedException();
        }

        public List<Student> SearchBySurname(string studentSurname)
        {
            throw new NotImplementedException();
        }

        public List<Student> SortingByAge()
        {
            throw new NotImplementedException();
        }
    }
}
