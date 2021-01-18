using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CourseWebAPI.Migrations
{
    public partial class Relationship : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Instructors",
                columns: new[] { "ID", "FirstMidName", "HireDate", "LastName" },
                values: new object[,]
                {
                    { 1, "Laurie", new DateTime(2021, 1, 18, 15, 26, 44, 18, DateTimeKind.Local).AddTicks(7902), "Maggio" },
                    { 2, "Gage", new DateTime(2021, 1, 18, 15, 26, 44, 20, DateTimeKind.Local).AddTicks(3817), "Swaniawski" },
                    { 3, "Dorothy", new DateTime(2021, 1, 18, 15, 26, 44, 20, DateTimeKind.Local).AddTicks(6770), "Spinka" },
                    { 4, "Palma", new DateTime(2021, 1, 18, 15, 26, 44, 20, DateTimeKind.Local).AddTicks(9106), "Keeling" },
                    { 5, "Jerrold", new DateTime(2021, 1, 18, 15, 26, 44, 21, DateTimeKind.Local).AddTicks(1758), "Jacobson" }
                });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "EnrollmentDate", "FirstMidName", "LastName" },
                values: new object[,]
                {
                    { 1, new DateTime(1926, 6, 11, 0, 0, 0, 0, DateTimeKind.Utc), "Herman", "Eichmann" },
                    { 2, new DateTime(1942, 7, 4, 0, 0, 0, 0, DateTimeKind.Utc), "Ebba", "Rau" },
                    { 3, new DateTime(1922, 5, 2, 0, 0, 0, 0, DateTimeKind.Utc), "Annette", "Grady" },
                    { 4, new DateTime(1965, 7, 17, 0, 0, 0, 0, DateTimeKind.Utc), "Megane", "Wuckert" },
                    { 5, new DateTime(1959, 4, 14, 0, 0, 0, 0, DateTimeKind.Utc), "Rubye", "Wunsch" }
                });

            migrationBuilder.InsertData(
                table: "Departments",
                columns: new[] { "DepartmentID", "Budget", "InstructorID", "Name", "StartDate" },
                values: new object[,]
                {
                    { 1, 1486748974.0, 1, "Alanis Lynch", new DateTime(2021, 1, 18, 15, 26, 44, 40, DateTimeKind.Local).AddTicks(8978) },
                    { 2, -654048269.0, 2, "Maia Bednar II", new DateTime(2021, 1, 18, 15, 26, 44, 41, DateTimeKind.Local).AddTicks(5562) },
                    { 3, -957636820.0, 3, "Miss Glennie Deckow", new DateTime(2021, 1, 18, 15, 26, 44, 42, DateTimeKind.Local).AddTicks(247) },
                    { 4, 1626203794.0, 4, "Dudley Connelly", new DateTime(2021, 1, 18, 15, 26, 44, 42, DateTimeKind.Local).AddTicks(2523) },
                    { 5, 1121808219.0, 5, "Kiel Tillman", new DateTime(2021, 1, 18, 15, 26, 44, 42, DateTimeKind.Local).AddTicks(4796) }
                });

            migrationBuilder.InsertData(
                table: "OfficeAssignments",
                columns: new[] { "InstructorID", "Location" },
                values: new object[,]
                {
                    { 1, "271 Metz Roads" },
                    { 2, "261 Fleta Summit" },
                    { 3, "19785 Waelchi Gateway" },
                    { 4, "73906 Parker " },
                    { 5, "46552 Yost Radial" }
                });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "ID", "CourseCredit", "DepartmentID", "Title" },
                values: new object[,]
                {
                    { 9, -674229058, 1, "Et et sed qui nesciunt labore." },
                    { 10, 396911523, 1, "Molestiae necessitatibus magnam aut voluptatem dolorem." },
                    { 7, 1265853722, 2, "Voluptas minus nihil ipsa facere doloremque commodi modi." },
                    { 8, 152681762, 2, "Earum tempora cum atque error ut illo." },
                    { 5, -1537799666, 3, "Consectetur nam nulla alias assumenda ut nihil beatae quae laborum." },
                    { 6, -1048257844, 3, "Vero necessitatibus natus et dolor odio labore vero quia." },
                    { 3, 1540690968, 4, "Eaque vero velit placeat ab veritatis ea assumenda." },
                    { 4, 1530852990, 4, "Qui accusamus aliquid quibusdam dolorem nihil et ipsa reiciendis exercitationem." },
                    { 1, -1935164867, 5, "Laborum in deleniti blanditiis eaque pariatur." },
                    { 2, -45201723, 5, "In qui enim ratione et iusto." }
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
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "CourseAssignments",
                keyColumns: new[] { "CourseID", "InstructorID" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                table: "CourseAssignments",
                keyColumns: new[] { "CourseID", "InstructorID" },
                keyValues: new object[] { 2, 1 });

            migrationBuilder.DeleteData(
                table: "CourseAssignments",
                keyColumns: new[] { "CourseID", "InstructorID" },
                keyValues: new object[] { 3, 2 });

            migrationBuilder.DeleteData(
                table: "CourseAssignments",
                keyColumns: new[] { "CourseID", "InstructorID" },
                keyValues: new object[] { 4, 2 });

            migrationBuilder.DeleteData(
                table: "CourseAssignments",
                keyColumns: new[] { "CourseID", "InstructorID" },
                keyValues: new object[] { 5, 3 });

            migrationBuilder.DeleteData(
                table: "CourseAssignments",
                keyColumns: new[] { "CourseID", "InstructorID" },
                keyValues: new object[] { 6, 3 });

            migrationBuilder.DeleteData(
                table: "CourseAssignments",
                keyColumns: new[] { "CourseID", "InstructorID" },
                keyValues: new object[] { 7, 4 });

            migrationBuilder.DeleteData(
                table: "CourseAssignments",
                keyColumns: new[] { "CourseID", "InstructorID" },
                keyValues: new object[] { 8, 4 });

            migrationBuilder.DeleteData(
                table: "CourseAssignments",
                keyColumns: new[] { "CourseID", "InstructorID" },
                keyValues: new object[] { 9, 5 });

            migrationBuilder.DeleteData(
                table: "CourseAssignments",
                keyColumns: new[] { "CourseID", "InstructorID" },
                keyValues: new object[] { 10, 5 });

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "EnrollmentID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "EnrollmentID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "EnrollmentID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "EnrollmentID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "EnrollmentID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "EnrollmentID",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "EnrollmentID",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "EnrollmentID",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "EnrollmentID",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "EnrollmentID",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "OfficeAssignments",
                keyColumn: "InstructorID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "OfficeAssignments",
                keyColumn: "InstructorID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "OfficeAssignments",
                keyColumn: "InstructorID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "OfficeAssignments",
                keyColumn: "InstructorID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "OfficeAssignments",
                keyColumn: "InstructorID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "ID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "ID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "ID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "ID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "ID",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "ID",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "ID",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "ID",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "ID",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "DepartmentID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "DepartmentID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "DepartmentID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "DepartmentID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "DepartmentID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Instructors",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Instructors",
                keyColumn: "ID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Instructors",
                keyColumn: "ID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Instructors",
                keyColumn: "ID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Instructors",
                keyColumn: "ID",
                keyValue: 5);
        }
    }
}
