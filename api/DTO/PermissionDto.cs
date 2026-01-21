using System;
using api.Models;

namespace api.DTO
{
	public class PermissionDto
	{
		public Guid UserId { get; set; }
		public Guid SeasonId { get; set; }
		public PermissionType Type { get; set; }
	}
}

