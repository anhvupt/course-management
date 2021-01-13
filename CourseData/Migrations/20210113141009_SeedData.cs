using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CourseData.Migrations
{
    public partial class SeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "ID", "CourseCredit", "DepartmentID", "Title" },
                values: new object[,]
                {
                    { 1, -10614573, 5, "Libero impedit dolorem quaerat ut numquam praesentium consequatur ducimus." },
                    { 9, -864927950, 1, "Facere tempora nesciunt dolor molestias quia ipsam dicta omnis." },
                    { 8, 967297127, 2, "Accusantium ipsam quidem odio ut libero assumenda illo." },
                    { 7, -429650130, 2, "Placeat cum reprehenderit ab similique ab repellendus." },
                    { 6, -1905565977, 3, "Nulla at atque nulla animi quis vel." },
                    { 10, 2142055491, 1, "Illo et dolorem nemo facere aut ipsum minima voluptatem blanditiis." },
                    { 4, 669948368, 4, "Tempora sunt qui suscipit nobis culpa enim et." },
                    { 3, -1148932920, 4, "Voluptatem et nam est." },
                    { 2, -93618281, 5, "Qui ratione et sed minima." },
                    { 5, -873981294, 3, "Maxime ea minima omnis." }
                });

            migrationBuilder.InsertData(
                table: "Instructors",
                columns: new[] { "ID", "FistMidName", "HireDate", "LastName" },
                values: new object[,]
                {
                    { 1, "Elena", new DateTime(2021, 1, 13, 21, 10, 8, 797, DateTimeKind.Local).AddTicks(2482), "Ward" },
                    { 2, "Adriana", new DateTime(2021, 1, 13, 21, 10, 8, 799, DateTimeKind.Local).AddTicks(5379), "Weber" },
                    { 3, "Laurianne", new DateTime(2021, 1, 13, 21, 10, 8, 799, DateTimeKind.Local).AddTicks(9336), "Rohan" },
                    { 4, "Murray", new DateTime(2021, 1, 13, 21, 10, 8, 800, DateTimeKind.Local).AddTicks(2063), "Cole" },
                    { 5, "Ollie", new DateTime(2021, 1, 13, 21, 10, 8, 800, DateTimeKind.Local).AddTicks(4776), "Lynch" }
                });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "EnrollmentDate", "FirstMidName", "LastName" },
                values: new object[] { new DateTime(2019, 7, 6, 0, 0, 0, 0, DateTimeKind.Utc), "Candido", "Wunsch" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "EnrollmentDate", "FirstMidName", "LastName" },
                values: new object[] { new DateTime(2014, 5, 25, 0, 0, 0, 0, DateTimeKind.Utc), "Madeline", "Botsford" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "EnrollmentDate", "FirstMidName", "LastName" },
                values: new object[] { new DateTime(1903, 6, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Enid", "Schmitt" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "EnrollmentDate", "FirstMidName", "LastName" },
                values: new object[] { new DateTime(2017, 6, 30, 0, 0, 0, 0, DateTimeKind.Utc), "Frederique", "Cummerata" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "EnrollmentDate", "FirstMidName", "LastName" },
                values: new object[] { new DateTime(1959, 12, 7, 0, 0, 0, 0, DateTimeKind.Utc), "Floyd", "Botsford" });

            migrationBuilder.InsertData(
                table: "CourseAssignments",
                columns: new[] { "CourseID", "InstructorID" },
                values: new object[,]
                {
                    { 9, 5 },
                    { 8, 4 },
                    { 7, 4 },
                    { 6, 3 },
                    { 5, 3 },
                    { 4, 2 },
                    { 1, 1 },
                    { 2, 1 },
                    { 10, 5 },
                    { 3, 2 }
                });

            migrationBuilder.InsertData(
                table: "Departments",
                columns: new[] { "DepartmentID", "Budget", "InstructorID", "Name", "StartDate" },
                values: new object[,]
                {
                    { 1, 306006358.0, 1, "Mrs. Spencer Mueller", new DateTime(2021, 1, 13, 21, 10, 8, 811, DateTimeKind.Local).AddTicks(9269) },
                    { 4, 1675345504.0, 4, "Maxime Metz IV", new DateTime(2021, 1, 13, 21, 10, 8, 813, DateTimeKind.Local).AddTicks(3015) },
                    { 3, -222072614.0, 3, "Brenden Denesik", new DateTime(2021, 1, 13, 21, 10, 8, 812, DateTimeKind.Local).AddTicks(7932) },
                    { 2, -1255204266.0, 2, "Moriah Wyman", new DateTime(2021, 1, 13, 21, 10, 8, 812, DateTimeKind.Local).AddTicks(5363) },
                    { 5, 165648845.0, 5, "Providenci Cartwright", new DateTime(2021, 1, 13, 21, 10, 8, 813, DateTimeKind.Local).AddTicks(6562) }
                });

            migrationBuilder.InsertData(
                table: "Enrollments",
                columns: new[] { "EnrollmentID", "CourseID", "Grade", "StudentID" },
                values: new object[,]
                {
                    { 9, 9, "B", 5 },
                    { 8, 8, "C", 4 },
                    { 7, 7, "D", 4 },
                    { 6, 6, "None", 3 },
                    { 5, 5, "A", 3 },
                    { 4, 4, "A", 2 },
                    { 3, 3, "C", 2 },
                    { 2, 2, "None", 1 },
                    { 10, 10, "A", 5 },
                    { 1, 1, "None", 1 }
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

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "EnrollmentDate", "FirstMidName", "LastName" },
                values: new object[] { new DateTime(2016, 2, 5, 0, 0, 0, 0, DateTimeKind.Utc), "Rosamond", "Morissette" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "EnrollmentDate", "FirstMidName", "LastName" },
                values: new object[] { new DateTime(1960, 2, 16, 0, 0, 0, 0, DateTimeKind.Utc), "Jonathon", "Schulist" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "EnrollmentDate", "FirstMidName", "LastName" },
                values: new object[] { new DateTime(1951, 4, 24, 0, 0, 0, 0, DateTimeKind.Utc), "Amya", "Brakus" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "EnrollmentDate", "FirstMidName", "LastName" },
                values: new object[] { new DateTime(1922, 11, 3, 0, 0, 0, 0, DateTimeKind.Utc), "Lempi", "Orn" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "EnrollmentDate", "FirstMidName", "LastName" },
                values: new object[] { new DateTime(1968, 3, 28, 0, 0, 0, 0, DateTimeKind.Utc), "Robyn", "Marks" });
        }
    }
}
