using System.ComponentModel.DataAnnotations;

namespace GymApp.Application;

public record class WorkoutRequestDTO
{
    [Required(ErrorMessage = "O treino precisa de um nome")]
    public string Name { get; init; } = null!;

    [Required(ErrorMessage = "O treino precisa estar vinculado a uma ficha")]
    public Guid RoutineId { get; init; }
}
