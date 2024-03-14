using HrSystem.DAL.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HrSystem.BL.Interface
{
    public interface IStudentRep
    {
        IEnumerable<Student> GetAllData();
        Student GetById(int id);
        void Create(Student Std);
        void Update(Student Std);
        void Delete(Student Std);
    }
}
