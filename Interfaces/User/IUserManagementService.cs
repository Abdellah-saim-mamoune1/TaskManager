using TaskManager.DTOs.User;

namespace TaskManager.Interfaces.User
{
    public interface IUserManagementService
    {
        public Task<UserInfoGetDto?> GetInfoByIdAsync(int UserId);
        public Task UpdateInfoAsync(int UserId,UserInfoGetDto UserInfo);

    }
}
