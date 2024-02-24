using Day1.Models;

namespace Day1.Services
{
    public interface IStudentRepo
    {
        IEnumerable<Student> GetAll();
        Student GetById(int id);
        Student GetByName(string name);
        void Add(Student student);
        void Update(Student student);
        void Delete(int id);
    }
}
