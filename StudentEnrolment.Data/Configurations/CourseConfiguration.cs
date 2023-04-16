using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace StudentEnrolment.Data.Configurations
{
    internal class CourseConfiguration : IEntityTypeConfiguration<Course>
    {
        public void Configure(EntityTypeBuilder<Course> builder)
        {
            builder.HasData(
                new Course
                {
                    Id = 1,
                    Title = "Minimal API Development",
                    Credits = 3
                },
                new Course
                {
                    Id = 2,
                    Title = "Ultimate AP Development",
                    Credits = 5
                }
            );
        }
    }
}
