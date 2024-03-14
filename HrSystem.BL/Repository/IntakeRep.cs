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
    public class IntakeRep : IIntakeRep
    {
        private readonly HrSystemContext db;

        public IntakeRep(HrSystemContext db)
        {
            this.db = db;
        }
        public void Create(Intake intake)
        {
            db.Intake.Add(intake);
            db.SaveChanges();
        }

        public void Delete(Intake intake)
        {
            db.Intake.Remove(intake);
            db.SaveChanges();
        }

        public IEnumerable<Intake> GetAllData()
        {
            return db.Intake.Select(a => a);
        }

        public Intake GetById(int id)
        {
            return db.Intake.Find(id);
        }

        public void Update(Intake intake)
        {
            db.Intake.Update(intake);
            db.SaveChanges();
        }
    }
}
