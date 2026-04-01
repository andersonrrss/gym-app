using GymApp.Application.Interfaces;
using GymApp.Domain.Common;

namespace GymApp.Application.Services;

public class UserService : IUserService
{
    private readonly IUserRepository _userRepository;

    public UserService(IUserRepository userRepository)
    {
        _userRepository = userRepository;
    }

    public async Task<Result<UserDTO>> GetUserInformationAsync(Guid userId, Guid requesterID)
    {
        if(userId != requesterID)
            return Result<UserDTO>.Forbidden("Você não pode acessar esse perfil");

        var user = await _userRepository.GetUserByIdAsync(userId);

        if(user is null)
            return Result<UserDTO>.NotFound("Usuário não encontrado");

        return Result<UserDTO>.Success(UserDTO.FromEntity(user));
    }
}
