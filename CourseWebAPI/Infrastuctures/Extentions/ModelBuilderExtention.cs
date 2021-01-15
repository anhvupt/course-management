using CourseWebAPI.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using System;
using System.Collections.Generic;
using System.Text;

namespace CourseWebAPI.Extentions
{
    public static class ModelBuilderExtention
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.SeedStudent();
            modelBuilder.SeedInstuctor();
            modelBuilder.SeedOfficeAssignment();
            modelBuilder.SeedDepartment();
            modelBuilder.SeedCourse();
            modelBuilder.SeedCourseAssignment();
            modelBuilder.SeedEnrollment();
        }

        private static void SeedStudent(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Student>().HasData(
                new Student
                {
                    Id = 1,
                    LastName = Faker.Name.Last(),
                    FirstMidName = Faker.Name.First(),
                    EnrollmentDate = Faker.Identification.DateOfBirth()
                },
                new Student
                {
                    Id = 2,
                    LastName = Faker.Name.Last(),
                    FirstMidName = Faker.Name.First(),
                    EnrollmentDate = Faker.Identification.DateOfBirth()
                },
                new Student
                {
                    Id = 3,
                    LastName = Faker.Name.Last(),
                    FirstMidName = Faker.Name.First(),
                    EnrollmentDate = Faker.Identification.DateOfBirth()
                },
                new Student
                {
                    Id = 4,
                    LastName = Faker.Name.Last(),
                    FirstMidName = Faker.Name.First(),
                    EnrollmentDate = Faker.Identification.DateOfBirth()
                },
                new Student
                {
                    Id = 5,
                    LastName = Faker.Name.Last(),
                    FirstMidName = Faker.Name.First(),
                    EnrollmentDate = Faker.Identification.DateOfBirth()
                }
            );
        }
        private static void SeedInstuctor(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Instructor>().HasData(
                new Instructor
                {
                    ID = 1,
                    LastName = Faker.Name.Last(),
                    FistMidName = Faker.Name.First(),
                    HireDate = DateTime.Now,
                },
                new Instructor
                {
                    ID = 2,
                    LastName = Faker.Name.Last(),
                    FistMidName = Faker.Name.First(),
                    HireDate = DateTime.Now,
                },
                new Instructor
                {
                    ID = 3,
                    LastName = Faker.Name.Last(),
                    FistMidName = Faker.Name.First(),
                    HireDate = DateTime.Now,
                },
                new Instructor
                {
                    ID = 4,
                    LastName = Faker.Name.Last(),
                    FistMidName = Faker.Name.First(),
                    HireDate = DateTime.Now,
                },
                new Instructor
                {
                    ID = 5,
                    LastName = Faker.Name.Last(),
                    FistMidName = Faker.Name.First(),
                    HireDate = DateTime.Now,
                }
            );
        }
        private static void SeedOfficeAssignment(this ModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<OfficeAssignment>().HasData(
            //    new OfficeAssignment
            //    {
            //        InstructorID = 1,
            //        Location = Faker.Address.StreetAddress()
            //    },
            //    new OfficeAssignment
            //    {
            //        InstructorID = 2,
            //        Location = Faker.Address.StreetAddress()
            //    },
            //    new OfficeAssignment
            //    {
            //        InstructorID = 3,
            //        Location = Faker.Address.StreetAddress()
            //    },
            //    new OfficeAssignment
            //    {
            //        InstructorID = 4,
            //        Location = Faker.Address.StreetAddress()
            //    },
            //    new OfficeAssignment
            //    {
            //        InstructorID = 5,
            //        Location = Faker.Address.StreetAddress()
            //    }
            //);
        }
        private static void SeedDepartment(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Department>().HasData(
                new Department
                {
                    DepartmentID = 1,
                    Name = Faker.Name.FullName(),
                    Budget = Faker.RandomNumber.Next(),
                    StartDate = DateTime.Now,
                    InstructorID = 1,
                },
                new Department
                {
                    DepartmentID = 2,
                    Name = Faker.Name.FullName(),
                    Budget = Faker.RandomNumber.Next(),
                    StartDate = DateTime.Now,
                    InstructorID = 2,
                },
                new Department
                {
                    DepartmentID = 3,
                    Name = Faker.Name.FullName(),
                    Budget = Faker.RandomNumber.Next(),
                    StartDate = DateTime.Now,
                    InstructorID = 3,
                },
                new Department
                {
                    DepartmentID = 4,
                    Name = Faker.Name.FullName(),
                    Budget = Faker.RandomNumber.Next(),
                    StartDate = DateTime.Now,
                    InstructorID = 4,
                },
                new Department
                {
                    DepartmentID = 5,
                    Name = Faker.Name.FullName(),
                    Budget = Faker.RandomNumber.Next(),
                    StartDate = DateTime.Now,
                    InstructorID = 5,
                }
            );
        }
        private static void SeedCourse(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Course>().HasData(
                new Course
                {
                    ID = 1,
                    Title = Faker.Lorem.Sentence(),
                    CourseCredit = Faker.RandomNumber.Next(),
                    DepartmentID = 5
                },
                new Course
                {
                    ID = 2,
                    Title = Faker.Lorem.Sentence(),
                    CourseCredit = Faker.RandomNumber.Next(),
                    DepartmentID = 5
                },
                new Course
                {
                    ID = 3,
                    Title = Faker.Lorem.Sentence(),
                    CourseCredit = Faker.RandomNumber.Next(),
                    DepartmentID = 4
                },
                new Course
                {
                    ID = 4,
                    Title = Faker.Lorem.Sentence(),
                    CourseCredit = Faker.RandomNumber.Next(),
                    DepartmentID = 4
                },
                new Course
                {
                    ID = 5,
                    Title = Faker.Lorem.Sentence(),
                    CourseCredit = Faker.RandomNumber.Next(),
                    DepartmentID = 3
                },
                new Course
                {
                    ID = 6,
                    Title = Faker.Lorem.Sentence(),
                    CourseCredit = Faker.RandomNumber.Next(),
                    DepartmentID = 3
                },
                new Course
                {
                    ID = 7,
                    Title = Faker.Lorem.Sentence(),
                    CourseCredit = Faker.RandomNumber.Next(),
                    DepartmentID = 2
                },
                new Course
                {
                    ID = 8,
                    Title = Faker.Lorem.Sentence(),
                    CourseCredit = Faker.RandomNumber.Next(),
                    DepartmentID = 2
                },
                new Course
                {
                    ID = 9,
                    Title = Faker.Lorem.Sentence(),
                    CourseCredit = Faker.RandomNumber.Next(),
                    DepartmentID = 1
                },
                new Course
                {
                    ID = 10,
                    Title = Faker.Lorem.Sentence(),
                    CourseCredit = Faker.RandomNumber.Next(),
                    DepartmentID = 1
                }
            );
        }
        private static void SeedCourseAssignment(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CourseAssignment>().HasData(
                new CourseAssignment { CourseID = 1, InstructorID = 1 },
                new CourseAssignment { CourseID = 2, InstructorID = 1 },
                new CourseAssignment { CourseID = 3, InstructorID = 2 },
                new CourseAssignment { CourseID = 4, InstructorID = 2 },
                new CourseAssignment { CourseID = 5, InstructorID = 3 },
                new CourseAssignment { CourseID = 6, InstructorID = 3 },
                new CourseAssignment { CourseID = 7, InstructorID = 4 },
                new CourseAssignment { CourseID = 8, InstructorID = 4 },
                new CourseAssignment { CourseID = 9, InstructorID = 5 },
                new CourseAssignment { CourseID = 10, InstructorID = 5 }
            );
        }
        private static void SeedEnrollment(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Enrollment>().HasData(
                new Enrollment
                {
                    EnrollmentID = 1,
                    CourseID = 1,
                    StudentID = 1,
                    Grade = EnrollmentGrade.None
                },
                new Enrollment
                {
                    EnrollmentID = 2,
                    CourseID = 2,
                    StudentID = 1,
                    Grade = EnrollmentGrade.None
                },
                new Enrollment
                {
                    EnrollmentID = 3,
                    CourseID = 3,
                    StudentID = 2,
                    Grade = EnrollmentGrade.C
                },
                new Enrollment
                {
                    EnrollmentID = 4,
                    CourseID = 4,
                    StudentID = 2,
                    Grade = EnrollmentGrade.A
                },
                new Enrollment
                {
                    EnrollmentID = 5,
                    CourseID = 5,
                    StudentID = 3,
                    Grade = EnrollmentGrade.A
                },
                new Enrollment
                {
                    EnrollmentID = 6,
                    CourseID = 6,
                    StudentID = 3,
                    Grade = EnrollmentGrade.None
                },
                new Enrollment
                {
                    EnrollmentID = 7,
                    CourseID = 7,
                    StudentID = 4,
                    Grade = EnrollmentGrade.D
                },
                new Enrollment
                {
                    EnrollmentID = 8,
                    CourseID = 8,
                    StudentID = 4,
                    Grade = EnrollmentGrade.C
                },
                new Enrollment
                {
                    EnrollmentID = 9,
                    CourseID = 9,
                    StudentID = 5,
                    Grade = EnrollmentGrade.B
                },
                new Enrollment
                {
                    EnrollmentID = 10,
                    CourseID = 10,
                    StudentID = 5,
                    Grade = EnrollmentGrade.A
                }
            );
        }
    }
}
