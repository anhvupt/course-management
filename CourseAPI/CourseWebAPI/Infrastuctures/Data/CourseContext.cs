using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Microsoft.Extensions.Logging;
using System;
using CourseWebAPI.Entities;
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
        public DbSet<User> Users { get; set; }

        public static readonly ILoggerFactory ConsoleLoggerFactory
          = LoggerFactory.Create(builder =>
          {
              builder
               .AddFilter((category, level) =>
                   category == DbLoggerCategory.Database.Command.Name
                   && level == LogLevel.Information)
               .AddConsole();
          });

        public CourseContext() { }
        public CourseContext(DbContextOptions option) : base(option)
        {
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseLoggerFactory(ConsoleLoggerFactory).EnableSensitiveDataLogging();
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Enrollment>(builder =>
            {
                builder.Property(e => e.Grade).HasConversion(
                    new EnumToStringConverter<EnrollmentGrade>()
                );
            });

            modelBuilder.Entity<CourseAssignment>(builder =>
           {
               builder.HasKey(ca => new { ca.CourseID, ca.InstructorID });

               builder.HasOne(ca => ca.Course)
               .WithMany(c => c.CourseAssignments)
               .HasForeignKey(ca => ca.CourseID);

               builder.HasOne(ca => ca.Instructor)
                .WithMany(i => i.CourseAssignments)
                .HasForeignKey(ca => ca.InstructorID)
                .OnDelete(DeleteBehavior.Cascade);
           });

            modelBuilder.Entity<OfficeAssignment>(builder =>
            {
                builder.HasKey(oa => new { oa.InstructorID });
                builder.Property(p => p.InstructorID).ValueGeneratedNever();
            });

            modelBuilder.Entity<Instructor>(builder =>
            {
                builder.HasOne(i => i.OfficeAssignment)
                .WithOne(oa => oa.Instructor)
                .OnDelete(DeleteBehavior.Cascade);

                builder.HasMany(i => i.Departments)
                .WithOne(d => d.Administrator)
                .HasForeignKey(i => i.DepartmentID)
                .OnDelete(DeleteBehavior.SetNull);
            });

            modelBuilder.Entity<Department>(builder =>
            {
                builder.HasOne(d => d.Administrator)
                .WithMany(i => i.Departments)
                .HasForeignKey(d => d.InstructorID)
                .IsRequired(false);
            });
        }
    }
}
