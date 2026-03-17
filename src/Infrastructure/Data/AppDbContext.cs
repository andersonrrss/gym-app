using Microsoft.EntityFrameworkCore;
using GymApp.Domain.Entities;
using System.Reflection;
using System.Text.Json.Serialization;
using System.Text.Json;

namespace GymApp.Infrastructure.Data;

public class AppDbContext(DbContextOptions<AppDbContext> options) : DbContext(options)
{
    public DbSet<User> Users { get; private set; }

    public DbSet<Routine> Routines { get; private set; }

    public DbSet<Exercise> Exercises { get; private set; }
    public DbSet<MuscleGroup> MuscleGroups { get; private set; }
    
    public DbSet<Workout> Workouts { get; private set; } 
    public DbSet<WorkoutExercise> WorkoutExercises { get; private set; }

    public DbSet<WorkoutLog> WorkoutLogs { get; private set; }
    public DbSet<ExerciseLog> ExerciseLogs { get; private set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        var muscleGroups = LoadSeedData<MuscleGroup>(
            "GymApp.Infrastructure.Data.SeedData.MuscleGroups.json"
        );
        
        modelBuilder.Entity<MuscleGroup>().HasData(muscleGroups);

        var exercises = LoadSeedData<Exercise>(
            "GymApp.Infrastructure.Data.SeedData.Exercises.json"
        );

        modelBuilder.Entity<Exercise>().HasData(exercises);

        modelBuilder.Entity<Routine>()
            .HasOne(r => r.User)
            .WithMany(u => u.Routines)
            .HasForeignKey(r => r.UserId)
            .OnDelete(DeleteBehavior.Cascade);
        
        modelBuilder.Entity<Workout>()
            .HasOne(w => w.Routine)
            .WithMany(r => r.Workouts)
            .HasForeignKey(w => w.RoutineId)
            .OnDelete(DeleteBehavior.Cascade);

        modelBuilder.Entity<WorkoutExercise>()
            .HasOne(we => we.Workout)
            .WithMany(w => w.Exercises)
            .HasForeignKey(we => we.WorkoutId)
            .OnDelete(DeleteBehavior.Cascade);
        modelBuilder.Entity<WorkoutExercise>()
            .HasOne(we => we.Exercise)
            .WithMany()
            .HasForeignKey(we => we.ExerciseId)
            .OnDelete(DeleteBehavior.Cascade);

        modelBuilder.Entity<Exercise>()
            .HasOne(e => e.MuscleGroup)
            .WithMany(mg => mg.Exercises)
            .HasForeignKey(e => e.MuscleGroupId)
            .OnDelete(DeleteBehavior.SetNull);

        modelBuilder.Entity<WorkoutLog>()
            .HasOne(wl => wl.Workout)
            .WithMany()
            .HasForeignKey(wl => wl.WorkoutId)
            .OnDelete(DeleteBehavior.SetNull);

        modelBuilder.Entity<ExerciseLog>()
            .HasOne(wel => wel.WorkoutLog)
            .WithMany(wl => wl.ExercisesLogs)
            .HasForeignKey(wel => wel.WorkoutLogId)
            .OnDelete(DeleteBehavior.Restrict);
        modelBuilder.Entity<ExerciseLog>()
            .HasOne(wel => wel.Exercise)
            .WithMany()
            .HasForeignKey(wel => wel.ExerciseId)
            .OnDelete(DeleteBehavior.Restrict);
    }

    private List<T> LoadSeedData<T>(string resourceName)                                     
    {
        var assembly = Assembly.GetExecutingAssembly();
        using (var json = new StreamReader(assembly.GetManifestResourceStream(resourceName) ?? throw new InvalidOperationException()))
        {
            if(json is null)
                throw new ArgumentNullException($"O arquivo de Seed Data {resourceName} não foi encontrado");

            return JsonSerializer.Deserialize<List<T>>(json.ReadToEnd())!;
        }
    }
}
