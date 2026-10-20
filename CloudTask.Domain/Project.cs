using System.Collections.Generic;
using System;
using System.ComponentModel.DataAnnotations;

namespace CloudTask.Domain
{
    public class Project
    {
        [Key]
        public Guid Id { get; set; } = Guid.NewGuid();

        [Required]
        [MaxLength(100)]
        public string Name { get; set; } = string.Empty;

        public string Description { get; set; } = string.Empty;

        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        // Foreign Key
        public Guid UserId { get; set; }
        public User User { get; set; } = null!;

        // Navigation Property (One Project has many Tasks)
        public ICollection<TaskItem> Tasks { get; set; } = new List<TaskItem>();
    }
}