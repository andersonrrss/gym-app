using System.ComponentModel.DataAnnotations;
using GymApp.Domain.Common;
namespace GymApp.Application;

public interface IRoutineService
{
    Task<Result<IEnumerable<RoutineResponseDTO>>> GetUserRoutinesAsync(Guid userId, Guid requesterId);

    Task<Result<RoutineResponseDTO>> GetRoutineAsync(Guid routineId, Guid requesterId);

    Task<Result<RoutineResponseDTO>> CreateRoutineAsync(RoutineRequestDTO routineDTO, Guid userId);
}
