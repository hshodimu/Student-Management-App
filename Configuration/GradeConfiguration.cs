using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Newtonsoft.Json.Converters;
using StudentManagement.Models;

namespace StudentManagement.Configuration
{
    public class GradeConfiguration : IEntityTypeConfiguration<Grade>
    {
        public void Configure(EntityTypeBuilder<Grade> builder)
        {

            builder.HasMany<Student>(g => g.Students)
                 .WithOne(s => s.Grade);

            builder.HasData
            (
                new Grade
                {
                    Id = 1,
                    GradeName = "Ninth",
                    Section = "Freshman"
                },
                 new Grade
                 {
                     Id = 2,
                     GradeName = "Tenth",
                     Section = "Sophomore"
                 },
                 new Grade
                 {
                     Id = 3,
                     GradeName = "Eleventh",
                     Section = "Junior"
                 },
                 new Grade
                 {
                     Id = 4,
                     GradeName = "Twelfth",
                     Section = "Senior"
                 }
            );
        }
    }
}
