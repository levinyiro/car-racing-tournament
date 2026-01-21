using api.Models;

namespace api.DTO
{
    public class SeasonCreateDto
    {
        public string Name { get; set; } = default!;
        public string? Description { get; set; }
    }
}
