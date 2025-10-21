using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.Contracts;

namespace TaskManager.Entities
{
    public class Comment
    {
        public int Id { get; set; }
        public string Text { get; set; }=string.Empty;

        [ForeignKey("Task")]
        public int TaskId { get; set; }

        [ForeignKey("User")]
        public int CommenterId { get; set; }

        public DateOnly CreatedAt { get; set; }

        public User? User { get; set; }
        public Task? Task { get; set; }
    }
}
