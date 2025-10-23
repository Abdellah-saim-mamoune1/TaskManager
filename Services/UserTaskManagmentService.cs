using Microsoft.EntityFrameworkCore;
using TaskManager.Data;
using TaskManager.DTOs;
using TaskManager.Interfaces;

namespace TaskManager.Services
{
    public class UserTaskManagmentService(AppDbContext _Db) : IUserTaskService
    {
        public async Task<List<taskGetDTO>?> GetTaskById(int Id)
        {
            var data = await _Db.Tasks.Include(u => u.User).ThenInclude(X => X!.Role).Select(s => new taskGetDTO
            {
                Id = s.Id,
                CreatedAt = s.CreatedAt,
                Description = s.Description,
                ExpiresAt = s.ExpiresAt,
                Status = s.Status,
                UserInfo = new UserInfoGetDto
                {
                    Id = s.User!.Id,
                    Name = s.User.Name,
                    Account = s.User.Account,
                    ImageUrl = s.User.ImageUrl,
                    Role = s.User.Role!.Name,
                }
            }).ToListAsync();
            if (data == null)
            {
                return null;
            }
            return data;
        }
        public async Task UpdateTaskStatus(int Id, TaskStatutDTO Task)
        {
            var data = await _Db.Tasks.FirstOrDefaultAsync(x => x.Id == Id);
            data!.Status = Task.Status;
            await _Db.SaveChangesAsync();
        }
        public Task<taskGetDTO?> SearchOnTask(int Id)
        {

        }
    }
}
