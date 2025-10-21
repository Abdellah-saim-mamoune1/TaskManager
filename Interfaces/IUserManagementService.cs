using TaskManager.DTOs;

namespace TaskManager.Interfaces
{
    public interface IUserManagementService
    {
        public Task<UserInfoGetDto?> GetInfoByIdAsync(int UserId);
        public Task UpdateInfoAsync(int UserId,UserInfoGetDto UserInfo);

    }
}
