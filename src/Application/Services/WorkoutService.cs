using GymApp.Application.DTOs;
using GymApp.Application.Interfaces;
using GymApp.Domain.Common;
using GymApp.Domain.Entities;

namespace GymApp.Application.Services;

public class WorkoutService : IWorkoutService
{
    private readonly IWorkoutRepository _workoutRepository;
    private readonly IRoutineRepository _routineRepository;

    public WorkoutService(IWorkoutRepository workoutRepository, IRoutineRepository routineRepository)
    {
        _workoutRepository = workoutRepository;
        _routineRepository = routineRepository;
    }

    public async Task<Result<WorkoutResponseDTO>> GetWorkoutAsync(Guid workoutId, Guid requesterId)
    {
        var workout = await _workoutRepository.GetWorkoutByIdAsync(workoutId, true);

        if(workout is null)
            return Result<WorkoutResponseDTO>
                .NotFound("Treino não encontrado");

        var queryUserId = workout.Routine.UserId;
        if(queryUserId != requesterId)
            return Result<WorkoutResponseDTO>
                .Forbidden("Você não pode acessar treinos de outros usuários");

        return Result<WorkoutResponseDTO>
            .Success(WorkoutResponseDTO.FromEntity(workout));
    }

    public async Task<Result<WorkoutResponseDTO>> CreateWorkoutAsync(WorkoutRequestDTO workoutDto, Guid requesterId)
    {
        var routine = await _routineRepository.GetRoutineByIdAsync(workoutDto.RoutineId);

        if(routine is null)
            return Result<WorkoutResponseDTO>.NotFound("Ficha de treino inexistente");

        if(routine.UserId != requesterId)
            return Result<WorkoutResponseDTO>.Forbidden("Você não pode editar esta ficha");

        var exists = await _workoutRepository.ExistsByNameAsync(workoutDto.RoutineId, workoutDto.Name);
        if(exists)
            return Result<WorkoutResponseDTO>.Conflict("Nome de treino já existente");
        
        var workout = new Workout(workoutDto.Name.Trim(), workoutDto.RoutineId);
        await _workoutRepository.AddAsync(workout);

        return Result<WorkoutResponseDTO>
            .Success(WorkoutResponseDTO.FromEntity(workout));
    }
}
