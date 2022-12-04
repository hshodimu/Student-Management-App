using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StudentManagement.Models
{
    public class Grade
    {

        public Grade()
        {
            this.Students = new HashSet<Student>();
            this.Classes = new HashSet<Class>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string GradeName { get; set; }
        public string Section { get; set; }

        public ICollection<Student> Students { get; set; }
        public ICollection<Class> Classes { get; set; }
    }
}
