using System.Text.Json.Serialization;

namespace GymApp.Domain.Entities;

public class Exercise
{
    public Exercise () {}

    public Exercise(string name, Guid muscleGroupId)
    {
        Name = name;
        MuscleGroupId = muscleGroupId;
    }

    [JsonConstructor]
    public Exercise(Guid id, string name, Guid muscleGroupId)
    {
        Id = id;
        Name = name;
        MuscleGroupId = muscleGroupId;
    }

    public Guid Id { get; init; } = Guid.NewGuid();

    public Guid MuscleGroupId { get; private set; }
    public MuscleGroup MuscleGroup { get; private set; } = null!;

    public string Name { get; private set; } = null!;
    
    // Caso seja um exercício não presente na lista padrão de exercícios
    // Um usuário pode criar um exercício personalizado
    // public Guid? CreatorId { get; private set; }
    // public User? Creator { get; private set; }
}
