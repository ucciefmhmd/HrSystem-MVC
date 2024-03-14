using HrSystem.DAL.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HrSystem.BL.Interface
{
    public interface IInstructorRep
    {
        IEnumerable<Insturctors> GetAllData();
        Insturctors GetById(int id);
        void Create(Insturctors Inst);
        void Update(Insturctors Inst);
        void Delete(Insturctors Inst);
    }
}
