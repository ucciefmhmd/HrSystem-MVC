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
    public class InstructorRep : IInstructorRep
    {
        private readonly HrSystemContext db;

        public InstructorRep(HrSystemContext db)
        {
            this.db = db;
        }
        public void Create(Insturctors Inst)
        {
            db.Insturctors.Add(Inst);
            db.SaveChanges();
        }

        public void Delete(Insturctors Inst)
        {
            db.Insturctors.Remove(Inst);
            db.SaveChanges();
        }

        public IEnumerable<Insturctors> GetAllData()
        {
            return db.Insturctors.Select(a => a);
        }

        public Insturctors GetById(int id)
        {
            return db.Insturctors.Find(id);
        }

        public void Update(Insturctors Inst)
        {
            db.Insturctors.Update(Inst);
            db.SaveChanges();
        }
    }
}
