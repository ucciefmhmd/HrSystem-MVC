using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HrSystem.DAL.Entity
{
    public class StudentCourses
    {
        public int Std_ID { get; set; }
        public int Crs_ID { get; set; }
        public int Grade { get; set; }
        public virtual Student Student { get; set; }
        public virtual Courses Courses { get; set; }
    }
}
