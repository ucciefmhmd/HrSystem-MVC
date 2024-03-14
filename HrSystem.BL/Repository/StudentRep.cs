using HrSystem.BL.Interface;
using HrSystem.DAL.Database;
using HrSystem.DAL.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HrSystem.BL.Repository
{
    public class StudentRep : IStudentRep
    {
        private readonly HrSystemContext db;

        public StudentRep(HrSystemContext db)
        {
            this.db = db;
        }
        public void Create(Student Std)
        {
            db.Student.Add(Std);
            db.SaveChanges();
        }

        public void Delete(Student Std)
        {
            db.Student.Remove(Std);
            db.SaveChanges();
        }

        public IEnumerable<Student> GetAllData()
        {
            return db.Student.Include(a=>a.Department).Include(a=>a.Intake).Select(a => a);
        }

        public Student GetById(int id)
        {
            return db.Student.Find(id);
        }

        public void Update(Student Std)
        {
            db.Student.Update(Std);
            db.SaveChanges();
        }
    }
}