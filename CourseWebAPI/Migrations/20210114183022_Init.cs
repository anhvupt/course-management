using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CourseWebAPI.Migrations
{
    public partial class Init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Courses",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CourseCredit = table.Column<int>(type: "int", nullable: false),
                    DepartmentID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Courses", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Instructors",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FistMidName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HireDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Instructors", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Students",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FirstMidName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EnrollmentDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Students", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CourseAssignments",
                columns: table => new
                {
                    CourseID = table.Column<int>(type: "int", nullable: false),
                    InstructorID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CourseAssignments", x => new { x.CourseID, x.InstructorID });
                    table.ForeignKey(
                        name: "FK_CourseAssignments_Courses_CourseID",
                        column: x => x.CourseID,
                        principalTable: "Courses",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CourseAssignments_Instructors_InstructorID",
                        column: x => x.InstructorID,
                        principalTable: "Instructors",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Departments",
                columns: table => new
                {
                    DepartmentID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Budget = table.Column<double>(type: "float", nullable: false),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    InstructorID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Departments", x => x.DepartmentID);
                    table.ForeignKey(
                        name: "FK_Departments_Instructors_InstructorID",
                        column: x => x.InstructorID,
                        principalTable: "Instructors",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OfficeAssignments",
                columns: table => new
                {
                    InstructorID = table.Column<int>(type: "int", nullable: false),
                    Location = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OfficeAssignments", x => x.InstructorID);
                    table.ForeignKey(
                        name: "FK_OfficeAssignments_Instructors_InstructorID",
                        column: x => x.InstructorID,
                        principalTable: "Instructors",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Enrollments",
                columns: table => new
                {
                    EnrollmentID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CourseID = table.Column<int>(type: "int", nullable: false),
                    StudentID = table.Column<int>(type: "int", nullable: false),
                    Grade = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Enrollments", x => x.EnrollmentID);
                    table.ForeignKey(
                        name: "FK_Enrollments_Courses_CourseID",
                        column: x => x.CourseID,
                        principalTable: "Courses",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Enrollments_Students_StudentID",
                        column: x => x.StudentID,
                        principalTable: "Students",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "ID", "CourseCredit", "DepartmentID", "Title" },
                values: new object[,]
                {
                    { 1, 1879190428, 5, "Modi explicabo esse deserunt." },
                    { 9, -1872343641, 1, "Laudantium sit cum perspiciatis." },
                    { 8, 1594434981, 2, "Qui qui officia aperiam doloremque facilis rerum dolores." },
                    { 7, -115095350, 2, "Blanditiis ea iste reiciendis sequi cum ipsam." },
                    { 6, -2870778, 3, "Est dolorem ipsam illum." },
                    { 10, 186760381, 1, "Nesciunt architecto quia asperiores." },
                    { 4, 1730633285, 4, "Explicabo et magni vel consequatur." },
                    { 3, -230306062, 4, "Sunt eos suscipit qui rerum delectus dolores." },
                    { 2, 330453738, 5, "Voluptatum magnam perspiciatis aliquam consequatur." },
                    { 5, 1372973033, 3, "Cupiditate facere tenetur voluptatem vero quis officia illum delectus." }
                });

            migrationBuilder.InsertData(
                table: "Instructors",
                columns: new[] { "ID", "FistMidName", "HireDate", "LastName" },
                values: new object[,]
                {
                    { 1, "Trey", new DateTime(2021, 1, 15, 1, 30, 21, 780, DateTimeKind.Local).AddTicks(2597), "Renner" },
                    { 2, "Irving", new DateTime(2021, 1, 15, 1, 30, 21, 781, DateTimeKind.Local).AddTicks(4628), "Von" },
                    { 3, "Marshall", new DateTime(2021, 1, 15, 1, 30, 21, 781, DateTimeKind.Local).AddTicks(6352), "Cormier" },
                    { 4, "Norma", new DateTime(2021, 1, 15, 1, 30, 21, 781, DateTimeKind.Local).AddTicks(8614), "Bernhard" },
                    { 5, "Zachary", new DateTime(2021, 1, 15, 1, 30, 21, 782, DateTimeKind.Local).AddTicks(577), "Nienow" }
                });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "EnrollmentDate", "FirstMidName", "LastName" },
                values: new object[,]
                {
                    { 4, new DateTime(2007, 4, 28, 0, 0, 0, 0, DateTimeKind.Utc), "Jackeline", "Hodkiewicz" },
                    { 1, new DateTime(1952, 2, 23, 0, 0, 0, 0, DateTimeKind.Utc), "Rhoda", "Renner" },
                    { 2, new DateTime(1992, 8, 15, 0, 0, 0, 0, DateTimeKind.Utc), "Winfield", "Boyer" },
                    { 3, new DateTime(1959, 5, 10, 0, 0, 0, 0, DateTimeKind.Utc), "Brisa", "Reinger" },
                    { 5, new DateTime(2017, 8, 6, 0, 0, 0, 0, DateTimeKind.Utc), "Ashley", "Bergnaum" }
                });

            migrationBuilder.InsertData(
                table: "CourseAssignments",
                columns: new[] { "CourseID", "InstructorID" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 10, 5 },
                    { 8, 4 },
                    { 7, 4 },
                    { 6, 3 },
                    { 5, 3 },
                    { 9, 5 },
                    { 4, 2 },
                    { 3, 2 },
                    { 2, 1 }
                });

            migrationBuilder.InsertData(
                table: "Departments",
                columns: new[] { "DepartmentID", "Budget", "InstructorID", "Name", "StartDate" },
                values: new object[,]
                {
                    { 3, -597151893.0, 3, "Louie Brekke", new DateTime(2021, 1, 15, 1, 30, 21, 792, DateTimeKind.Local).AddTicks(4995) },
                    { 1, 2011064282.0, 1, "Mrs. Mellie Labadie", new DateTime(2021, 1, 15, 1, 30, 21, 790, DateTimeKind.Local).AddTicks(9309) },
                    { 4, 1083842602.0, 4, "Margie Connelly", new DateTime(2021, 1, 15, 1, 30, 21, 792, DateTimeKind.Local).AddTicks(7606) },
                    { 5, -619048428.0, 5, "Florence Weimann", new DateTime(2021, 1, 15, 1, 30, 21, 793, DateTimeKind.Local).AddTicks(39) },
                    { 2, -543478924.0, 2, "Bertha Schiller", new DateTime(2021, 1, 15, 1, 30, 21, 792, DateTimeKind.Local).AddTicks(1037) }
                });

            migrationBuilder.InsertData(
                table: "Enrollments",
                columns: new[] { "EnrollmentID", "CourseID", "Grade", "StudentID" },
                values: new object[,]
                {
                    { 8, 8, "C", 4 },
                    { 7, 7, "D", 4 },
                    { 6, 6, "None", 3 },
                    { 5, 5, "A", 3 },
                    { 1, 1, "None", 1 },
                    { 3, 3, "C", 2 },
                    { 2, 2, "None", 1 },
                    { 9, 9, "B", 5 },
                    { 4, 4, "A", 2 },
                    { 10, 10, "A", 5 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_CourseAssignments_InstructorID",
                table: "CourseAssignments",
                column: "InstructorID");

            migrationBuilder.CreateIndex(
                name: "IX_Departments_InstructorID",
                table: "Departments",
                column: "InstructorID");

            migrationBuilder.CreateIndex(
                name: "IX_Enrollments_CourseID",
                table: "Enrollments",
                column: "CourseID");

            migrationBuilder.CreateIndex(
                name: "IX_Enrollments_StudentID",
                table: "Enrollments",
                column: "StudentID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CourseAssignments");

            migrationBuilder.DropTable(
                name: "Departments");

            migrationBuilder.DropTable(
                name: "Enrollments");

            migrationBuilder.DropTable(
                name: "OfficeAssignments");

            migrationBuilder.DropTable(
                name: "Courses");

            migrationBuilder.DropTable(
                name: "Students");

            migrationBuilder.DropTable(
                name: "Instructors");
        }
    }
}
