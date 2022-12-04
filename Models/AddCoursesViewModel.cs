using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StudentManagement.Models
{
    public class AddCoursesViewModel
    {

        [Required]
        public int CourseId { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        [ForeignKey("Grade")]
        public int GradeId { get; set; }
        public Grade Grade { get; set; }

        public virtual ICollection<Student> Students { get; set; }
    }
}
