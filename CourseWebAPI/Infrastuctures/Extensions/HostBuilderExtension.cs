using CourseWebAPI.Data;
using CourseWebAPI.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CourseWebAPI.Infrastuctures.Extensions
{
    public static class HostBuilderExtension
    {
        public static void Initialize(this IHost host)
        {
            using var scope = host.Services.CreateScope();
            var serviceProvider = scope.ServiceProvider;
            InitializeDatabase(serviceProvider);
        }

        private static void InitializeDatabase(IServiceProvider serviceProvider)
        {
            var context = serviceProvider.GetRequiredService<CourseContext>();
            context.SeedStudent();
            context.SeedInstuctor();
            context.SeedOfficeAssignment();
            context.SeedDepartment();
            context.SeedCourse();
            context.SeedCourseAssignment();
            context.SeedEnrollment();
            try
            {
                context.Database.ExecuteSqlRaw("SET IDENTITY_INSERT dbo.Students ON");
                context.Database.ExecuteSqlRaw("SET IDENTITY_INSERT dbo.Instructors ON");
                context.Database.ExecuteSqlRaw("SET IDENTITY_INSERT dbo.Departments ON");
                context.Database.ExecuteSqlRaw("SET IDENTITY_INSERT dbo.Courses ON");
                context.Database.ExecuteSqlRaw("SET IDENTITY_INSERT dbo.Enrollments ON");
                context.SaveChanges();
                context.Database.ExecuteSqlRaw("SET IDENTITY_INSERT dbo.Students OFF");
                context.Database.ExecuteSqlRaw("SET IDENTITY_INSERT dbo.Instructors OFF");
                context.Database.ExecuteSqlRaw("SET IDENTITY_INSERT dbo.Departments OFF");
                context.Database.ExecuteSqlRaw("SET IDENTITY_INSERT dbo.Courses OFF");
                context.Database.ExecuteSqlRaw("SET IDENTITY_INSERT dbo.Enrollments OFF");
            }
            finally
            {
                context.Database.CloseConnection();
            }
        }
        private static void SeedStudent(this CourseContext context)
        {
            if (!context.Students.Any())
            {
                context.Students.AddRange(new List<Student>
                {
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
                });
                //await context.SaveChangesAsync();
            }
        }
        private static void SeedInstuctor(this CourseContext context)
        {
            if (!context.Instructors.Any())
            {
                context.Instructors.AddRange(new List<Instructor>
                {
                    new Instructor
                    {
                        ID = 1,
                        LastName = Faker.Name.Last(),
                        FirstMidName = Faker.Name.First(),
                        HireDate = DateTime.Now,
                    },
                    new Instructor
                    {
                        ID = 2,
                        LastName = Faker.Name.Last(),
                        FirstMidName = Faker.Name.First(),
                        HireDate = DateTime.Now,
                    },
                    new Instructor
                    {
                        ID = 3,
                        LastName = Faker.Name.Last(),
                        FirstMidName = Faker.Name.First(),
                        HireDate = DateTime.Now,
                    },
                    new Instructor
                    {
                        ID = 4,
                        LastName = Faker.Name.Last(),
                        FirstMidName = Faker.Name.First(),
                        HireDate = DateTime.Now,
                    },
                    new Instructor
                    {
                        ID = 5,
                        LastName = Faker.Name.Last(),
                        FirstMidName = Faker.Name.First(),
                        HireDate = DateTime.Now,
                    }
                });
                //await context.SaveChangesAsync();
            }
        }
        private static void SeedOfficeAssignment(this CourseContext context)
        {
            if (!context.OfficeAssignments.Any())
            {
                context.OfficeAssignments.AddRange(new List<OfficeAssignment> {
                    new OfficeAssignment
                    {
                        InstructorID = 1,
                        Location = Faker.Address.StreetAddress()
                    },
                    new OfficeAssignment
                    {
                        InstructorID = 2,
                        Location = Faker.Address.StreetAddress()
                    },
                    new OfficeAssignment
                    {
                        InstructorID = 3,
                        Location = Faker.Address.StreetAddress()
                    },
                    new OfficeAssignment
                    {
                        InstructorID = 4,
                        Location = Faker.Address.StreetAddress()
                    },
                    new OfficeAssignment
                    {
                        InstructorID = 5,
                        Location = Faker.Address.StreetAddress()
                    }
                });
                //await context.SaveChangesAsync();
            }
        }
        private static void SeedDepartment(this CourseContext context)
        {
            if (!context.Departments.Any())
            {
                context.Departments.AddRange(new List<Department> {
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
                });
                //await context.SaveChangesAsync();
            }
        }
        private static void SeedCourse(this CourseContext context)
        {
            if (!context.Courses.Any())
            {
                context.Courses.AddRange(new List<Course> {
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
                });
                //await context.SaveChangesAsync();
            }
        }
        private static void SeedCourseAssignment(this CourseContext context)
        {
            if (!context.CourseAssignments.Any())
            {
                context.CourseAssignments.AddRange(new List<CourseAssignment> {
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
                });
                //await context.SaveChangesAsync();
            }
        }
        private static void SeedEnrollment(this CourseContext context)
        {
            if (!context.Enrollments.Any())
            {
                context.Enrollments.AddRange(new List<Enrollment> {
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
                });
                //await context.SaveChangesAsync();
            }
        }

    }
}
