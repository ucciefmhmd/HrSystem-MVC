using HrSystem.DAL.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HrSystem.DAL.Database
{
    public class HrSystemContext : DbContext
    {
        public HrSystemContext(DbContextOptions<HrSystemContext> Opt):base(Opt)
        {}
        public DbSet<Student> Student {  get; set; }
        public DbSet<Department> Department {  get; set; }
        public DbSet<Insturctors> Insturctors {  get; set; }
        public DbSet<Courses> Courses {  get; set; }
        public DbSet<Intake> Intake {  get; set; }
        public DbSet<StudentCourses> StudentCourses {  get; set; }
        public DbSet<InstrutorCourses> InstrutorCourses {  get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<StudentCourses>().HasKey(a => new { a.Std_ID, a.Crs_ID});
            modelBuilder.Entity<InstrutorCourses>().HasKey(a => new { a.Inst_ID, a.Crs_ID});
        }
    }
}
