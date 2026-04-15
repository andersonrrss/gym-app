using GymApp.Domain.Common;
using GymApp.Application.DTOs;

namespace GymApp.Application.Interfaces;

public interface IUserService
{    
    Task<Result<UserDTO>> GetUserInformationAsync(Guid userId);
}
