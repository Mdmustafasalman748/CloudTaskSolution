using System.Collections.Generic;
using System;
using System.ComponentModel.DataAnnotations;

namespace CloudTask.Domain
{
	public class User
	{
		[Key]
		public Guid Id { get; set; } = Guid.NewGuid(); // Modern alternative to int Identity

		[Required]
		[MaxLength(50)]
		public string Username { get; set; } = string.Empty;

		[Required]
		public string PasswordHash { get; set; } = string.Empty;

		[Required]
		[EmailAddress]
		public string Email { get; set; } = string.Empty;

		public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

		// Navigation Property (One User can have many Projects)
		public ICollection<Project> Projects { get; set; } = new List<Project>();
	}
}