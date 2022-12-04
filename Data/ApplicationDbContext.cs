using System.Data;
using System.Reflection.Metadata;
using Microsoft.EntityFrameworkCore;
using StudentManagement.Configuration;
using StudentManagement.Models;


namespace StudentManagement.Data
{
	public class ApplicationDbContext : DbContext
    {
		public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options): base(options) 
		{

		}
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new StudentConfiguration());
            modelBuilder.ApplyConfiguration(new CourseConfiguration());
            modelBuilder.ApplyConfiguration(new ClassConfiguration());
            modelBuilder.ApplyConfiguration(new GradeConfiguration());
            modelBuilder.ApplyConfiguration(new TeacherConfiguration());

        }

        public DbSet<Student> Students { get; set; }

        public DbSet<Teacher> Teachers { get; set; }

        public DbSet<Class> Classes { get; set; }

        public DbSet<Grade> Grades { get; set; }

        public DbSet<Course> Courses { get; set; }

        /*public DbSet<StudentCourse> StudentCourse { get; set; }*/
    }
}
