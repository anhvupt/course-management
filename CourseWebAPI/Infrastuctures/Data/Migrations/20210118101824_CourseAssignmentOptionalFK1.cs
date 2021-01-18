using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CourseWebAPI.Migrations
{
    public partial class CourseAssignmentOptionalFK1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.InsertData(
                table: "CourseAssignments",
                columns: new[] { "CourseID", "InstructorID" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 9, 5 },
                    { 8, 4 },
                    { 7, 4 },
                    { 6, 3 },
                    { 10, 5 },
                    { 4, 2 },
                    { 3, 2 },
                    { 2, 1 },
                    { 5, 3 }
                });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "CourseCredit", "Title" },
                values: new object[] { -1286339738, "Deserunt voluptatem et nulla autem iste consequatur nobis incidunt est." });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "CourseCredit", "Title" },
                values: new object[] { -1784026459, "Accusamus incidunt atque doloribus et quam ex eius ut." });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "CourseCredit", "Title" },
                values: new object[] { 110192235, "Illo quisquam rerum enim perferendis." });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "CourseCredit", "Title" },
                values: new object[] { 1751106530, "Qui accusantium voluptatum beatae consequatur voluptatem." });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "CourseCredit", "Title" },
                values: new object[] { -100512498, "Ipsa debitis blanditiis quam enim autem voluptate." });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "ID",
                keyValue: 6,
                columns: new[] { "CourseCredit", "Title" },
                values: new object[] { 917262729, "Veritatis et esse et." });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "ID",
                keyValue: 7,
                columns: new[] { "CourseCredit", "Title" },
                values: new object[] { 286977444, "Rem veniam voluptatem soluta occaecati facilis." });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "ID",
                keyValue: 8,
                columns: new[] { "CourseCredit", "Title" },
                values: new object[] { -1549734845, "Mollitia cumque recusandae quas qui quibusdam necessitatibus rem corporis nam." });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "ID",
                keyValue: 9,
                columns: new[] { "CourseCredit", "Title" },
                values: new object[] { 1486764502, "Odit quo eum dolorem debitis nam atque." });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "ID",
                keyValue: 10,
                columns: new[] { "CourseCredit", "Title" },
                values: new object[] { -427272987, "Officia voluptate asperiores placeat rem non soluta aut repudiandae." });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "DepartmentID",
                keyValue: 1,
                columns: new[] { "Budget", "Name", "StartDate" },
                values: new object[] { 1873374993.0, "Reva Cruickshank", new DateTime(2021, 1, 18, 17, 18, 22, 980, DateTimeKind.Local).AddTicks(389) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "DepartmentID",
                keyValue: 2,
                columns: new[] { "Budget", "Name", "StartDate" },
                values: new object[] { -860282795.0, "Vicente Pagac", new DateTime(2021, 1, 18, 17, 18, 22, 980, DateTimeKind.Local).AddTicks(5460) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "DepartmentID",
                keyValue: 3,
                columns: new[] { "Budget", "Name", "StartDate" },
                values: new object[] { -815455100.0, "Tristin Hessel", new DateTime(2021, 1, 18, 17, 18, 22, 980, DateTimeKind.Local).AddTicks(7507) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "DepartmentID",
                keyValue: 4,
                columns: new[] { "Budget", "Name", "StartDate" },
                values: new object[] { -583580046.0, "Kristy Little", new DateTime(2021, 1, 18, 17, 18, 22, 980, DateTimeKind.Local).AddTicks(9326) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "DepartmentID",
                keyValue: 5,
                columns: new[] { "Budget", "Name", "StartDate" },
                values: new object[] { 288007267.0, "Ephraim Gislason", new DateTime(2021, 1, 18, 17, 18, 22, 981, DateTimeKind.Local).AddTicks(1310) });

            migrationBuilder.UpdateData(
                table: "Instructors",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "FirstMidName", "HireDate", "LastName" },
                values: new object[] { "Joelle", new DateTime(2021, 1, 18, 17, 18, 22, 937, DateTimeKind.Local).AddTicks(7130), "Braun" });

            migrationBuilder.UpdateData(
                table: "Instructors",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "FirstMidName", "HireDate", "LastName" },
                values: new object[] { "Fletcher", new DateTime(2021, 1, 18, 17, 18, 22, 939, DateTimeKind.Local).AddTicks(7581), "Reichel" });

            migrationBuilder.UpdateData(
                table: "Instructors",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "FirstMidName", "HireDate", "LastName" },
                values: new object[] { "Wilfred", new DateTime(2021, 1, 18, 17, 18, 22, 940, DateTimeKind.Local).AddTicks(1243), "Bosco" });

            migrationBuilder.UpdateData(
                table: "Instructors",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "FirstMidName", "HireDate", "LastName" },
                values: new object[] { "Delta", new DateTime(2021, 1, 18, 17, 18, 22, 940, DateTimeKind.Local).AddTicks(4912), "Fisher" });

            migrationBuilder.UpdateData(
                table: "Instructors",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "FirstMidName", "HireDate", "LastName" },
                values: new object[] { "Otis", new DateTime(2021, 1, 18, 17, 18, 22, 941, DateTimeKind.Local).AddTicks(440), "Bogan" });

            migrationBuilder.UpdateData(
                table: "OfficeAssignments",
                keyColumn: "InstructorID",
                keyValue: 1,
                column: "Location",
                value: "9846 Ebert Plaza");

            migrationBuilder.UpdateData(
                table: "OfficeAssignments",
                keyColumn: "InstructorID",
                keyValue: 2,
                column: "Location",
                value: "47310 Stehr Pines");

            migrationBuilder.UpdateData(
                table: "OfficeAssignments",
                keyColumn: "InstructorID",
                keyValue: 3,
                column: "Location",
                value: "70219 Bogan Passage");

            migrationBuilder.UpdateData(
                table: "OfficeAssignments",
                keyColumn: "InstructorID",
                keyValue: 4,
                column: "Location",
                value: "56342 Armstrong Vista");

            migrationBuilder.UpdateData(
                table: "OfficeAssignments",
                keyColumn: "InstructorID",
                keyValue: 5,
                column: "Location",
                value: "36048 Benton Point");

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "EnrollmentDate", "FirstMidName", "LastName" },
                values: new object[] { new DateTime(1993, 8, 2, 0, 0, 0, 0, DateTimeKind.Utc), "Earline", "Reynolds" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "EnrollmentDate", "FirstMidName", "LastName" },
                values: new object[] { new DateTime(1962, 10, 27, 0, 0, 0, 0, DateTimeKind.Utc), "Brando", "Satterfield" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "EnrollmentDate", "FirstMidName", "LastName" },
                values: new object[] { new DateTime(1959, 12, 23, 0, 0, 0, 0, DateTimeKind.Utc), "Dulce", "Gulgowski" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "EnrollmentDate", "FirstMidName", "LastName" },
                values: new object[] { new DateTime(2001, 3, 5, 0, 0, 0, 0, DateTimeKind.Utc), "Duncan", "Russel" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "EnrollmentDate", "FirstMidName", "LastName" },
                values: new object[] { new DateTime(1978, 9, 13, 0, 0, 0, 0, DateTimeKind.Utc), "Providenci", "Powlowski" });
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

            migrationBuilder.InsertData(
                table: "CourseAssignments",
                columns: new[] { "CourseID", "InstructorID" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 9, 5 },
                    { 8, 4 },
                    { 7, 4 },
                    { 6, 3 },
                    { 10, 5 },
                    { 4, 2 },
                    { 3, 2 },
                    { 2, 1 },
                    { 5, 3 }
                });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "CourseCredit", "Title" },
                values: new object[] { -1642574628, "Dolores est accusantium quis sequi." });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "CourseCredit", "Title" },
                values: new object[] { -2058733634, "Vel et ipsam enim consequatur esse fuga voluptatem magni." });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "CourseCredit", "Title" },
                values: new object[] { -67700769, "Est vel et nihil." });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "CourseCredit", "Title" },
                values: new object[] { 2087962723, "Unde harum consequuntur maiores nulla quo eos neque ducimus." });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "CourseCredit", "Title" },
                values: new object[] { -436073340, "Nisi tempora officia cupiditate ipsum qui quidem ipsa accusamus quia." });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "ID",
                keyValue: 6,
                columns: new[] { "CourseCredit", "Title" },
                values: new object[] { 1241038854, "Eligendi ad reprehenderit repellendus possimus." });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "ID",
                keyValue: 7,
                columns: new[] { "CourseCredit", "Title" },
                values: new object[] { -257887819, "Laboriosam excepturi ex perspiciatis ullam et." });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "ID",
                keyValue: 8,
                columns: new[] { "CourseCredit", "Title" },
                values: new object[] { 191128364, "Consequatur quia ut temporibus veritatis ex et." });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "ID",
                keyValue: 9,
                columns: new[] { "CourseCredit", "Title" },
                values: new object[] { 1715893102, "Quidem sed vero consequatur aut ipsa eum sequi ea enim." });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "ID",
                keyValue: 10,
                columns: new[] { "CourseCredit", "Title" },
                values: new object[] { 1391028728, "Iusto maxime aspernatur et voluptatibus sint aut et." });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "DepartmentID",
                keyValue: 1,
                columns: new[] { "Budget", "Name", "StartDate" },
                values: new object[] { 1311331862.0, "Oswald Kunde", new DateTime(2021, 1, 18, 17, 15, 27, 766, DateTimeKind.Local).AddTicks(6513) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "DepartmentID",
                keyValue: 2,
                columns: new[] { "Budget", "Name", "StartDate" },
                values: new object[] { 1946819015.0, "Triston Borer", new DateTime(2021, 1, 18, 17, 15, 27, 767, DateTimeKind.Local).AddTicks(2317) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "DepartmentID",
                keyValue: 3,
                columns: new[] { "Budget", "Name", "StartDate" },
                values: new object[] { 616479184.0, "Tobin Cummings Sr.", new DateTime(2021, 1, 18, 17, 15, 27, 768, DateTimeKind.Local).AddTicks(1414) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "DepartmentID",
                keyValue: 4,
                columns: new[] { "Budget", "Name", "StartDate" },
                values: new object[] { -1398828057.0, "Ralph Waters", new DateTime(2021, 1, 18, 17, 15, 27, 768, DateTimeKind.Local).AddTicks(5010) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "DepartmentID",
                keyValue: 5,
                columns: new[] { "Budget", "Name", "StartDate" },
                values: new object[] { 1247451781.0, "Bernita Hettinger", new DateTime(2021, 1, 18, 17, 15, 27, 768, DateTimeKind.Local).AddTicks(7627) });

            migrationBuilder.UpdateData(
                table: "Instructors",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "FirstMidName", "HireDate", "LastName" },
                values: new object[] { "Bella", new DateTime(2021, 1, 18, 17, 15, 27, 739, DateTimeKind.Local).AddTicks(4913), "Russel" });

            migrationBuilder.UpdateData(
                table: "Instructors",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "FirstMidName", "HireDate", "LastName" },
                values: new object[] { "Harvey", new DateTime(2021, 1, 18, 17, 15, 27, 741, DateTimeKind.Local).AddTicks(5), "Zulauf" });

            migrationBuilder.UpdateData(
                table: "Instructors",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "FirstMidName", "HireDate", "LastName" },
                values: new object[] { "Rene", new DateTime(2021, 1, 18, 17, 15, 27, 741, DateTimeKind.Local).AddTicks(3398), "Stracke" });

            migrationBuilder.UpdateData(
                table: "Instructors",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "FirstMidName", "HireDate", "LastName" },
                values: new object[] { "Eloisa", new DateTime(2021, 1, 18, 17, 15, 27, 741, DateTimeKind.Local).AddTicks(6534), "Braun" });

            migrationBuilder.UpdateData(
                table: "Instructors",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "FirstMidName", "HireDate", "LastName" },
                values: new object[] { "Kassandra", new DateTime(2021, 1, 18, 17, 15, 27, 741, DateTimeKind.Local).AddTicks(9979), "Ruecker" });

            migrationBuilder.UpdateData(
                table: "OfficeAssignments",
                keyColumn: "InstructorID",
                keyValue: 1,
                column: "Location",
                value: "31899 Jayson Brook");

            migrationBuilder.UpdateData(
                table: "OfficeAssignments",
                keyColumn: "InstructorID",
                keyValue: 2,
                column: "Location",
                value: "752 Marian Inlet");

            migrationBuilder.UpdateData(
                table: "OfficeAssignments",
                keyColumn: "InstructorID",
                keyValue: 3,
                column: "Location",
                value: "02906 Marvin Trace");

            migrationBuilder.UpdateData(
                table: "OfficeAssignments",
                keyColumn: "InstructorID",
                keyValue: 4,
                column: "Location",
                value: "8868 Stehr Course");

            migrationBuilder.UpdateData(
                table: "OfficeAssignments",
                keyColumn: "InstructorID",
                keyValue: 5,
                column: "Location",
                value: "75702 Angelica Plains");

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "EnrollmentDate", "FirstMidName", "LastName" },
                values: new object[] { new DateTime(1974, 9, 13, 0, 0, 0, 0, DateTimeKind.Utc), "Avery", "Okuneva" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "EnrollmentDate", "FirstMidName", "LastName" },
                values: new object[] { new DateTime(2003, 10, 10, 0, 0, 0, 0, DateTimeKind.Utc), "Ephraim", "Schulist" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "EnrollmentDate", "FirstMidName", "LastName" },
                values: new object[] { new DateTime(1921, 4, 27, 0, 0, 0, 0, DateTimeKind.Utc), "Michele", "Littel" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "EnrollmentDate", "FirstMidName", "LastName" },
                values: new object[] { new DateTime(1985, 4, 7, 0, 0, 0, 0, DateTimeKind.Utc), "Kelton", "Dooley" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "EnrollmentDate", "FirstMidName", "LastName" },
                values: new object[] { new DateTime(2001, 2, 20, 0, 0, 0, 0, DateTimeKind.Utc), "Elta", "Sipes" });
        }
    }
}
