using TaskManager.DTOs;

namespace TaskManager.Interfaces
{
    public interface IUserAdminService
    {

        public Task AddNewUserAsync(UserCreationDto form);
        public Task UpdateUserRoleAsync(int UserId,int RoleId);



    }
}
