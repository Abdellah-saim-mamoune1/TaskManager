using TaskManager.DTOs.Task.Admin;

namespace TaskManager.DTOs.Tasks.Admin
{
    public class TaskUpdateDto:TaskCreationDto
    {
        public int Id { get; set; }
    }
}
