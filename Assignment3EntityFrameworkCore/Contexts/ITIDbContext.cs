using Assignment3EntityFrameworkCore.Configurations;
using Assignment3EntityFrameworkCore.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3EntityFrameworkCore.Contexts
{
    public class ITIDbContext : DbContext
    {
        public DbSet<Student> Students { get; set; }

        public DbSet<Course> Courses { get; set; }

        public DbSet<Instructor> Instructors { get; set; }

        public DbSet<Topic> Topics { get; set; }

        public DbSet<Department> Departments { get; set; }

        public DbSet<CourseInstructor> CourseInstructors { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //optionsBuilder.UseSqlServer("Data Source = DESKTOP-4J5GA96 ; Initial Catalog = ITI_EF ; Integrated Security = True");
            optionsBuilder.UseSqlServer("Server = . ; Database = ITI_EFCore03 ; Trusted_Connection = True; Encrypt = False");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new StudentsConfig());

            modelBuilder.ApplyConfiguration(new CoursesConfig());

            modelBuilder.ApplyConfiguration(new DepartmentsConfig());

            modelBuilder.ApplyConfiguration(new InstructorsConfig());

            modelBuilder.ApplyConfiguration(new TopicsConfig());

            //modelBuilder.Entity<Instructor>()
            //            .HasMany(I => I.InstructorCourses)
            //            .WithOne(IC => IC.Instructor);

            //modelBuilder.Entity<Course>()
            //            .HasMany(C => C.CourseInstructors)
            //            .WithOne(CI => CI.Course);

            modelBuilder.Entity<CourseInstructor>()
                        .HasKey(CI => new {CI.CourseId, CI.InstructorId});

            modelBuilder.Entity<StudentCourse>()
                        .HasKey(SC => new {SC.StudentId, SC.CourseId});
        }
    }
}
