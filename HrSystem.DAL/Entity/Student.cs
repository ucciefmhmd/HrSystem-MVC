using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HrSystem.DAL.Entity
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string address { get; set; }
        public DateTime DOB { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        [ForeignKey("Department")]
        public int Dept_ID { get; set; }
        [ForeignKey("Intake")]
        public int Intake_ID { get; set; }
        public virtual Department Department { get; set; }
        public virtual Intake Intake { get; set; }
    }
}
