namespace TaskManager.DTOs.Tasks.User
{
    public class CommentCreationDto
    {
        public string Text { get; set; } = string.Empty;
        public int TaskId { get; set; }
        public int CommenterId { get; set; }
    }
}
