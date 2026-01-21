using System.Text.Json.Serialization;
using api.Models;

namespace api.DTO
{
    public class ResultDto
    {
        [JsonConverter(typeof(JsonStringEnumConverter))]
        public ResultType Type { get; set; }
        public int? Position { get; set; }
        public double Point { get; set; }
        public Guid DriverId { get; set; }
        public Guid TeamId { get; set; }
        public Guid RaceId { get; set; }
    }
}
