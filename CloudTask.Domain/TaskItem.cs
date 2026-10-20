using System;
using System.ComponentModel.DataAnnotations;

namespace CloudTask.Domain
{
    public class TaskItem
    {
        [Key]
        public Guid Id { get; set; } = Guid.NewGuid();

        [Required]
        [MaxLength(200)]
        public string Title { get; set; } = string.Empty;

        public string Description { get; set; } = string.Empty;

        public bool IsCompleted { get; set; } = false;

        public DateTime DueDate { get; set; }

        // Foreign Key
        public Guid ProjectId { get; set; }
        public Project Project { get; set; } = null!;
    }
}