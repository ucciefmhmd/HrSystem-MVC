using HrSystem.BL.Interface;
using HrSystem.DAL.Database;
using HrSystem.DAL.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HrSystem.BL.Repository
{
    public class DepartmentRep : IDepartmentRep
    {
        private readonly HrSystemContext db;

        public DepartmentRep(HrSystemContext db)
        {
            this.db = db;
        }
        public void Create(Department Dept)
        {
            db.Department.Add(Dept);
            db.SaveChanges();
        }

        public void Delete(Department Dept)
        {
            db.Department.Remove(Dept);
            db.SaveChanges();
        }

        public IEnumerable<Department> GetAllData()
        {
            return db.Department.Select(a => a);
        }

        public Department GetById(int id)
        {
            return db.Department.Find(id);
        }

        public void Update(Department Dept)
        {
            db.Department.Update(Dept);
            db.SaveChanges();
        }
    }
}
