using System.Text.Json.Serialization;

namespace GymApp.Domain.Entities;

public class MuscleGroup
{
    public MuscleGroup() { }

    public MuscleGroup(string name)
    {
        Name = name;
    }

    [JsonConstructor]
    public MuscleGroup(Guid id, string name)
    {
        Id = id;
        Name = name;
    }

    public Guid Id { get; init; } = Guid.NewGuid();

    public string Name { get; private set; } = null!;

    public ICollection<Exercise> Exercises { get; private set; } = [];
}
