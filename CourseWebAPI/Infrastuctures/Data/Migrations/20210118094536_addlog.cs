using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CourseWebAPI.Migrations
{
    public partial class addlog : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "CourseCredit", "Title" },
                values: new object[] { -1935164867, "Laborum in deleniti blanditiis eaque pariatur." });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "CourseCredit", "Title" },
                values: new object[] { -45201723, "In qui enim ratione et iusto." });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "CourseCredit", "Title" },
                values: new object[] { 1540690968, "Eaque vero velit placeat ab veritatis ea assumenda." });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "CourseCredit", "Title" },
                values: new object[] { 1530852990, "Qui accusamus aliquid quibusdam dolorem nihil et ipsa reiciendis exercitationem." });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "CourseCredit", "Title" },
                values: new object[] { -1537799666, "Consectetur nam nulla alias assumenda ut nihil beatae quae laborum." });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "ID",
                keyValue: 6,
                columns: new[] { "CourseCredit", "Title" },
                values: new object[] { -1048257844, "Vero necessitatibus natus et dolor odio labore vero quia." });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "ID",
                keyValue: 7,
                columns: new[] { "CourseCredit", "Title" },
                values: new object[] { 1265853722, "Voluptas minus nihil ipsa facere doloremque commodi modi." });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "ID",
                keyValue: 8,
                columns: new[] { "CourseCredit", "Title" },
                values: new object[] { 152681762, "Earum tempora cum atque error ut illo." });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "ID",
                keyValue: 9,
                columns: new[] { "CourseCredit", "Title" },
                values: new object[] { -674229058, "Et et sed qui nesciunt labore." });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "ID",
                keyValue: 10,
                columns: new[] { "CourseCredit", "Title" },
                values: new object[] { 396911523, "Molestiae necessitatibus magnam aut voluptatem dolorem." });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "DepartmentID",
                keyValue: 1,
                columns: new[] { "Budget", "Name", "StartDate" },
                values: new object[] { 1486748974.0, "Alanis Lynch", new DateTime(2021, 1, 18, 15, 26, 44, 40, DateTimeKind.Local).AddTicks(8978) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "DepartmentID",
                keyValue: 2,
                columns: new[] { "Budget", "Name", "StartDate" },
                values: new object[] { -654048269.0, "Maia Bednar II", new DateTime(2021, 1, 18, 15, 26, 44, 41, DateTimeKind.Local).AddTicks(5562) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "DepartmentID",
                keyValue: 3,
                columns: new[] { "Budget", "Name", "StartDate" },
                values: new object[] { -957636820.0, "Miss Glennie Deckow", new DateTime(2021, 1, 18, 15, 26, 44, 42, DateTimeKind.Local).AddTicks(247) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "DepartmentID",
                keyValue: 4,
                columns: new[] { "Budget", "Name", "StartDate" },
                values: new object[] { 1626203794.0, "Dudley Connelly", new DateTime(2021, 1, 18, 15, 26, 44, 42, DateTimeKind.Local).AddTicks(2523) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "DepartmentID",
                keyValue: 5,
                columns: new[] { "Budget", "Name", "StartDate" },
                values: new object[] { 1121808219.0, "Kiel Tillman", new DateTime(2021, 1, 18, 15, 26, 44, 42, DateTimeKind.Local).AddTicks(4796) });

            migrationBuilder.UpdateData(
                table: "Instructors",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "FirstMidName", "HireDate", "LastName" },
                values: new object[] { "Laurie", new DateTime(2021, 1, 18, 15, 26, 44, 18, DateTimeKind.Local).AddTicks(7902), "Maggio" });

            migrationBuilder.UpdateData(
                table: "Instructors",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "FirstMidName", "HireDate", "LastName" },
                values: new object[] { "Gage", new DateTime(2021, 1, 18, 15, 26, 44, 20, DateTimeKind.Local).AddTicks(3817), "Swaniawski" });

            migrationBuilder.UpdateData(
                table: "Instructors",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "FirstMidName", "HireDate", "LastName" },
                values: new object[] { "Dorothy", new DateTime(2021, 1, 18, 15, 26, 44, 20, DateTimeKind.Local).AddTicks(6770), "Spinka" });

            migrationBuilder.UpdateData(
                table: "Instructors",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "FirstMidName", "HireDate", "LastName" },
                values: new object[] { "Palma", new DateTime(2021, 1, 18, 15, 26, 44, 20, DateTimeKind.Local).AddTicks(9106), "Keeling" });

            migrationBuilder.UpdateData(
                table: "Instructors",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "FirstMidName", "HireDate", "LastName" },
                values: new object[] { "Jerrold", new DateTime(2021, 1, 18, 15, 26, 44, 21, DateTimeKind.Local).AddTicks(1758), "Jacobson" });

            migrationBuilder.UpdateData(
                table: "OfficeAssignments",
                keyColumn: "InstructorID",
                keyValue: 1,
                column: "Location",
                value: "271 Metz Roads");

            migrationBuilder.UpdateData(
                table: "OfficeAssignments",
                keyColumn: "InstructorID",
                keyValue: 2,
                column: "Location",
                value: "261 Fleta Summit");

            migrationBuilder.UpdateData(
                table: "OfficeAssignments",
                keyColumn: "InstructorID",
                keyValue: 3,
                column: "Location",
                value: "19785 Waelchi Gateway");

            migrationBuilder.UpdateData(
                table: "OfficeAssignments",
                keyColumn: "InstructorID",
                keyValue: 4,
                column: "Location",
                value: "73906 Parker ");

            migrationBuilder.UpdateData(
                table: "OfficeAssignments",
                keyColumn: "InstructorID",
                keyValue: 5,
                column: "Location",
                value: "46552 Yost Radial");

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "EnrollmentDate", "FirstMidName", "LastName" },
                values: new object[] { new DateTime(1926, 6, 11, 0, 0, 0, 0, DateTimeKind.Utc), "Herman", "Eichmann" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "EnrollmentDate", "FirstMidName", "LastName" },
                values: new object[] { new DateTime(1942, 7, 4, 0, 0, 0, 0, DateTimeKind.Utc), "Ebba", "Rau" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "EnrollmentDate", "FirstMidName", "LastName" },
                values: new object[] { new DateTime(1922, 5, 2, 0, 0, 0, 0, DateTimeKind.Utc), "Annette", "Grady" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "EnrollmentDate", "FirstMidName", "LastName" },
                values: new object[] { new DateTime(1965, 7, 17, 0, 0, 0, 0, DateTimeKind.Utc), "Megane", "Wuckert" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "EnrollmentDate", "FirstMidName", "LastName" },
                values: new object[] { new DateTime(1959, 4, 14, 0, 0, 0, 0, DateTimeKind.Utc), "Rubye", "Wunsch" });
        }
    }
}
