namespace GymApp.Domain.Entities;

public class WorkoutExercise
{
    public WorkoutExercise() {}

    public WorkoutExercise (
        Guid exerciseId, 
        Guid workoutId,
        int sets,
        int minReps = 0,
        int maxReps = 0,
        int? durationSeconds = null
    )
    {
        ExerciseId = exerciseId;
        WorkoutId = workoutId;
        Sets = sets;
        MinReps = minReps;
        MaxReps = maxReps;
        DurationSeconds = durationSeconds;
    }

    public Guid Id { get; private set; } = Guid.NewGuid();

    public Guid ExerciseId { get; private set; }
    public Exercise Exercise { get; private set; } = null!;

    public Guid WorkoutId { get; private set; }
    public Workout Workout { get; private set; } = null!;

    public int Sets { get; private set; }

    public int MinReps { get; private set; } // 0 para até a falha
    public int MaxReps { get; private set; } // 0 para até a falha
    
    public int? DurationSeconds { get; private set; }
}
