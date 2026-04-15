using GymApp.Domain.Entities;

namespace GymApp.Application.DTOs;

public record class WorkoutWithExercisesDTO
{
    public Guid Id { get; init; }
    public string Name { get; init; } = null!;
    public IEnumerable<WorkoutExerciseResponseDTO> WorkoutExercises { get; init; } = null!;

    public static WorkoutWithExercisesDTO FromEntity(Workout workout, IEnumerable<WorkoutExercise> workoutExercises) => new()
    {
        Id = workout.Id,
        Name = workout.Name,
        WorkoutExercises = workoutExercises.Select(e => WorkoutExerciseResponseDTO.FromEntity(e))
            ?? Enumerable.Empty<WorkoutExerciseResponseDTO>()
    };
}
