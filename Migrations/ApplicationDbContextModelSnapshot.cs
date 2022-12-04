﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using StudentManagement.Data;

#nullable disable

namespace StudentManagement.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("CourseStudent", b =>
                {
                    b.Property<int>("CoursesRecordNum")
                        .HasColumnType("int");

                    b.Property<int>("StudentsId")
                        .HasColumnType("int");

                    b.HasKey("CoursesRecordNum", "StudentsId");

                    b.HasIndex("StudentsId");

                    b.ToTable("CourseStudent");
                });

            modelBuilder.Entity("StudentManagement.Models.Class", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("ClassNumber")
                        .HasColumnType("int");

                    b.Property<int?>("GradeId")
                        .HasColumnType("int");

                    b.Property<string>("Term")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("GradeId");

                    b.ToTable("Classes");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            ClassNumber = 0,
                            Term = "Fall 2019"
                        },
                        new
                        {
                            Id = 2,
                            ClassNumber = 0,
                            Term = "Spring 2020"
                        },
                        new
                        {
                            Id = 3,
                            ClassNumber = 0,
                            Term = "Fall 2020"
                        },
                        new
                        {
                            Id = 4,
                            ClassNumber = 0,
                            Term = "Spring 2021"
                        });
                });

            modelBuilder.Entity("StudentManagement.Models.Course", b =>
                {
                    b.Property<int>("RecordNum")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("RecordNum"), 1L, 1);

                    b.Property<int>("CourseId")
                        .HasColumnType("int");

                    b.Property<int>("GradeId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("RecordNum");

                    b.HasIndex("GradeId");

                    b.ToTable("Courses");

                    b.HasData(
                        new
                        {
                            RecordNum = 1,
                            CourseId = 1042,
                            GradeId = 1,
                            Name = "Biology"
                        },
                        new
                        {
                            RecordNum = 2,
                            CourseId = 2050,
                            GradeId = 2,
                            Name = "Chemistry"
                        },
                        new
                        {
                            RecordNum = 3,
                            CourseId = 3061,
                            GradeId = 3,
                            Name = "Physics"
                        },
                        new
                        {
                            RecordNum = 4,
                            CourseId = 4070,
                            GradeId = 4,
                            Name = "Astronomy"
                        },
                        new
                        {
                            RecordNum = 5,
                            CourseId = 1010,
                            GradeId = 1,
                            Name = "Algebra"
                        },
                        new
                        {
                            RecordNum = 6,
                            CourseId = 2141,
                            GradeId = 2,
                            Name = "Trigonometry"
                        },
                        new
                        {
                            RecordNum = 7,
                            CourseId = 3045,
                            GradeId = 3,
                            Name = "Calculus I"
                        },
                        new
                        {
                            RecordNum = 8,
                            CourseId = 4045,
                            GradeId = 4,
                            Name = "Calculus II"
                        },
                        new
                        {
                            RecordNum = 9,
                            CourseId = 1043,
                            GradeId = 1,
                            Name = "Literature"
                        },
                        new
                        {
                            RecordNum = 10,
                            CourseId = 2030,
                            GradeId = 2,
                            Name = "Poetry"
                        },
                        new
                        {
                            RecordNum = 11,
                            CourseId = 3021,
                            GradeId = 3,
                            Name = "Composition"
                        },
                        new
                        {
                            RecordNum = 12,
                            CourseId = 4021,
                            GradeId = 4,
                            Name = "Creative writing"
                        },
                        new
                        {
                            RecordNum = 13,
                            CourseId = 1022,
                            GradeId = 1,
                            Name = "Microeconomics"
                        },
                        new
                        {
                            RecordNum = 14,
                            CourseId = 2041,
                            GradeId = 2,
                            Name = "Macroeconomics"
                        },
                        new
                        {
                            RecordNum = 15,
                            CourseId = 3061,
                            GradeId = 3,
                            Name = "Quantitative"
                        },
                        new
                        {
                            RecordNum = 16,
                            CourseId = 4061,
                            GradeId = 4,
                            Name = "Financial Markets"
                        });
                });

            modelBuilder.Entity("StudentManagement.Models.Grade", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("GradeName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Section")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Grades");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            GradeName = "Ninth",
                            Section = "Freshman"
                        },
                        new
                        {
                            Id = 2,
                            GradeName = "Tenth",
                            Section = "Sophomore"
                        },
                        new
                        {
                            Id = 3,
                            GradeName = "Eleventh",
                            Section = "Junior"
                        },
                        new
                        {
                            Id = 4,
                            GradeName = "Twelfth",
                            Section = "Senior"
                        });
                });

            modelBuilder.Entity("StudentManagement.Models.Student", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("ClassId")
                        .HasColumnType("int");

                    b.Property<string>("Dob")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("GradeId")
                        .IsRequired()
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("ClassId");

                    b.HasIndex("GradeId");

                    b.ToTable("Students");
                });

            modelBuilder.Entity("StudentManagement.Models.Teacher", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("CourseId")
                        .HasColumnType("int");

                    b.Property<string>("Department")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("HomeroomNumber")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CourseId")
                        .IsUnique();

                    b.ToTable("Teachers");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CourseId = 5,
                            Department = "Mathematics",
                            HomeroomNumber = 101,
                            Name = "Kim Abercrombie"
                        },
                        new
                        {
                            Id = 2,
                            CourseId = 9,
                            Department = "English",
                            HomeroomNumber = 102,
                            Name = "Gytis Barzdukas"
                        },
                        new
                        {
                            Id = 3,
                            CourseId = 13,
                            Department = "Economics",
                            HomeroomNumber = 103,
                            Name = "Peggy Justice"
                        },
                        new
                        {
                            Id = 4,
                            CourseId = 1,
                            Department = "Science",
                            HomeroomNumber = 104,
                            Name = "Fadi Fakhouri"
                        },
                        new
                        {
                            Id = 5,
                            CourseId = 6,
                            Department = "Mathematics",
                            HomeroomNumber = 201,
                            Name = "Roger Harui"
                        },
                        new
                        {
                            Id = 6,
                            CourseId = 10,
                            Department = "English",
                            HomeroomNumber = 202,
                            Name = "Yan Li"
                        },
                        new
                        {
                            Id = 7,
                            CourseId = 14,
                            Department = "Economics",
                            HomeroomNumber = 203,
                            Name = "Laura Norman"
                        },
                        new
                        {
                            Id = 8,
                            CourseId = 2,
                            Department = "Science",
                            HomeroomNumber = 204,
                            Name = "Nino Olivotto"
                        },
                        new
                        {
                            Id = 9,
                            CourseId = 7,
                            Department = "Mathematics",
                            HomeroomNumber = 301,
                            Name = "Wayne Tang"
                        },
                        new
                        {
                            Id = 10,
                            CourseId = 11,
                            Department = "English",
                            HomeroomNumber = 302,
                            Name = "Meredith Alonso"
                        },
                        new
                        {
                            Id = 11,
                            CourseId = 15,
                            Department = "Economics",
                            HomeroomNumber = 303,
                            Name = "Sophia Lopez"
                        },
                        new
                        {
                            Id = 12,
                            CourseId = 3,
                            Department = "Science",
                            HomeroomNumber = 304,
                            Name = "Meredith Browning"
                        },
                        new
                        {
                            Id = 13,
                            CourseId = 8,
                            Department = "Mathematics",
                            HomeroomNumber = 401,
                            Name = "Arturo Anand"
                        },
                        new
                        {
                            Id = 14,
                            CourseId = 12,
                            Department = "English",
                            HomeroomNumber = 402,
                            Name = "Alexandra Walker"
                        },
                        new
                        {
                            Id = 15,
                            CourseId = 16,
                            Department = "Economics",
                            HomeroomNumber = 403,
                            Name = "Carson Powell"
                        },
                        new
                        {
                            Id = 16,
                            CourseId = 4,
                            Department = "Science",
                            HomeroomNumber = 404,
                            Name = "Damien Jai"
                        });
                });

            modelBuilder.Entity("CourseStudent", b =>
                {
                    b.HasOne("StudentManagement.Models.Course", null)
                        .WithMany()
                        .HasForeignKey("CoursesRecordNum")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("StudentManagement.Models.Student", null)
                        .WithMany()
                        .HasForeignKey("StudentsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("StudentManagement.Models.Class", b =>
                {
                    b.HasOne("StudentManagement.Models.Grade", null)
                        .WithMany("Classes")
                        .HasForeignKey("GradeId");
                });

            modelBuilder.Entity("StudentManagement.Models.Course", b =>
                {
                    b.HasOne("StudentManagement.Models.Grade", "Grade")
                        .WithMany()
                        .HasForeignKey("GradeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Grade");
                });

            modelBuilder.Entity("StudentManagement.Models.Student", b =>
                {
                    b.HasOne("StudentManagement.Models.Class", "Class")
                        .WithMany("Students")
                        .HasForeignKey("ClassId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("StudentManagement.Models.Grade", "Grade")
                        .WithMany("Students")
                        .HasForeignKey("GradeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Class");

                    b.Navigation("Grade");
                });

            modelBuilder.Entity("StudentManagement.Models.Teacher", b =>
                {
                    b.HasOne("StudentManagement.Models.Course", "Course")
                        .WithOne("Teacher")
                        .HasForeignKey("StudentManagement.Models.Teacher", "CourseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Course");
                });

            modelBuilder.Entity("StudentManagement.Models.Class", b =>
                {
                    b.Navigation("Students");
                });

            modelBuilder.Entity("StudentManagement.Models.Course", b =>
                {
                    b.Navigation("Teacher")
                        .IsRequired();
                });

            modelBuilder.Entity("StudentManagement.Models.Grade", b =>
                {
                    b.Navigation("Classes");

                    b.Navigation("Students");
                });
#pragma warning restore 612, 618
        }
    }
}