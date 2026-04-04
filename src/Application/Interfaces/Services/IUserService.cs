using GymApp.Domain.Common;

namespace GymApp.Application.Interfaces;

public interface IUserService
{    
    Task<Result<UserDTO>> GetUserInformationAsync(Guid userId);
}
