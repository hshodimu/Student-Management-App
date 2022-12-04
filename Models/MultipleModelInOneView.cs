using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using StudentManagement.Data;

namespace StudentManagement.Models
{
    public class MultipleModelInOneView
    {
        public IEnumerable<Course> Courses { get; set; }
        public IEnumerable<Student> Students { get; set; }

        public IEnumerable<Teacher> Teachers { get; set; }

        public IEnumerable<Class> Classes { get; set; }

        public IEnumerable<Grade> Grades { get; set; }

        /*public IEnumerable<StudentCourse> StudentCourses { get; set; }*/

        public IEnumerable<AddStudentViewModel> AddStudentViewModel { get; set; }

        public IEnumerable<AddCoursesViewModel> AddCoursesViewModel { get; set; }

    }
}
