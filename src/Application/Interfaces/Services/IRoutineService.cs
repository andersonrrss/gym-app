using System.ComponentModel.DataAnnotations;
using GymApp.Domain.Common;
using GymApp.Application.DTOs;

namespace GymApp.Application.Interfaces;

public interface IRoutineService
{
    Task<Result<IEnumerable<RoutineResponseDTO>>> GetUserRoutinesAsync(Guid userId);

    Task<Result<RoutineResponseDTO>> GetRoutineAsync(Guid routineId, Guid requesterId);

    Task<Result<RoutineResponseDTO>> CreateRoutineAsync(RoutineRequestDTO routineDTO, Guid userId);
}
