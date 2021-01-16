using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CourseWebAPI.Migrations
{
    public partial class EditInstructorFirstMidNameField : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "FistMidName",
                table: "Instructors",
                newName: "FirstMidName");

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "CourseCredit", "Title" },
                values: new object[] { -970489978, "Rerum exercitationem quo aliquid ut." });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "CourseCredit", "Title" },
                values: new object[] { 333205708, "Velit voluptas deleniti nulla voluptas possimus blanditiis." });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "CourseCredit", "Title" },
                values: new object[] { -1240201731, "Ullam et debitis et molestias dolore aut sit." });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "CourseCredit", "Title" },
                values: new object[] { 1911597613, "Mollitia libero nihil magni rem accusantium delectus soluta error maxime." });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "CourseCredit", "Title" },
                values: new object[] { 1723372158, "Et rerum cumque rerum at magni." });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "ID",
                keyValue: 6,
                columns: new[] { "CourseCredit", "Title" },
                values: new object[] { -593422525, "Ipsum asperiores quaerat repellat veritatis quisquam tenetur aut tenetur fugit." });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "ID",
                keyValue: 7,
                columns: new[] { "CourseCredit", "Title" },
                values: new object[] { -1003881047, "Tempore debitis dolor vitae blanditiis reiciendis voluptatem ea rerum." });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "ID",
                keyValue: 8,
                columns: new[] { "CourseCredit", "Title" },
                values: new object[] { 3396166, "Dolorum molestiae doloribus illo et aut ut dolorem deleniti." });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "ID",
                keyValue: 9,
                columns: new[] { "CourseCredit", "Title" },
                values: new object[] { -1100486295, "Illum corporis nisi commodi repudiandae beatae." });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "ID",
                keyValue: 10,
                columns: new[] { "CourseCredit", "Title" },
                values: new object[] { 1146623472, "Veritatis est est harum ipsam accusamus architecto aperiam dicta voluptatibus." });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "DepartmentID",
                keyValue: 1,
                columns: new[] { "Budget", "Name", "StartDate" },
                values: new object[] { -1533183605.0, "Nikki Okuneva", new DateTime(2021, 1, 15, 17, 34, 38, 244, DateTimeKind.Local).AddTicks(7768) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "DepartmentID",
                keyValue: 2,
                columns: new[] { "Budget", "Name", "StartDate" },
                values: new object[] { 861049257.0, "Tommie Hoppe", new DateTime(2021, 1, 15, 17, 34, 38, 245, DateTimeKind.Local).AddTicks(1041) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "DepartmentID",
                keyValue: 3,
                columns: new[] { "Budget", "Name", "StartDate" },
                values: new object[] { -1091453409.0, "Edwina Rath", new DateTime(2021, 1, 15, 17, 34, 38, 245, DateTimeKind.Local).AddTicks(2326) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "DepartmentID",
                keyValue: 4,
                columns: new[] { "Budget", "Name", "StartDate" },
                values: new object[] { 603782830.0, "Mrs. Adan Nikolaus", new DateTime(2021, 1, 15, 17, 34, 38, 245, DateTimeKind.Local).AddTicks(5820) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "DepartmentID",
                keyValue: 5,
                columns: new[] { "Budget", "Name", "StartDate" },
                values: new object[] { 1379971421.0, "Josephine Skiles", new DateTime(2021, 1, 15, 17, 34, 38, 245, DateTimeKind.Local).AddTicks(7724) });

            migrationBuilder.UpdateData(
                table: "Instructors",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "FirstMidName", "HireDate", "LastName" },
                values: new object[] { "Jude", new DateTime(2021, 1, 15, 17, 34, 38, 233, DateTimeKind.Local).AddTicks(9488), "Morar" });

            migrationBuilder.UpdateData(
                table: "Instructors",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "FirstMidName", "HireDate", "LastName" },
                values: new object[] { "Delores", new DateTime(2021, 1, 15, 17, 34, 38, 235, DateTimeKind.Local).AddTicks(2216), "Larkin" });

            migrationBuilder.UpdateData(
                table: "Instructors",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "FirstMidName", "HireDate", "LastName" },
                values: new object[] { "Catharine", new DateTime(2021, 1, 15, 17, 34, 38, 235, DateTimeKind.Local).AddTicks(4551), "Hoeger" });

            migrationBuilder.UpdateData(
                table: "Instructors",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "FirstMidName", "HireDate", "LastName" },
                values: new object[] { "Hertha", new DateTime(2021, 1, 15, 17, 34, 38, 235, DateTimeKind.Local).AddTicks(6710), "Streich" });

            migrationBuilder.UpdateData(
                table: "Instructors",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "FirstMidName", "HireDate", "LastName" },
                values: new object[] { "Ernie", new DateTime(2021, 1, 15, 17, 34, 38, 235, DateTimeKind.Local).AddTicks(8178), "Littel" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "EnrollmentDate", "FirstMidName", "LastName" },
                values: new object[] { new DateTime(2003, 11, 12, 0, 0, 0, 0, DateTimeKind.Utc), "Sharon", "Raynor" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "EnrollmentDate", "FirstMidName", "LastName" },
                values: new object[] { new DateTime(1997, 5, 11, 0, 0, 0, 0, DateTimeKind.Utc), "Araceli", "Jewess" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "EnrollmentDate", "FirstMidName", "LastName" },
                values: new object[] { new DateTime(1907, 2, 17, 0, 0, 0, 0, DateTimeKind.Utc), "Opal", "Gutmann" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "EnrollmentDate", "FirstMidName", "LastName" },
                values: new object[] { new DateTime(1995, 8, 6, 0, 0, 0, 0, DateTimeKind.Utc), "Linda", "Champlin" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "EnrollmentDate", "FirstMidName", "LastName" },
                values: new object[] { new DateTime(1973, 11, 17, 0, 0, 0, 0, DateTimeKind.Utc), "Devin", "Gerhold" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "FirstMidName",
                table: "Instructors",
                newName: "FistMidName");

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "CourseCredit", "Title" },
                values: new object[] { 1879190428, "Modi explicabo esse deserunt." });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "CourseCredit", "Title" },
                values: new object[] { 330453738, "Voluptatum magnam perspiciatis aliquam consequatur." });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "CourseCredit", "Title" },
                values: new object[] { -230306062, "Sunt eos suscipit qui rerum delectus dolores." });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "CourseCredit", "Title" },
                values: new object[] { 1730633285, "Explicabo et magni vel consequatur." });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "CourseCredit", "Title" },
                values: new object[] { 1372973033, "Cupiditate facere tenetur voluptatem vero quis officia illum delectus." });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "ID",
                keyValue: 6,
                columns: new[] { "CourseCredit", "Title" },
                values: new object[] { -2870778, "Est dolorem ipsam illum." });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "ID",
                keyValue: 7,
                columns: new[] { "CourseCredit", "Title" },
                values: new object[] { -115095350, "Blanditiis ea iste reiciendis sequi cum ipsam." });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "ID",
                keyValue: 8,
                columns: new[] { "CourseCredit", "Title" },
                values: new object[] { 1594434981, "Qui qui officia aperiam doloremque facilis rerum dolores." });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "ID",
                keyValue: 9,
                columns: new[] { "CourseCredit", "Title" },
                values: new object[] { -1872343641, "Laudantium sit cum perspiciatis." });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "ID",
                keyValue: 10,
                columns: new[] { "CourseCredit", "Title" },
                values: new object[] { 186760381, "Nesciunt architecto quia asperiores." });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "DepartmentID",
                keyValue: 1,
                columns: new[] { "Budget", "Name", "StartDate" },
                values: new object[] { 2011064282.0, "Mrs. Mellie Labadie", new DateTime(2021, 1, 15, 1, 30, 21, 790, DateTimeKind.Local).AddTicks(9309) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "DepartmentID",
                keyValue: 2,
                columns: new[] { "Budget", "Name", "StartDate" },
                values: new object[] { -543478924.0, "Bertha Schiller", new DateTime(2021, 1, 15, 1, 30, 21, 792, DateTimeKind.Local).AddTicks(1037) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "DepartmentID",
                keyValue: 3,
                columns: new[] { "Budget", "Name", "StartDate" },
                values: new object[] { -597151893.0, "Louie Brekke", new DateTime(2021, 1, 15, 1, 30, 21, 792, DateTimeKind.Local).AddTicks(4995) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "DepartmentID",
                keyValue: 4,
                columns: new[] { "Budget", "Name", "StartDate" },
                values: new object[] { 1083842602.0, "Margie Connelly", new DateTime(2021, 1, 15, 1, 30, 21, 792, DateTimeKind.Local).AddTicks(7606) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "DepartmentID",
                keyValue: 5,
                columns: new[] { "Budget", "Name", "StartDate" },
                values: new object[] { -619048428.0, "Florence Weimann", new DateTime(2021, 1, 15, 1, 30, 21, 793, DateTimeKind.Local).AddTicks(39) });

            migrationBuilder.UpdateData(
                table: "Instructors",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "FistMidName", "HireDate", "LastName" },
                values: new object[] { "Trey", new DateTime(2021, 1, 15, 1, 30, 21, 780, DateTimeKind.Local).AddTicks(2597), "Renner" });

            migrationBuilder.UpdateData(
                table: "Instructors",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "FistMidName", "HireDate", "LastName" },
                values: new object[] { "Irving", new DateTime(2021, 1, 15, 1, 30, 21, 781, DateTimeKind.Local).AddTicks(4628), "Von" });

            migrationBuilder.UpdateData(
                table: "Instructors",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "FistMidName", "HireDate", "LastName" },
                values: new object[] { "Marshall", new DateTime(2021, 1, 15, 1, 30, 21, 781, DateTimeKind.Local).AddTicks(6352), "Cormier" });

            migrationBuilder.UpdateData(
                table: "Instructors",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "FistMidName", "HireDate", "LastName" },
                values: new object[] { "Norma", new DateTime(2021, 1, 15, 1, 30, 21, 781, DateTimeKind.Local).AddTicks(8614), "Bernhard" });

            migrationBuilder.UpdateData(
                table: "Instructors",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "FistMidName", "HireDate", "LastName" },
                values: new object[] { "Zachary", new DateTime(2021, 1, 15, 1, 30, 21, 782, DateTimeKind.Local).AddTicks(577), "Nienow" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "EnrollmentDate", "FirstMidName", "LastName" },
                values: new object[] { new DateTime(1952, 2, 23, 0, 0, 0, 0, DateTimeKind.Utc), "Rhoda", "Renner" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "EnrollmentDate", "FirstMidName", "LastName" },
                values: new object[] { new DateTime(1992, 8, 15, 0, 0, 0, 0, DateTimeKind.Utc), "Winfield", "Boyer" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "EnrollmentDate", "FirstMidName", "LastName" },
                values: new object[] { new DateTime(1959, 5, 10, 0, 0, 0, 0, DateTimeKind.Utc), "Brisa", "Reinger" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "EnrollmentDate", "FirstMidName", "LastName" },
                values: new object[] { new DateTime(2007, 4, 28, 0, 0, 0, 0, DateTimeKind.Utc), "Jackeline", "Hodkiewicz" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "EnrollmentDate", "FirstMidName", "LastName" },
                values: new object[] { new DateTime(2017, 8, 6, 0, 0, 0, 0, DateTimeKind.Utc), "Ashley", "Bergnaum" });
        }
    }
}
