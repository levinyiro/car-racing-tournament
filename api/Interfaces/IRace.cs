using api.DTO;
using api.Models;

namespace api.Interfaces
{
    public interface IRace
    {
        Task<(bool IsSuccess, Race? Race, string? ErrorMessage)> GetRaceById(Guid id);
        Task<(bool IsSuccess, string? ErrorMessage)> AddRace(Season season, RaceDto raceDto);
        Task<(bool IsSuccess, string? ErrorMessage)> UpdateRace(Race race, RaceDto raceDto);
        Task<(bool IsSuccess, string? ErrorMessage)> DeleteRace(Race race);
    }
}
