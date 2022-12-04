using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.OData.Edm;

namespace StudentManagement.Models
{
    public class AddStudentViewModel : Student
    {
        public AddStudentViewModel()
        {
            this.Courses = new HashSet<Course>();
        }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Dob { get; set; }

        [Required]
        [ForeignKey("Grade")]
        public int GradeId { get; set; }
        public Grade Grade { get; set; }

        [Required]
        [ForeignKey("Class")]
        public int ClassId { get; set; }
        public Class Class { get; set; }

        [Required]
        public virtual ICollection<Course> Courses { get; set; }
    }
}
