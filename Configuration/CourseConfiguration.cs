using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using StudentManagement.Models;

namespace StudentManagement.Configuration
{
    public class CourseConfiguration : IEntityTypeConfiguration<Course>
    {
        public void Configure(EntityTypeBuilder<Course> builder)

        {
            builder.HasOne(c => c.Teacher)
                 .WithOne(t => t.Course);

            builder.HasData
            (
                new Course
                {
                    RecordNum= 1,
                    CourseId = 1042,
                    Name = "Biology",
                    GradeId = 1,
                },
                new Course
                {
                    RecordNum = 2,
                    CourseId = 2050,
                    Name = "Chemistry",
                    GradeId = 2,
                },
                 new Course
                 {
                     RecordNum = 3,
                     CourseId = 3061,
                     Name = "Physics",
                     GradeId = 3,
                 },
                new Course
                {
                    RecordNum = 4,
                    CourseId = 4070,
                    Name = "Astronomy",
                    GradeId = 4,
                },
                new Course
                {
                    RecordNum = 5,
                    CourseId = 1010,
                    Name = "Algebra",
                    GradeId = 1,
                },
                new Course
                {
                    RecordNum = 6,
                    CourseId = 2141,
                    Name = "Trigonometry",
                    GradeId = 2,
                },
                 new Course
                 {
                     RecordNum = 7,
                     CourseId = 3045,
                     Name = "Calculus I",
                     GradeId = 3,
                 },
                new Course
                {
                    RecordNum = 8,
                    CourseId = 4045,
                    Name = "Calculus II",
                    GradeId = 4,
                },
                new Course
                {
                    RecordNum = 9,
                    CourseId = 1043,
                    Name = "Literature",
                    GradeId = 1,
                },
                new Course
                {
                    RecordNum = 10,
                    CourseId = 2030,
                    Name = "Poetry",
                    GradeId = 2,
                },
                 new Course
                 {
                     RecordNum = 11,
                     CourseId = 3021,
                     Name = "Composition",
                     GradeId = 3,
                 },
                new Course
                {
                    RecordNum = 12,
                    CourseId = 4021,
                    Name = "Creative writing",
                    GradeId = 4,
                },
                new Course
                {
                    RecordNum = 13,
                    CourseId = 1022,
                    Name = "Microeconomics",
                    GradeId = 1,
                },
                new Course
                {
                    RecordNum = 14,
                    CourseId = 2041,
                    Name = "Macroeconomics",
                    GradeId = 2,
                },
                 new Course
                 {
                     RecordNum = 15,
                     CourseId = 3061,
                     Name = "Quantitative",
                     GradeId = 3,
                 },
                new Course
                {
                    RecordNum = 16,
                    CourseId = 4061,
                    Name = "Financial Markets",
                    GradeId = 4,
                }
            );
        }
    }
}
