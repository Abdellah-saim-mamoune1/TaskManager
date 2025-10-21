using System.ComponentModel.DataAnnotations.Schema;

namespace TaskManager.Entities
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Account { get; set; } = string.Empty; 
        public string ImageUrl { get; set; } = string.Empty;
        public string HashedPassword { get; set; } = string.Empty;

        [ForeignKey("Role")]
        public int RoleId { get; set; }
        public DateOnly CreatedAt { get; set; }

        public Role? Role { get; set; }

        public ICollection<Task> Tasks { get; set; } = [];
        public ICollection<Comment> Comments { get; set; } = [];

    }
}
