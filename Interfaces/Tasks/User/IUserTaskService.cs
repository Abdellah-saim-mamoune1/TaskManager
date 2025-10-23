using TaskManager.DTOs;

namespace TaskManager.Interfaces.Tasks.User
{
    public interface IUserTaskService
    {
        public Task<List<taskGetDTO?>> GetTaskByIdAsync(int Id);
        public Task UpdateTaskStatusAsync(int Id, TaskStatutDTO Task);
    }
}
