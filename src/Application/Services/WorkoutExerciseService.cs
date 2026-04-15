using GymApp.Application.DTOs;
using GymApp.Application.Interfaces;
using GymApp.Domain.Common;
using GymApp.Domain.Entities;
using GymApp.Domain.Enums;

namespace GymApp.Application.Services;

public class WorkoutExerciseService : IWorkoutExerciseService
{
    private readonly IExerciseRepository _exerciseRepository;
    private readonly IWorkoutExerciseRepository _workoutExerciseRepository;
    private readonly IWorkoutRepository _workoutRepository;

    public WorkoutExerciseService(
        IExerciseRepository exerciseRepository, 
        IWorkoutExerciseRepository workoutExerciseRepository,
        IWorkoutRepository workoutRepository
        )
    {
        _exerciseRepository = exerciseRepository;
        _workoutExerciseRepository = workoutExerciseRepository;
        _workoutRepository = workoutRepository;
    }

    public async Task<Result<WorkoutExerciseResponseDTO>> CreateWorkoutExerciseAsync(Guid workoutId, WorkoutExerciseRequestDTO requestDTO, Guid userId)
    {
        var workout = await _workoutRepository.GetWorkoutByIdAsync(workoutId, true);
        if(workout is null) 
            return Result<WorkoutExerciseResponseDTO>.NotFound("O Treino especificado não existe"); 
        if(workout.Routine.UserId != userId) 
            return Result<WorkoutExerciseResponseDTO>.Forbidden(); 

        var isInWorkout = await _workoutExerciseRepository.IsInWorkout(workoutId, requestDTO.ExerciseId);
        if(isInWorkout)
            return Result<WorkoutExerciseResponseDTO>.Conflict("Exercício já está no treino");

        var exercise = await _exerciseRepository.GetByIdAsync(requestDTO.ExerciseId); 
        if(exercise is null) 
            return Result<WorkoutExerciseResponseDTO>.NotFound("Exercício não existe");

        var result = WorkoutExercise.Create(
            requestDTO.ExerciseId, workoutId, requestDTO.Sets, requestDTO.Values, requestDTO.ExerciseType, requestDTO.IsometricHoldSeconds
        );

        if(!result.IsSucess)
            return Result<WorkoutExerciseResponseDTO>.ValidationFailure(result.ValidationErrors!);

        await _workoutExerciseRepository.AddAsync(result.Value!);
        return Result<WorkoutExerciseResponseDTO>.Success(
            WorkoutExerciseResponseDTO.FromEntity(result.Value!, exercise.Name
        ));
    }
}