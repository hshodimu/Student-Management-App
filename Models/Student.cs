using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.OData.Edm;

namespace StudentManagement.Models
{
	public class Student
	{
        public Student()
        {
            this.Courses = new HashSet<Course>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

		[Required]
		public string Name { get; set; }

		[Required]
		public string Dob { get; set; }

        [ForeignKey("Grade")]
		public System.Nullable<int> GradeId { get; set; }
        public Grade Grade { get; set; }

        [Required]
		[ForeignKey("Class")]
        public int ClassId { get; set; }
		public Class Class { get; set; }

        [Required]
        public virtual ICollection<Course> Courses { get; set; }

    }
}
