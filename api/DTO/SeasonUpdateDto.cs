using api.Models;

namespace api.DTO
{
    public class SeasonUpdateDto
    {
        public string Name { get; set; } = default!;
        public string? Description { get; set; }
        public bool IsArchived { get; set; }
    }
}
