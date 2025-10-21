using TaskManager.DTOs.Tasks.User;

namespace TaskManager.Interfaces.Tasks.User
{
    public interface ITaskComment
    {

        public Task CreateAsync(CommentCreationDto form);
        public Task UpdateAsync(CommentUpdateDto form);
        public Task DeleteAsync(int Id); 
        
    }
}
