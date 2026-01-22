using api.DTO;
using api.Models;

namespace api.Interfaces
{
    public interface IResult
    {
        Task<(bool IsSuccess, Result? Result, string? ErrorMessage)> GetResultById(Guid id);
        Task<(bool IsSuccess, string? ErrorMessage)> AddResult(Race race, ResultDto resultDto, Driver driver, Team team);
        Task<(bool IsSuccess, string? ErrorMessage)> UpdateResult(Result result, ResultDto resultDto, Race race, Driver driver, Team team);
        Task<(bool IsSuccess, string? ErrorMessage)> DeleteResult(Result result);
        Task<(bool IsSuccess, string? ErrorMessage)> DeleteResultsByTeamId(Guid teamId);
        Task<(bool IsSuccess, string? ErrorMessage)> DeleteResultsByRaceId(Guid raceId);
    }
}
