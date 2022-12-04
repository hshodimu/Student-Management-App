namespace StudentManagement.Models
{
    public class AddGradeViewModel
    {
        public string GradeName { get; set; }
        public string Section { get; set; }

        public ICollection<Student> Students { get; set; }
        public ICollection<Class> Classes { get; set; }
    }
}
