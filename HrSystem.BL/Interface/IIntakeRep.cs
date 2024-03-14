using HrSystem.DAL.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HrSystem.BL.Interface
{
    public interface IIntakeRep
    {
        IEnumerable<Intake> GetAllData();
        Intake GetById(int id);
        void Create(Intake intake);
        void Update(Intake intake);
        void Delete(Intake intake);
    }
}
