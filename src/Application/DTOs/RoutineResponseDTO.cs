using GymApp.Domain.Entities;

namespace GymApp.Application;

public record class RoutineResponseDTO
{
    public Guid Id { get; set; }
    public string Name { get; set; } = null!;
    public Guid UserId { get; set; }

    public static RoutineResponseDTO FromEntity(Routine routine) => new()
    {
        Id = routine.Id,
        Name = routine.Name,
        UserId = routine.UserId
    };
}
