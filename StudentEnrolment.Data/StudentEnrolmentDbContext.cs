using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using StudentEnrolment.Data.Configurations;

namespace StudentEnrolment.Data
{
    public class StudentEnrolmentDbContext : IdentityDbContext
    {
        public StudentEnrolmentDbContext(DbContextOptions<StudentEnrolmentDbContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.ApplyConfiguration(new CourseConfiguration());
            builder.ApplyConfiguration(new UserRoleConfiguration());
        }

        public DbSet<Course> Courses { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Enrolment> Enrolments { get; set; }
    }
}
