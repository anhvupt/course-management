using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CourseWebAPI.Migrations
{
    public partial class CourseAssignmentOptionalFK : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "CourseCredit", "Title" },
                values: new object[] { -246361408, "Nam quo natus at dolorum necessitatibus eligendi suscipit nemo natus." });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "CourseCredit", "Title" },
                values: new object[] { 1736100980, "Quibusdam perspiciatis porro sed voluptatem minima eaque quisquam et sed." });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "CourseCredit", "Title" },
                values: new object[] { 1489336281, "Deleniti quam ad libero et temporibus voluptate." });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "CourseCredit", "Title" },
                values: new object[] { -541364165, "Neque accusamus voluptatum sed fugit." });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "CourseCredit", "Title" },
                values: new object[] { 754168129, "Rem illo quaerat et magnam sed recusandae est illo ut." });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "ID",
                keyValue: 6,
                columns: new[] { "CourseCredit", "Title" },
                values: new object[] { 561997649, "Ullam fugit eligendi placeat consequatur est omnis aliquid." });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "ID",
                keyValue: 7,
                columns: new[] { "CourseCredit", "Title" },
                values: new object[] { -1418258620, "Et ut et nihil sint aliquam." });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "ID",
                keyValue: 8,
                columns: new[] { "CourseCredit", "Title" },
                values: new object[] { 273785256, "Expedita deserunt neque expedita repudiandae illo non est ut nostrum." });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "ID",
                keyValue: 9,
                columns: new[] { "CourseCredit", "Title" },
                values: new object[] { 1155689554, "Illum tempore sed odio cupiditate." });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "ID",
                keyValue: 10,
                columns: new[] { "CourseCredit", "Title" },
                values: new object[] { 1404583682, "Consequuntur omnis possimus aut tempore sed consectetur fuga eum eum." });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "DepartmentID",
                keyValue: 1,
                columns: new[] { "Budget", "Name", "StartDate" },
                values: new object[] { -716829346.0, "Emily Jakubowski", new DateTime(2021, 1, 18, 16, 45, 35, 774, DateTimeKind.Local).AddTicks(1178) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "DepartmentID",
                keyValue: 2,
                columns: new[] { "Budget", "Name", "StartDate" },
                values: new object[] { -105976548.0, "Ms. Eloy Weber", new DateTime(2021, 1, 18, 16, 45, 35, 775, DateTimeKind.Local).AddTicks(1279) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "DepartmentID",
                keyValue: 3,
                columns: new[] { "Budget", "Name", "StartDate" },
                values: new object[] { -325517875.0, "Rocky Runolfsdottir", new DateTime(2021, 1, 18, 16, 45, 35, 775, DateTimeKind.Local).AddTicks(4509) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "DepartmentID",
                keyValue: 4,
                columns: new[] { "Budget", "Name", "StartDate" },
                values: new object[] { -694820541.0, "Thelma McClure", new DateTime(2021, 1, 18, 16, 45, 35, 775, DateTimeKind.Local).AddTicks(7930) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "DepartmentID",
                keyValue: 5,
                columns: new[] { "Budget", "Name", "StartDate" },
                values: new object[] { 1186551899.0, "Cathrine Cartwright", new DateTime(2021, 1, 18, 16, 45, 35, 776, DateTimeKind.Local).AddTicks(1272) });

            migrationBuilder.UpdateData(
                table: "Instructors",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "FirstMidName", "HireDate", "LastName" },
                values: new object[] { "Julien", new DateTime(2021, 1, 18, 16, 45, 35, 734, DateTimeKind.Local).AddTicks(4154), "Nienow" });

            migrationBuilder.UpdateData(
                table: "Instructors",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "FirstMidName", "HireDate", "LastName" },
                values: new object[] { "Carley", new DateTime(2021, 1, 18, 16, 45, 35, 736, DateTimeKind.Local).AddTicks(1811), "Bernhard" });

            migrationBuilder.UpdateData(
                table: "Instructors",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "FirstMidName", "HireDate", "LastName" },
                values: new object[] { "Orin", new DateTime(2021, 1, 18, 16, 45, 35, 736, DateTimeKind.Local).AddTicks(5184), "Fritsch" });

            migrationBuilder.UpdateData(
                table: "Instructors",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "FirstMidName", "HireDate", "LastName" },
                values: new object[] { "Amina", new DateTime(2021, 1, 18, 16, 45, 35, 736, DateTimeKind.Local).AddTicks(8670), "Stoltenberg" });

            migrationBuilder.UpdateData(
                table: "Instructors",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "FirstMidName", "HireDate", "LastName" },
                values: new object[] { "Mina", new DateTime(2021, 1, 18, 16, 45, 35, 737, DateTimeKind.Local).AddTicks(2682), "Blanda" });

            migrationBuilder.UpdateData(
                table: "OfficeAssignments",
                keyColumn: "InstructorID",
                keyValue: 1,
                column: "Location",
                value: "09017 Davis Landing");

            migrationBuilder.UpdateData(
                table: "OfficeAssignments",
                keyColumn: "InstructorID",
                keyValue: 2,
                column: "Location",
                value: "551 Brendon Walk");

            migrationBuilder.UpdateData(
                table: "OfficeAssignments",
                keyColumn: "InstructorID",
                keyValue: 3,
                column: "Location",
                value: "0107 Effertz Fords");

            migrationBuilder.UpdateData(
                table: "OfficeAssignments",
                keyColumn: "InstructorID",
                keyValue: 4,
                column: "Location",
                value: "325 Steuber Lights");

            migrationBuilder.UpdateData(
                table: "OfficeAssignments",
                keyColumn: "InstructorID",
                keyValue: 5,
                column: "Location",
                value: "279 Jewess Common");

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "EnrollmentDate", "FirstMidName", "LastName" },
                values: new object[] { new DateTime(1982, 11, 26, 0, 0, 0, 0, DateTimeKind.Utc), "Zelda", "Harvey" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "EnrollmentDate", "FirstMidName", "LastName" },
                values: new object[] { new DateTime(2001, 5, 16, 0, 0, 0, 0, DateTimeKind.Utc), "Amira", "Marvin" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "EnrollmentDate", "FirstMidName", "LastName" },
                values: new object[] { new DateTime(1968, 12, 5, 0, 0, 0, 0, DateTimeKind.Utc), "Naomie", "Barton" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "EnrollmentDate", "FirstMidName", "LastName" },
                values: new object[] { new DateTime(1973, 12, 11, 0, 0, 0, 0, DateTimeKind.Utc), "Ewald", "Balistreri" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "EnrollmentDate", "FirstMidName", "LastName" },
                values: new object[] { new DateTime(1971, 7, 16, 0, 0, 0, 0, DateTimeKind.Utc), "Joshuah", "Rice" });
        }
    }
}
