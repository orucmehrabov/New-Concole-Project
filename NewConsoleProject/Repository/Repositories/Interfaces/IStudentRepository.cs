using Domain.Models;

namespace Repository.Repositories.Interfaces
{
    public interface IStudentRepository
    {
        void Create(Student student);
        void Delete(int studentId);
        void Edit(Student student);
        Student GetById(int studentId);
        List<Student> GetAll();
        List<Student> SearchByName(string studentName);
        List<Student> SearchBySurname(string studentSurname);
        List<Student> SortingByAge();
    }
}
