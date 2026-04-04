using GymApp.Domain.Entities;

namespace GymApp.Application.DTOs;

public record class WorkoutResponseDTO
{
    public Guid Id { get; init; }
    public string Name { get; init; } = null!;

    public static WorkoutResponseDTO FromEntity(Workout workout) => new()
    {
        Id = workout.Id,
        Name = workout.Name,
    };
}
