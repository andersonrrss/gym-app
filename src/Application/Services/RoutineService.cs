using GymApp.Application.Interfaces;
using GymApp.Domain.Common;
using GymApp.Domain.Entities;

namespace GymApp.Application;

public class RoutineService : IRoutineService
{
    private readonly IRoutineRepository _routineRepository;

    public RoutineService(IRoutineRepository routineRepository)
    {
        _routineRepository = routineRepository;
    }

    public async Task<Result<IEnumerable<RoutineResponseDTO>>> GetUserRoutinesAsync(Guid userId, Guid requesterId)
    {
        if(userId != requesterId)
            return Result<IEnumerable<RoutineResponseDTO>>
                .Forbidden("Você não pode acessar as fichas de treino de outro usuário");

        var routines = await _routineRepository.GetUserRoutinesAsync(userId);

        if(!routines.Any())
            return Result<IEnumerable<RoutineResponseDTO>>.NotFound("Usuário não contém fichas de treino");
            
        return Result<IEnumerable<RoutineResponseDTO>>
            .Success(routines.Select(r => RoutineResponseDTO.FromEntity(r)));
    }

    public async Task<Result<RoutineResponseDTO>> GetRoutineAsync(Guid routineId, Guid requesterId)
    {
        var routine = await _routineRepository.GetRoutineByIdAsync(routineId);

        if(routine is null)
            return Result<RoutineResponseDTO>.NotFound("Ficha de treino não encontrada");

        if(routine.UserId != requesterId)
            return Result<RoutineResponseDTO>.Forbidden("Você não pode acessar essa ficha de treino");

        return Result<RoutineResponseDTO>
            .Success(RoutineResponseDTO.FromEntity(routine));
    }

    public async Task<Result<RoutineResponseDTO>> CreateRoutineAsync(RoutineRequestDTO routineDTO, Guid userId)
    {
        var routine = new Routine(routineDTO.Name, userId);

        await _routineRepository.AddAsync(routine);
        return Result<RoutineResponseDTO>
            .Success(RoutineResponseDTO.FromEntity(routine));
    }
}
