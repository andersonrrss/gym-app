using GymApp.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GymApp.Infrastructure;

public class WorkoutLogConfiguration : IEntityTypeConfiguration<WorkoutLog>
{
    public void Configure(EntityTypeBuilder<WorkoutLog> builder)
    {
        builder.HasOne(wl => wl.Workout)
            .WithMany()
            .HasForeignKey(wl => wl.WorkoutId)
            .OnDelete(DeleteBehavior.SetNull);
    }
}
