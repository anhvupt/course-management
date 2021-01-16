using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Microsoft.Extensions.Logging;
using System;
using CourseWebAPI.Entities;
using CourseWebAPI.Extentions;
using Microsoft.Extensions.Configuration;

namespace CourseWebAPI.Data
{
    public class CourseContext : DbContext
    {
        public DbSet<Course> Courses { get; set; }
        public DbSet<CourseAssignment> CourseAssignments { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Enrollment> Enrollments { get; set; }
        public DbSet<Instructor> Instructors { get; set; }
        public DbSet<OfficeAssignment> OfficeAssignments { get; set; }
        public DbSet<Student> Students { get; set; }

        public CourseContext() { }
        public CourseContext(DbContextOptions option) : base(option) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Enrollment>()
                .Property(e => e.Grade).HasConversion(
                    new EnumToStringConverter<EnrollmentGrade>()
                );

            modelBuilder.Entity<CourseAssignment>()
                .HasKey(ca => new { ca.CourseID, ca.InstructorID });
            modelBuilder.Entity<CourseAssignment>()
                .HasOne(ca => ca.Course)
                .WithMany(c => c.CourseAssignments)
                .HasForeignKey(ca => ca.CourseID)
                .OnDelete(DeleteBehavior.Restrict);
            modelBuilder.Entity<CourseAssignment>()
                .HasOne(ca => ca.Instructor)
                .WithMany(i => i.CourseAssignments)
                .HasForeignKey(ca => ca.InstructorID)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<OfficeAssignment>()
                .HasKey(oa => new { oa.InstructorID });
            modelBuilder.Entity<OfficeAssignment>()
                .Property(p => p.InstructorID).ValueGeneratedNever();

            modelBuilder.Seed();

        }
    }
}
