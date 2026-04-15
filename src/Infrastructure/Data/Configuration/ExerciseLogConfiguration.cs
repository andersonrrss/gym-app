using GymApp.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GymApp.Infrastructure;

public class ExerciseLogConfiguration : IEntityTypeConfiguration<ExerciseLog>
{
    public void Configure(EntityTypeBuilder<ExerciseLog> builder)
    {
        builder.HasOne(el => el.WorkoutLog)
            .WithMany(wl => wl.ExercisesLogs)
            .HasForeignKey(el => el.WorkoutLogId)
            .OnDelete(DeleteBehavior.Restrict);
        builder.HasOne(el => el.Exercise)
            .WithMany()
            .HasForeignKey(el => el.ExerciseId)
            .OnDelete(DeleteBehavior.Cascade);
    }
}
