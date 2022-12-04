using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StudentManagement.Migrations
{
    public partial class SeededMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Grades",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GradeName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Section = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Grades", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Classes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ClassNumber = table.Column<int>(type: "int", nullable: false),
                    Term = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GradeId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Classes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Classes_Grades_GradeId",
                        column: x => x.GradeId,
                        principalTable: "Grades",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Courses",
                columns: table => new
                {
                    RecordNum = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CourseId = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GradeId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Courses", x => x.RecordNum);
                    table.ForeignKey(
                        name: "FK_Courses_Grades_GradeId",
                        column: x => x.GradeId,
                        principalTable: "Grades",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Students",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Dob = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GradeId = table.Column<int>(type: "int", nullable: false),
                    ClassId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Students", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Students_Classes_ClassId",
                        column: x => x.ClassId,
                        principalTable: "Classes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Students_Grades_GradeId",
                        column: x => x.GradeId,
                        principalTable: "Grades",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Teachers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HomeroomNumber = table.Column<int>(type: "int", nullable: false),
                    Department = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CourseId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Teachers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Teachers_Courses_CourseId",
                        column: x => x.CourseId,
                        principalTable: "Courses",
                        principalColumn: "RecordNum",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CourseStudent",
                columns: table => new
                {
                    CoursesRecordNum = table.Column<int>(type: "int", nullable: false),
                    StudentsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CourseStudent", x => new { x.CoursesRecordNum, x.StudentsId });
                    table.ForeignKey(
                        name: "FK_CourseStudent_Courses_CoursesRecordNum",
                        column: x => x.CoursesRecordNum,
                        principalTable: "Courses",
                        principalColumn: "RecordNum",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CourseStudent_Students_StudentsId",
                        column: x => x.StudentsId,
                        principalTable: "Students",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Classes",
                columns: new[] { "Id", "ClassNumber", "GradeId", "Term" },
                values: new object[,]
                {
                    { 1, 0, null, "Fall 2019" },
                    { 2, 0, null, "Spring 2020" },
                    { 3, 0, null, "Fall 2020" },
                    { 4, 0, null, "Spring 2021" }
                });

            migrationBuilder.InsertData(
                table: "Grades",
                columns: new[] { "Id", "GradeName", "Section" },
                values: new object[,]
                {
                    { 1, "Ninth", "Freshman" },
                    { 2, "Tenth", "Sophomore" },
                    { 3, "Eleventh", "Junior" },
                    { 4, "Twelfth", "Senior" }
                });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "RecordNum", "CourseId", "GradeId", "Name" },
                values: new object[,]
                {
                    { 1, 1042, 1, "Biology" },
                    { 2, 2050, 2, "Chemistry" },
                    { 3, 3061, 3, "Physics" },
                    { 4, 4070, 4, "Astronomy" },
                    { 5, 1010, 1, "Algebra" },
                    { 6, 2141, 2, "Trigonometry" },
                    { 7, 3045, 3, "Calculus I" },
                    { 8, 4045, 4, "Calculus II" },
                    { 9, 1043, 1, "Literature" },
                    { 10, 2030, 2, "Poetry" },
                    { 11, 3021, 3, "Composition" },
                    { 12, 4021, 4, "Creative writing" },
                    { 13, 1022, 1, "Microeconomics" },
                    { 14, 2041, 2, "Macroeconomics" },
                    { 15, 3061, 3, "Quantitative" },
                    { 16, 4061, 4, "Financial Markets" }
                });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "CourseId", "Department", "HomeroomNumber", "Name" },
                values: new object[,]
                {
                    { 1, 5, "Mathematics", 101, "Kim Abercrombie" },
                    { 2, 9, "English", 102, "Gytis Barzdukas" },
                    { 3, 13, "Economics", 103, "Peggy Justice" },
                    { 4, 1, "Science", 104, "Fadi Fakhouri" },
                    { 5, 6, "Mathematics", 201, "Roger Harui" },
                    { 6, 10, "English", 202, "Yan Li" },
                    { 7, 14, "Economics", 203, "Laura Norman" },
                    { 8, 2, "Science", 204, "Nino Olivotto" },
                    { 9, 7, "Mathematics", 301, "Wayne Tang" },
                    { 10, 11, "English", 302, "Meredith Alonso" },
                    { 11, 15, "Economics", 303, "Sophia Lopez" },
                    { 12, 3, "Science", 304, "Meredith Browning" },
                    { 13, 8, "Mathematics", 401, "Arturo Anand" },
                    { 14, 12, "English", 402, "Alexandra Walker" },
                    { 15, 16, "Economics", 403, "Carson Powell" },
                    { 16, 4, "Science", 404, "Damien Jai" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Classes_GradeId",
                table: "Classes",
                column: "GradeId");

            migrationBuilder.CreateIndex(
                name: "IX_Courses_GradeId",
                table: "Courses",
                column: "GradeId");

            migrationBuilder.CreateIndex(
                name: "IX_CourseStudent_StudentsId",
                table: "CourseStudent",
                column: "StudentsId");

            migrationBuilder.CreateIndex(
                name: "IX_Students_ClassId",
                table: "Students",
                column: "ClassId");

            migrationBuilder.CreateIndex(
                name: "IX_Students_GradeId",
                table: "Students",
                column: "GradeId");

            migrationBuilder.CreateIndex(
                name: "IX_Teachers_CourseId",
                table: "Teachers",
                column: "CourseId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CourseStudent");

            migrationBuilder.DropTable(
                name: "Teachers");

            migrationBuilder.DropTable(
                name: "Students");

            migrationBuilder.DropTable(
                name: "Courses");

            migrationBuilder.DropTable(
                name: "Classes");

            migrationBuilder.DropTable(
                name: "Grades");
        }
    }
}
