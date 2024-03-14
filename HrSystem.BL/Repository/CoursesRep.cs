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
    public class CoursesRep : ICourseRep
    {
        private readonly HrSystemContext db;

        public CoursesRep(HrSystemContext db)
        {
            this.db = db;
        }
        public void Create(Courses Crs)
        {
            db.Courses.Add(Crs);
            db.SaveChanges();
        }

        public void Delete(Courses Crs)
        {
            db.Courses.Remove(Crs);
            db.SaveChanges();
        }

        public IEnumerable<Courses> GetAllData()
        {
            return db.Courses.Select(a => a);
        }

        public Courses GetById(int id)
        {
            return db.Courses.Find(id);
        }

        public void Update(Courses Crs)
        {
            db.Courses.Update(Crs);
            db.SaveChanges();
        }
    }
}
