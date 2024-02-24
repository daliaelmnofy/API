using Day1.Database;
using Day1.Models;

namespace Day1.Services
{
    public class StudentRepo(APIsContext db) : IStudentRepo
    {
        private readonly APIsContext _db = db;

        public IEnumerable<Student> GetAll()
        {
            return _db.students.ToList();
        }

        public Student GetById(int id)
        {
            return _db.students.Find(id);
        }

        public Student GetByName(string name)
        {
            return _db.students.FirstOrDefault(d => d.Name == name);
        }

        public void Add(Student student)
        {
            _db.students.Add(student);
            _db.SaveChanges();
        }

        public void Update(Student student)
        {
            _db.students.Update(student);
            _db.SaveChanges();
        }

        public void Delete(int id)
        {
            var student = _db.students.Find(id);
            if (student != null)
            {
                _db.students.Remove(student);
                _db.SaveChanges();
            }
        }
    }
}
