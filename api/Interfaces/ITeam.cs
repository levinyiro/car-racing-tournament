using api.DTO;
using api.Models;

namespace api.Interfaces
{
    public interface ITeam
    {
        Task<(bool IsSuccess, Team? Team, string? ErrorMessage)> GetTeamById(Guid id);
        Task<(bool IsSuccess, string? ErrorMessage)> AddTeam(Season season, TeamDto team);
        Task<(bool IsSuccess, string? ErrorMessage)> UpdateTeam(Team team, TeamDto teamDto);
        Task<(bool IsSuccess, string? ErrorMessage)> DeleteTeam(Team team);
    }
}
