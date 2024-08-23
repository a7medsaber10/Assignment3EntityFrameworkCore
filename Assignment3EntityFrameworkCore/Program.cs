using Assignment3EntityFrameworkCore.Contexts;
using Assignment3EntityFrameworkCore.Entities;

namespace Assignment3EntityFrameworkCore
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region CRUD Operations on student table
            using ITIDbContext dbContext = new ITIDbContext();

            #region Insert Students
            Student student1 = new Student()
            {
                FName = "Ahmed",
                LName = "Saber",
                Address = "october",
                Age = 20,
            };

            Student student2 = new Student()
            {
                FName = "Abdo",
                LName = "Saber",
                Address = "october",
                Age = 22,
            };

            dbContext.Add(student1);
            dbContext.Add(student2);
            #endregion

            #region Insert Courses
            Course course1 = new Course()
            {
                Name = "Database",
                Duration = 50,
                Description = "Database is about tables and relations"

            };

            Course course2 = new Course()
            {
                Name = "AI",
                Duration = 150,
                Description = "AI is to make machines smart like humans"

            };

            dbContext.Add(course1);
            dbContext.Add(course2);
            #endregion

            #region Insert Departments
            Department department1 = new Department()
            {
                Name = "CS"
            };

            Department department2 = new Department()
            {
                Name = "IS"
            };

            dbContext.Add(department1);
            dbContext.Add(department2);
            #endregion

            #region Insert Instructors
            Instructor instructor1 = new Instructor()
            {
                Name = "Mohamed",
                Salary = 5_000,
                Address = "6 October",
                Bonus = 50,
                HourRate = 10
            };

            Instructor instructor2 = new Instructor()
            {
                Name = "Gamal",
                Salary = 7_000,
                Address = "New Cairo",
                Bonus = 100,
                HourRate = 30
            };

            dbContext.Add(instructor1);
            dbContext.Add(instructor2);
            #endregion

            #region Insert Topics
            Topic topic1 = new Topic()
            {
                Name = "AIAndMachineLearning"
            };

            Topic topic2 = new Topic()
            {
                Name = "FullStackDevelopment"
            }; 

            dbContext.Add(topic1);
            dbContext.Add(topic2);
            #endregion


            #region Select
            //var student = (from s in dbContext.Students
            //               where s.Id == 2
            //               select s).FirstOrDefault(); 
            #endregion

            #region Update

            //Console.WriteLine(dbContext.Entry(student).State); // unchanged

            //Console.WriteLine(student?.FName ?? "N/A");


            //student.FName = "mohamed";

            //Console.WriteLine(dbContext.Entry(student).State); // modified 
            #endregion

            #region Delete
            //dbContext.Students.Remove(student);
            //Console.WriteLine(dbContext.Entry(student).State); //Deleted
            #endregion

            dbContext.SaveChanges();
            #endregion
        }
    }
}
