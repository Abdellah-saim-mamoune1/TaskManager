using System.ComponentModel.DataAnnotations.Schema;

namespace TaskManager.Entities
{
    public class Task
    {
        public int Id { get; set; }

        [ForeignKey("User")]
        public int AssignedTo { get; set; }
        public string Description { get; set; } = string.Empty;

        public DateOnly CreatedAt { get; set; }

        public DateOnly ExpiresAt { get; set; }

        public bool Status { get; set; }

        public User? User { get; set; }
    }
}
