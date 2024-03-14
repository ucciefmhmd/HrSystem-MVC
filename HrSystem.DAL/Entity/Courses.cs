using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HrSystem.DAL.Entity
{
    public class Courses
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int MinDegree { get; set; }
        public int MaxDegree { get; set; }
        public string Code { get; set; }
        public string? Description { get; set; }
    }
}
