﻿// <auto-generated />
using System;
using CourseData;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CourseData.Migrations
{
    [DbContext(typeof(CourseContext))]
    partial class CourseContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.2");

            modelBuilder.Entity("CourseDomain.Course", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("CourseCredit")
                        .HasColumnType("int");

                    b.Property<int>("DepartmentID")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Courses");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            CourseCredit = -10614573,
                            DepartmentID = 5,
                            Title = "Libero impedit dolorem quaerat ut numquam praesentium consequatur ducimus."
                        },
                        new
                        {
                            ID = 2,
                            CourseCredit = -93618281,
                            DepartmentID = 5,
                            Title = "Qui ratione et sed minima."
                        },
                        new
                        {
                            ID = 3,
                            CourseCredit = -1148932920,
                            DepartmentID = 4,
                            Title = "Voluptatem et nam est."
                        },
                        new
                        {
                            ID = 4,
                            CourseCredit = 669948368,
                            DepartmentID = 4,
                            Title = "Tempora sunt qui suscipit nobis culpa enim et."
                        },
                        new
                        {
                            ID = 5,
                            CourseCredit = -873981294,
                            DepartmentID = 3,
                            Title = "Maxime ea minima omnis."
                        },
                        new
                        {
                            ID = 6,
                            CourseCredit = -1905565977,
                            DepartmentID = 3,
                            Title = "Nulla at atque nulla animi quis vel."
                        },
                        new
                        {
                            ID = 7,
                            CourseCredit = -429650130,
                            DepartmentID = 2,
                            Title = "Placeat cum reprehenderit ab similique ab repellendus."
                        },
                        new
                        {
                            ID = 8,
                            CourseCredit = 967297127,
                            DepartmentID = 2,
                            Title = "Accusantium ipsam quidem odio ut libero assumenda illo."
                        },
                        new
                        {
                            ID = 9,
                            CourseCredit = -864927950,
                            DepartmentID = 1,
                            Title = "Facere tempora nesciunt dolor molestias quia ipsam dicta omnis."
                        },
                        new
                        {
                            ID = 10,
                            CourseCredit = 2142055491,
                            DepartmentID = 1,
                            Title = "Illo et dolorem nemo facere aut ipsum minima voluptatem blanditiis."
                        });
                });

            modelBuilder.Entity("CourseDomain.CourseAssignment", b =>
                {
                    b.Property<int>("CourseID")
                        .HasColumnType("int");

                    b.Property<int>("InstructorID")
                        .HasColumnType("int");

                    b.HasKey("CourseID", "InstructorID");

                    b.HasIndex("InstructorID");

                    b.ToTable("CourseAssignments");

                    b.HasData(
                        new
                        {
                            CourseID = 1,
                            InstructorID = 1
                        },
                        new
                        {
                            CourseID = 2,
                            InstructorID = 1
                        },
                        new
                        {
                            CourseID = 3,
                            InstructorID = 2
                        },
                        new
                        {
                            CourseID = 4,
                            InstructorID = 2
                        },
                        new
                        {
                            CourseID = 5,
                            InstructorID = 3
                        },
                        new
                        {
                            CourseID = 6,
                            InstructorID = 3
                        },
                        new
                        {
                            CourseID = 7,
                            InstructorID = 4
                        },
                        new
                        {
                            CourseID = 8,
                            InstructorID = 4
                        },
                        new
                        {
                            CourseID = 9,
                            InstructorID = 5
                        },
                        new
                        {
                            CourseID = 10,
                            InstructorID = 5
                        });
                });

            modelBuilder.Entity("CourseDomain.Department", b =>
                {
                    b.Property<int>("DepartmentID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<double>("Budget")
                        .HasColumnType("float");

                    b.Property<int>("InstructorID")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime2");

                    b.HasKey("DepartmentID");

                    b.HasIndex("InstructorID");

                    b.ToTable("Departments");

                    b.HasData(
                        new
                        {
                            DepartmentID = 1,
                            Budget = 306006358.0,
                            InstructorID = 1,
                            Name = "Mrs. Spencer Mueller",
                            StartDate = new DateTime(2021, 1, 13, 21, 10, 8, 811, DateTimeKind.Local).AddTicks(9269)
                        },
                        new
                        {
                            DepartmentID = 2,
                            Budget = -1255204266.0,
                            InstructorID = 2,
                            Name = "Moriah Wyman",
                            StartDate = new DateTime(2021, 1, 13, 21, 10, 8, 812, DateTimeKind.Local).AddTicks(5363)
                        },
                        new
                        {
                            DepartmentID = 3,
                            Budget = -222072614.0,
                            InstructorID = 3,
                            Name = "Brenden Denesik",
                            StartDate = new DateTime(2021, 1, 13, 21, 10, 8, 812, DateTimeKind.Local).AddTicks(7932)
                        },
                        new
                        {
                            DepartmentID = 4,
                            Budget = 1675345504.0,
                            InstructorID = 4,
                            Name = "Maxime Metz IV",
                            StartDate = new DateTime(2021, 1, 13, 21, 10, 8, 813, DateTimeKind.Local).AddTicks(3015)
                        },
                        new
                        {
                            DepartmentID = 5,
                            Budget = 165648845.0,
                            InstructorID = 5,
                            Name = "Providenci Cartwright",
                            StartDate = new DateTime(2021, 1, 13, 21, 10, 8, 813, DateTimeKind.Local).AddTicks(6562)
                        });
                });

            modelBuilder.Entity("CourseDomain.Enrollment", b =>
                {
                    b.Property<int>("EnrollmentID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("CourseID")
                        .HasColumnType("int");

                    b.Property<string>("Grade")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("StudentID")
                        .HasColumnType("int");

                    b.HasKey("EnrollmentID");

                    b.HasIndex("CourseID");

                    b.HasIndex("StudentID");

                    b.ToTable("Enrollments");

                    b.HasData(
                        new
                        {
                            EnrollmentID = 1,
                            CourseID = 1,
                            Grade = "None",
                            StudentID = 1
                        },
                        new
                        {
                            EnrollmentID = 2,
                            CourseID = 2,
                            Grade = "None",
                            StudentID = 1
                        },
                        new
                        {
                            EnrollmentID = 3,
                            CourseID = 3,
                            Grade = "C",
                            StudentID = 2
                        },
                        new
                        {
                            EnrollmentID = 4,
                            CourseID = 4,
                            Grade = "A",
                            StudentID = 2
                        },
                        new
                        {
                            EnrollmentID = 5,
                            CourseID = 5,
                            Grade = "A",
                            StudentID = 3
                        },
                        new
                        {
                            EnrollmentID = 6,
                            CourseID = 6,
                            Grade = "None",
                            StudentID = 3
                        },
                        new
                        {
                            EnrollmentID = 7,
                            CourseID = 7,
                            Grade = "D",
                            StudentID = 4
                        },
                        new
                        {
                            EnrollmentID = 8,
                            CourseID = 8,
                            Grade = "C",
                            StudentID = 4
                        },
                        new
                        {
                            EnrollmentID = 9,
                            CourseID = 9,
                            Grade = "B",
                            StudentID = 5
                        },
                        new
                        {
                            EnrollmentID = 10,
                            CourseID = 10,
                            Grade = "A",
                            StudentID = 5
                        });
                });

            modelBuilder.Entity("CourseDomain.Instructor", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("FistMidName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("HireDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Instructors");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            FistMidName = "Elena",
                            HireDate = new DateTime(2021, 1, 13, 21, 10, 8, 797, DateTimeKind.Local).AddTicks(2482),
                            LastName = "Ward"
                        },
                        new
                        {
                            ID = 2,
                            FistMidName = "Adriana",
                            HireDate = new DateTime(2021, 1, 13, 21, 10, 8, 799, DateTimeKind.Local).AddTicks(5379),
                            LastName = "Weber"
                        },
                        new
                        {
                            ID = 3,
                            FistMidName = "Laurianne",
                            HireDate = new DateTime(2021, 1, 13, 21, 10, 8, 799, DateTimeKind.Local).AddTicks(9336),
                            LastName = "Rohan"
                        },
                        new
                        {
                            ID = 4,
                            FistMidName = "Murray",
                            HireDate = new DateTime(2021, 1, 13, 21, 10, 8, 800, DateTimeKind.Local).AddTicks(2063),
                            LastName = "Cole"
                        },
                        new
                        {
                            ID = 5,
                            FistMidName = "Ollie",
                            HireDate = new DateTime(2021, 1, 13, 21, 10, 8, 800, DateTimeKind.Local).AddTicks(4776),
                            LastName = "Lynch"
                        });
                });

            modelBuilder.Entity("CourseDomain.OfficeAssignment", b =>
                {
                    b.Property<int>("InstructorID")
                        .HasColumnType("int");

                    b.Property<string>("Location")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("InstructorID");

                    b.ToTable("OfficeAssignments");
                });

            modelBuilder.Entity("CourseDomain.Student", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<DateTime>("EnrollmentDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("FirstMidName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Students");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            EnrollmentDate = new DateTime(2019, 7, 6, 0, 0, 0, 0, DateTimeKind.Utc),
                            FirstMidName = "Candido",
                            LastName = "Wunsch"
                        },
                        new
                        {
                            Id = 2,
                            EnrollmentDate = new DateTime(2014, 5, 25, 0, 0, 0, 0, DateTimeKind.Utc),
                            FirstMidName = "Madeline",
                            LastName = "Botsford"
                        },
                        new
                        {
                            Id = 3,
                            EnrollmentDate = new DateTime(1903, 6, 1, 0, 0, 0, 0, DateTimeKind.Utc),
                            FirstMidName = "Enid",
                            LastName = "Schmitt"
                        },
                        new
                        {
                            Id = 4,
                            EnrollmentDate = new DateTime(2017, 6, 30, 0, 0, 0, 0, DateTimeKind.Utc),
                            FirstMidName = "Frederique",
                            LastName = "Cummerata"
                        },
                        new
                        {
                            Id = 5,
                            EnrollmentDate = new DateTime(1959, 12, 7, 0, 0, 0, 0, DateTimeKind.Utc),
                            FirstMidName = "Floyd",
                            LastName = "Botsford"
                        });
                });

            modelBuilder.Entity("CourseDomain.CourseAssignment", b =>
                {
                    b.HasOne("CourseDomain.Course", "Course")
                        .WithMany("CourseAssignments")
                        .HasForeignKey("CourseID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CourseDomain.Instructor", "Instructor")
                        .WithMany("CourseAssignments")
                        .HasForeignKey("InstructorID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Course");

                    b.Navigation("Instructor");
                });

            modelBuilder.Entity("CourseDomain.Department", b =>
                {
                    b.HasOne("CourseDomain.Instructor", "Administator")
                        .WithMany()
                        .HasForeignKey("InstructorID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Administator");
                });

            modelBuilder.Entity("CourseDomain.Enrollment", b =>
                {
                    b.HasOne("CourseDomain.Course", "Course")
                        .WithMany("Enrollments")
                        .HasForeignKey("CourseID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CourseDomain.Student", "Student")
                        .WithMany("Enrollments")
                        .HasForeignKey("StudentID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Course");

                    b.Navigation("Student");
                });

            modelBuilder.Entity("CourseDomain.OfficeAssignment", b =>
                {
                    b.HasOne("CourseDomain.Instructor", "Instructor")
                        .WithOne("OfficeAssignment")
                        .HasForeignKey("CourseDomain.OfficeAssignment", "InstructorID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Instructor");
                });

            modelBuilder.Entity("CourseDomain.Course", b =>
                {
                    b.Navigation("CourseAssignments");

                    b.Navigation("Enrollments");
                });

            modelBuilder.Entity("CourseDomain.Instructor", b =>
                {
                    b.Navigation("CourseAssignments");

                    b.Navigation("OfficeAssignment");
                });

            modelBuilder.Entity("CourseDomain.Student", b =>
                {
                    b.Navigation("Enrollments");
                });
#pragma warning restore 612, 618
        }
    }
}
