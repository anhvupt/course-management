using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CourseWebAPI.Migrations
{
    public partial class Init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Instructors",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FirstMidName = table.Column<string>(type: "nvarchar(max)", nullable: true),
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
                    table.ForeignKey(
                        name: "FK_Courses_Departments_DepartmentID",
                        column: x => x.DepartmentID,
                        principalTable: "Departments",
                        principalColumn: "DepartmentID",
                        onDelete: ReferentialAction.Cascade);
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
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CourseAssignments_Instructors_InstructorID",
                        column: x => x.InstructorID,
                        principalTable: "Instructors",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
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
                table: "Instructors",
                columns: new[] { "ID", "FirstMidName", "HireDate", "LastName" },
                values: new object[,]
                {
                    { 1, "Bertrand", new DateTime(2021, 1, 16, 19, 32, 19, 213, DateTimeKind.Local).AddTicks(6354), "Cartwright" },
                    { 2, "Dock", new DateTime(2021, 1, 16, 19, 32, 19, 215, DateTimeKind.Local).AddTicks(9674), "Gutkowski" },
                    { 3, "Kelly", new DateTime(2021, 1, 16, 19, 32, 19, 216, DateTimeKind.Local).AddTicks(1506), "Powlowski" },
                    { 4, "Bradford", new DateTime(2021, 1, 16, 19, 32, 19, 216, DateTimeKind.Local).AddTicks(2800), "Hoeger" },
                    { 5, "Lula", new DateTime(2021, 1, 16, 19, 32, 19, 216, DateTimeKind.Local).AddTicks(4198), "Williamson" }
                });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "EnrollmentDate", "FirstMidName", "LastName" },
                values: new object[,]
                {
                    { 1, new DateTime(2007, 10, 21, 0, 0, 0, 0, DateTimeKind.Utc), "Erika", "Crooks" },
                    { 2, new DateTime(1906, 3, 9, 0, 0, 0, 0, DateTimeKind.Utc), "Kailee", "Haley" },
                    { 3, new DateTime(1988, 8, 14, 0, 0, 0, 0, DateTimeKind.Utc), "Marc", "Goldner" },
                    { 4, new DateTime(1959, 7, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Emie", "Kertzmann" },
                    { 5, new DateTime(1951, 3, 11, 0, 0, 0, 0, DateTimeKind.Utc), "Abner", "Moore" }
                });

            migrationBuilder.InsertData(
                table: "Departments",
                columns: new[] { "DepartmentID", "Budget", "InstructorID", "Name", "StartDate" },
                values: new object[,]
                {
                    { 1, -1762195451.0, 1, "Elliot Fay I", new DateTime(2021, 1, 16, 19, 32, 19, 225, DateTimeKind.Local).AddTicks(3783) },
                    { 2, 629826614.0, 2, "Ahmed Torp", new DateTime(2021, 1, 16, 19, 32, 19, 225, DateTimeKind.Local).AddTicks(7725) },
                    { 3, 1157944999.0, 3, "Ari Bayer", new DateTime(2021, 1, 16, 19, 32, 19, 225, DateTimeKind.Local).AddTicks(9246) },
                    { 4, -1256002872.0, 4, "Ted Skiles", new DateTime(2021, 1, 16, 19, 32, 19, 226, DateTimeKind.Local).AddTicks(513) },
                    { 5, -1469120133.0, 5, "Grace Stroman", new DateTime(2021, 1, 16, 19, 32, 19, 226, DateTimeKind.Local).AddTicks(2518) }
                });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "ID", "CourseCredit", "DepartmentID", "Title" },
                values: new object[,]
                {
                    { 9, -1526750892, 1, "Id at laudantium maxime ut delectus in autem quae." },
                    { 10, 2003657334, 1, "Commodi molestiae quia similique dolores." },
                    { 7, 412734277, 2, "Voluptates sint repellendus eos eum excepturi voluptas." },
                    { 8, 1886547216, 2, "Impedit incidunt ut perspiciatis reprehenderit." },
                    { 5, -105182209, 3, "Natus illum ipsum est." },
                    { 6, -366597290, 3, "Libero ipsum voluptates rerum vel ratione." },
                    { 3, -823397902, 4, "Dolorum rerum adipisci alias odit." },
                    { 4, -2057239761, 4, "Ipsam velit quis maxime porro praesentium cum." },
                    { 1, 862109254, 5, "Doloremque eligendi quas quod ducimus neque neque quia ab sit." },
                    { 2, -2043066793, 5, "Accusamus rem nihil aperiam labore." }
                });

            migrationBuilder.InsertData(
                table: "CourseAssignments",
                columns: new[] { "CourseID", "InstructorID" },
                values: new object[,]
                {
                    { 9, 5 },
                    { 10, 5 },
                    { 1, 1 },
                    { 7, 4 },
                    { 8, 4 },
                    { 4, 2 },
                    { 5, 3 },
                    { 2, 1 },
                    { 6, 3 },
                    { 3, 2 }
                });

            migrationBuilder.InsertData(
                table: "Enrollments",
                columns: new[] { "EnrollmentID", "CourseID", "Grade", "StudentID" },
                values: new object[,]
                {
                    { 1, 1, "None", 1 },
                    { 4, 4, "A", 2 },
                    { 3, 3, "C", 2 },
                    { 5, 5, "A", 3 },
                    { 8, 8, "C", 4 },
                    { 7, 7, "D", 4 },
                    { 10, 10, "A", 5 },
                    { 9, 9, "B", 5 },
                    { 6, 6, "None", 3 },
                    { 2, 2, "None", 1 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_CourseAssignments_InstructorID",
                table: "CourseAssignments",
                column: "InstructorID");

            migrationBuilder.CreateIndex(
                name: "IX_Courses_DepartmentID",
                table: "Courses",
                column: "DepartmentID");

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
                name: "Enrollments");

            migrationBuilder.DropTable(
                name: "OfficeAssignments");

            migrationBuilder.DropTable(
                name: "Courses");

            migrationBuilder.DropTable(
                name: "Students");

            migrationBuilder.DropTable(
                name: "Departments");

            migrationBuilder.DropTable(
                name: "Instructors");
        }
    }
}
