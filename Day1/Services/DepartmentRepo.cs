using Day1.Database;
using Day1.Models;
using System.Collections.Generic;
using System.Linq;

namespace Day1.Services
{
    public class DepartmentRepo : IDepartmentRepo
    {
        private readonly APIsContext _db;

        public DepartmentRepo(APIsContext db)
        {
            _db = db;
        }

        public IEnumerable<Department> GetAll()
        {
            return _db.departments.ToList();
        }

        public Department GetById(int id)
        {
            return _db.departments.Find(id);
        }

        public Department GetByName(string name)
        {
            return _db.departments.FirstOrDefault(d => d.Name == name);
        }

        public void Add(Department department)
        {
            _db.departments.Add(department);
            _db.SaveChanges();
        }

        public void Update(Department department)
        {
            _db.departments.Update(department);
            _db.SaveChanges();
        }

        public void Delete(int id)
        {
            var department = _db.departments.Find(id);
            if (department != null)
            {
                _db.departments.Remove(department);
                _db.SaveChanges();
            }
        }
    }
}
