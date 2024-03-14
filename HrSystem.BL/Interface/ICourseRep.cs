using HrSystem.DAL.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HrSystem.BL.Interface
{
    public interface ICourseRep
    {
        IEnumerable<Courses> GetAllData();
        Courses GetById(int id);
        void Create(Courses Crs);
        void Update(Courses Crs);
        void Delete(Courses Crs);
    }
}
