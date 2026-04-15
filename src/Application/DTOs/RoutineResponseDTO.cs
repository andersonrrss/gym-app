using GymApp.Application.DTOs;
using GymApp.Domain.Entities;

namespace GymApp.Application.DTOs;

public record class RoutineResponseDTO
{
    public Guid Id { get; init; }
    public string Name { get; init; } = null!;
    public IEnumerable<WorkoutResponseDTO> Workouts { get; init; } = [];

    public static RoutineResponseDTO FromEntity(Routine routine) => new()
    {
        Id = routine.Id,
        Name = routine.Name,
        Workouts = routine.Workouts.Select(w => WorkoutResponseDTO.FromEntity(w)).ToList()
    };
}
