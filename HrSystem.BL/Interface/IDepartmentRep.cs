using HrSystem.DAL.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HrSystem.BL.Interface
{
    public interface IDepartmentRep
    {
        IEnumerable<Department> GetAllData();
        Department GetById(int id);
        void Create(Department Dept);
        void Update(Department Dept);
        void Delete(Department Dept);
    }
}
