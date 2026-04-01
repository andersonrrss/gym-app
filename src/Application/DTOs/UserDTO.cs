using GymApp.Domain.Entities;

namespace GymApp.Application;

public record class UserDTO
{
    public Guid Id { get; set; }
    public string Name { get; set; } = null!;
    public string Email { get; set; } = null!;

    public static UserDTO FromEntity(User user) => new()
    {
        Id = user.Id,
        Name = user.Name,
        Email = user.Email,
    };
}
