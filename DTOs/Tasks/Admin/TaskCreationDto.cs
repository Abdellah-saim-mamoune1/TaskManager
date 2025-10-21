using System.ComponentModel.DataAnnotations.Schema;

namespace TaskManager.DTOs.Task.Admin
{
    public class TaskCreationDto
    {
        public int AssignedTo { get; set; }
        public string Description { get; set; } = string.Empty;
        public DateOnly ExpiresAt { get; set; }
    }
}
