using System.Text.Json.Serialization;
using api.Models;

namespace api.DTO
{
    public class PermissionOutputDto
    {
        public Guid Id { get; set; }
        public Guid UserId { get; set; }
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public Guid SeasonId { get; set; }
        public string Username { get; set; } = default!;
        public PermissionType Type { get; set; }
    }
}
