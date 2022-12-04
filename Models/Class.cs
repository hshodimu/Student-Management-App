using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StudentManagement.Models
{
    public class Class
    {
        public Class() 
        {
            this.Students = new HashSet<Student>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        public int ClassNumber { get; set; }

        [Required]
        public string Term { get; set; }

        public ICollection<Student> Students;
    }
}
