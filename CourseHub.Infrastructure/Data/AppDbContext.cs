
using CourseHub.Domain.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
namespace CourseHub.Infrastructure.Data
{
    public class AppDbContext : IdentityDbContext<ApplicationUser>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Course> Courses { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Enrollment> Enrollments { get; set; } 
        public DbSet<Review> Reviews { get; set; }
        public DbSet<Category> Categories { get; set; } 
        public DbSet<Instructor> Instructors { get; set; }
        public DbSet<Lesson> Lessons { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Course → Instructor
            modelBuilder.Entity<Course>()
                .HasOne(c => c.Instructor)
                .WithMany(i => i.Courses)
                .HasForeignKey(c => c.InstructorId);

            // Course → Category
            modelBuilder.Entity<Course>()
                .HasOne(c => c.Category)
                .WithMany()
                .HasForeignKey(c => c.CategoryId);

            // Course → Reviews
            modelBuilder.Entity<Review>()
                .HasOne(r => r.Course)
                .WithMany(c => c.Reviews)
                .HasForeignKey(r => r.CourseId);

            // Course → Enrollments
            modelBuilder.Entity<Enrollment>()
                .HasOne(e => e.Course)
                .WithMany(c => c.Enrollments)
                .HasForeignKey(e => e.CourseId)
                .OnDelete(DeleteBehavior.Restrict);

            // Lesson → Course
            modelBuilder.Entity<Lesson>()
                .HasOne(l => l.Course)
                .WithMany(c => c.Lessons)
                .HasForeignKey(l => l.CourseId);

            // Review → student
            modelBuilder.Entity<Review>()
                .HasOne(r => r.Student)
                .WithMany(u => u.Reviews)
                .HasForeignKey(r => r.StudentId)
                .OnDelete(DeleteBehavior.Restrict);

            // Enrollment → student
            modelBuilder.Entity<Enrollment>()
                .HasOne(e => e.Student)
                .WithMany(u => u.Enrollments)
                .HasForeignKey(e => e.StudentId).
                OnDelete(DeleteBehavior.Restrict);

            // ApplicationUser → student
            modelBuilder.Entity<ApplicationUser>()
                .HasOne(a => a.StudentProfile)
                .WithOne(s => s.User)
                .HasForeignKey<Student>(s => s.UserId)
                .OnDelete(DeleteBehavior.Restrict);

            // ApplicationUser → instructor    
            modelBuilder.Entity<ApplicationUser>()
               .HasOne(a => a.InstructorProfile)
               .WithOne(i =>i.User )
               .HasForeignKey<Instructor>(i => i.UserId)
               .OnDelete(DeleteBehavior.Restrict);
        }

    }
}
