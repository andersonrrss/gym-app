namespace GymApp.Domain.Entities;

public class ExerciseLog
{
    public ExerciseLog() {}

    public ExerciseLog(
        Guid exerciseId,
        Guid workoutLogId,
        int setsCompleted,
        int repsCompleted,
        double maxWeigth
    )
    {
        ExerciseId = exerciseId;
        WorkoutLogId = workoutLogId;
        SetsCompleted = setsCompleted;
        RepsCompleted = repsCompleted;
        MaxWeight = maxWeigth;
    }

    public Guid Id { get; private set; } = Guid.NewGuid();

    public Guid ExerciseId { get; private set; }
    public Exercise Exercise { get; private set; } = null!; // Deve referenciar Exercise

    public Guid WorkoutLogId { get; private set; }
    public WorkoutLog WorkoutLog { get; private set; } = null!;

    public int SetsCompleted { get; private set; }

    public int RepsCompleted { get; private set; }

    public double MaxWeight { get; private set; }
}
