using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HrSystem.DAL.Entity
{
    public class InstrutorCourses
    {
        public int Inst_ID { get; set; }
        public int Crs_ID { get; set; }
        public virtual Insturctors Insturctors { get; set; }
        public virtual Courses Courses { get; set; }
    }
}
