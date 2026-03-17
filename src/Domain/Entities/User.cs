namespace GymApp.Domain.Entities;

public class User
{
    public User () { }

    public User (string username, string email, string passwordHash)
    {
        UserName = username;
        Email = email;
        PasswordHash = passwordHash;
    }

    public Guid Id { get; private set; } = Guid.NewGuid();

    public string UserName { get; private set; } = null!;

    public string Email { get; private set; } = null!;

    public string PasswordHash { get; private set; } = null!;

    public ICollection<Routine> Routines { get; private set; } = [];
}
