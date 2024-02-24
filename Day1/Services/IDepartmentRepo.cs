using Day1.Models;

namespace Day1.Services
{
    public interface IDepartmentRepo
    {
        IEnumerable<Department> GetAll();
        Department GetById(int id);
        Department GetByName(string name);
        void Add(Department department);
        void Update(Department department);
        void Delete(int id);
    }
}
