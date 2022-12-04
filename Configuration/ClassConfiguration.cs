using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using StudentManagement.Models;

namespace StudentManagement.Configuration
{
    public class ClassConfiguration : IEntityTypeConfiguration<Class>
    {
        public void Configure(EntityTypeBuilder<Class> builder)
        {
            builder.HasMany<Student>(c => c.Students)
                 .WithOne(s => s.Class);

            builder.HasData
            (
                new Class
                {
                    Id = 1,
                    ClassNumber = 0,
                    Term = "Fall 2019"
                },
                new Class
                {
                    Id = 2,
                    ClassNumber = 0,
                    Term = "Spring 2020"
                },
                new Class
                {
                    Id = 3,
                    ClassNumber = 0,
                    Term = "Fall 2020"
                },
                new Class
                {
                    Id = 4,
                    ClassNumber = 0,
                    Term = "Spring 2021",
                }
            );
        }
    }
}
