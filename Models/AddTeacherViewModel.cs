using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StudentManagement.Models
{
    public class AddTeacherViewModel
    {
        [Required]
        public string Name { get; set; }

        [Required]
        public int HomeroomNumber { get; set; }

        [Required]
        public string Department { get; set; }

        [ForeignKey("Course")]
        public int CourseId { get; set; }
        public Course Course { get; set; }
    }
}
