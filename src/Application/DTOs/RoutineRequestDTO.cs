using System.ComponentModel.DataAnnotations;

namespace GymApp.Application;

public record class RoutineRequestDTO
{
    [Required(ErrorMessage = "É necessário um nome para a ficha de treino")]
    public string Name { get; set; } = null!;
}
