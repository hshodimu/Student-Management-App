using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StudentManagement.Models
{
    public class AddClassesViewModel
    {
        [Required]
        public int ClassNumber { get; set; }

        [Required]
        public string Term { get; set; }

        public ICollection<Student> Students;
    }
}
