using TaskManager.DTOs.Task.Admin;
using TaskManager.DTOs.Tasks.Admin;

namespace TaskManager.Interfaces.Tasks.Admin
{
    public interface ITaskAdmin
    {

        public Task CreateAsync(TaskCreationDto form);
        public Task UpdateAsync(TaskUpdateDto form);
        public Task DeleteAsync(int taskId);


    }
}
