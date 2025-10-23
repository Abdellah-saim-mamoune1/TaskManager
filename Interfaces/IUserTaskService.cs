using TaskManager.DTOs;

namespace TaskManager.Interfaces
{
    public interface IUserTaskService
    {
        public Task<taskGetDTO?> GetTaskById(int Id);
        public Task UpdateTaskStatus(int Id, taskGetDTO Task);
        public Task<taskGetDTO?> SearchOnTask(int Id);
    }
}
