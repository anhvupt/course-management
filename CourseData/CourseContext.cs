using CourseData.Infrastructures.Extentions;
using CourseDomain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Microsoft.Extensions.Logging;
using System;

namespace CourseData
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

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder
                .UseSqlServer("Data Source=anhvupt\\anhvupt;Initial Catalog=CourseData;Integrated Security=True");
            }
        }
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
                .HasForeignKey(ca => ca.CourseID);
            modelBuilder.Entity<CourseAssignment>()
                .HasOne(ca => ca.Instructor)
                .WithMany(i => i.CourseAssignments)
                .HasForeignKey(ca => ca.InstructorID);

            modelBuilder.Entity<OfficeAssignment>()
                .HasKey(oa => new { oa.InstructorID });
            modelBuilder.Entity<OfficeAssignment>()
                .Property(p => p.InstructorID).ValueGeneratedNever();

            modelBuilder.Seed();

            //modelBuilder.Entity<Instructor>()
            //    .HasOne(i => i.OfficeAssignment)
            //    .WithOne(o => o.Instructor)
            //    .HasForeignKey<OfficeAssignment>(oa => oa.InstructorID);
            //modelBuilder.Entity<Instructor>().ToTable("Instructor");
            //modelBuilder.Entity<OfficeAssignment>().ToTable("Instructor");
        }
    }
}
