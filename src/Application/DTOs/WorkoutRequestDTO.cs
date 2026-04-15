using System.ComponentModel.DataAnnotations;

namespace GymApp.Application.DTOs;

public record class WorkoutRequestDTO
{
    [Required(ErrorMessage = "O treino precisa de um nome")]
    public string Name { get; init; } = null!;

    public Guid RoutineId { get; init; }
}
