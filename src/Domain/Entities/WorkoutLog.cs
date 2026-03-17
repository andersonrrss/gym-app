namespace GymApp.Domain.Entities;

public class WorkoutLog
{
    public WorkoutLog() {}

    public WorkoutLog(Guid workoutId, DateOnly executedAt)
    {
        WorkoutId = workoutId;
        ExecutedAt = executedAt;
    }
    public Guid Id { get; private set; } = Guid.NewGuid();

    public Guid? WorkoutId { get; private set; }
    public Workout? Workout { get; private set; }

    public DateOnly ExecutedAt { get; private set; }

    public ICollection<ExerciseLog> ExercisesLogs { get; private set; } = [];
}
