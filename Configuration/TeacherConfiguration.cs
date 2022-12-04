using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using StudentManagement.Models;

namespace StudentManagement.Configuration
{
    public class TeacherConfiguration : IEntityTypeConfiguration<Teacher>
    {
        public void Configure(EntityTypeBuilder<Teacher> builder)
        {
            builder.HasData
            (
                new Teacher 
                { 
                    Id= 1,  
                    Name = "Kim Abercrombie",
                    HomeroomNumber = 101,
                    Department = "Mathematics",
                    CourseId = 5,
                },
                new Teacher
                {
                    Id = 2,
                    Name = "Gytis Barzdukas",
                    HomeroomNumber = 102,
                    Department = "English",
                    CourseId = 9,
                },
                new Teacher
                {
                    Id = 3,
                    Name = "Peggy Justice",
                    HomeroomNumber = 103,
                    Department = "Economics",
                    CourseId = 13,
                },
                new Teacher
                {
                    Id = 4,
                    Name = "Fadi Fakhouri",
                    HomeroomNumber = 104,
                    Department = "Science",
                    CourseId = 1,
                },
                new Teacher
                {
                    Id = 5,
                    Name = "Roger Harui",
                    HomeroomNumber = 201,
                    Department = "Mathematics",
                    CourseId = 6,
                },
                new Teacher
                {
                    Id = 6,
                    Name = "Yan Li",
                    HomeroomNumber = 202,
                    Department = "English",
                    CourseId = 10,
                },
                new Teacher
                {
                    Id = 7,
                    Name = "Laura Norman",
                    HomeroomNumber = 203,
                    Department = "Economics",
                    CourseId = 14,
                },
                new Teacher
                {
                    Id = 8,
                    Name = "Nino Olivotto",
                    HomeroomNumber = 204,
                    Department = "Science",
                    CourseId = 2,
                },
                new Teacher
                {
                    Id = 9,
                    Name = "Wayne Tang",
                    HomeroomNumber = 301,
                    Department = "Mathematics",
                    CourseId = 7,
                },
                new Teacher
                {
                    Id = 10,
                    Name = "Meredith Alonso",
                    HomeroomNumber = 302,
                    Department = "English",
                    CourseId = 11,
                },
                new Teacher
                {
                    Id = 11,
                    Name = "Sophia Lopez",
                    HomeroomNumber = 303,
                    Department = "Economics",
                    CourseId = 15,
                },
                new Teacher
                {
                    Id = 12,
                    Name = "Meredith Browning",
                    HomeroomNumber = 304,
                    Department = "Science",
                    CourseId = 3,
                },
                new Teacher
                {
                    Id = 13,
                    Name = "Arturo Anand",
                    HomeroomNumber = 401,
                    Department = "Mathematics",
                    CourseId = 8,
                },
                new Teacher
                {
                    Id = 14,
                    Name = "Alexandra Walker",
                    HomeroomNumber = 402,
                    Department = "English",
                    CourseId = 12,
                },
                new Teacher
                {
                    Id = 15,
                    Name = "Carson Powell",
                    HomeroomNumber = 403,
                    Department = "Economics",
                    CourseId = 16,
                },
                new Teacher
                {
                    Id = 16,
                    Name = "Damien Jai",
                    HomeroomNumber = 404,
                    Department = "Science",
                    CourseId = 4,
                }
            );
        }
    }
}
