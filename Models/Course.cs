using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace StudentManagement.Models
{
    public class Course
    {

        public Course()
        {
            this.Students = new HashSet<Student>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int RecordNum { get; set; }

        [Required]
        public int CourseId { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        [ForeignKey("Grade")]
        public int GradeId { get; set; }
        public Grade Grade { get; set; }

        public virtual ICollection<Student> Students { get; set; }

        public Teacher Teacher { get; set; }
    }
}
