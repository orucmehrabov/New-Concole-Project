using Domain.Models;
using Repository.Repositories.Interfaces;

namespace Services.Services
{
    public class StudentService
    {
        private readonly IStudentRepository _studentRepository;

        public StudentService(IStudentRepository studentRepository)
        {
            _studentRepository = studentRepository;
        }

        public void Create(Student student)
        {
            _studentRepository.Create(student);
        }

        public void Delete(int studentId)
        {
            _studentRepository.Delete(studentId);
        }

        public void Edit(Student student)
        {
            _studentRepository.Edit(student);
        }

        public Student GetById(int studentId)
        {
            return _studentRepository.GetById(studentId);
        }

        public List<Student> GetAll()
        {
            return _studentRepository.GetAll();
        }

        public List<Student> SearchByName(string studentName)
        {
            return _studentRepository.SearchByName(studentName);
        }

        public List<Student> SearchBySurname(string studentSurname)
        {
            return _studentRepository.SearchBySurname(studentSurname);
        }

        public List<Student> SortingByAge()
        {
            return _studentRepository.SortingByAge();
        }
    }
}
