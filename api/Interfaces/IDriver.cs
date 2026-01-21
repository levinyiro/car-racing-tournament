using api.DTO;
using api.Models;

namespace api.Interfaces
{
    public interface IDriver
    {
        Task<(bool IsSuccess, Driver? Driver, string? ErrorMessage)> GetDriverById(Guid id);
        Task<(bool IsSuccess, Statistics? DriverStatistics, string? ErrorMessage)> GetStatistics(string name);
        Task<(bool IsSuccess, string? ErrorMessage)> AddDriver(Season season, DriverDto driverDto, Team team);
        Task<(bool IsSuccess, string? ErrorMessage)> UpdateDriver(Driver driver, DriverDto driverDto, Team team);
        Task<(bool IsSuccess, string? ErrorMessage)> DeleteDriver(Driver driver);
        Task<(bool IsSuccess, string? ErrorMessage)> SetActualTeamNullByTeamId(Guid teamId);
        Task<(bool IsSuccess, List<Nationality>? Nationalities, string? ErrorMessage)> Nationalities();
    }
}
