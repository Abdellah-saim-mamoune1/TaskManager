using TaskManager.DTOs.User;

namespace TaskManager.Interfaces.User
{
    public interface IUserAdminService
    {

        public Task AddNewUserAsync(UserCreationDto form);
        public Task UpdateUserRoleAsync(int UserId,int RoleId);



    }
}
