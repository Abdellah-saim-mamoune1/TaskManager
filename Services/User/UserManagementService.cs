
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.EntityFrameworkCore;
using TaskManager.Data;
using TaskManager.DTOs.User;
using TaskManager.Interfaces.User;

namespace TaskManager.Services.User
{
    public class UserManagementService(AppDbContext _Db) : IUserManagementService
    {
       
    

        public async Task<UserInfoGetDto?> GetInfoByIdAsync(int UserId)
        {
            var UserInfo = await _Db.Users.Include(u=>u.Role).FirstOrDefaultAsync(x => x.Id == UserId);
            if (UserInfo == null)
            {
                return null;
            }
            return new UserInfoGetDto
            {
                Id = UserInfo.Id,
                Name = UserInfo.Name,
                Account = UserInfo.Account,
                ImageUrl = UserInfo.ImageUrl,
                Role = UserInfo!.Role!.Name
            };
        }
        public async Task UpdateInfoAsync(int UserId, UserInfoGetDto UserInfo)
        {
            var NewUserInfo = await _Db.Users.Include(x => x.Role).FirstOrDefaultAsync(x => x.Id == UserId);
            if (UserInfo == null || NewUserInfo==null)
            {
                return;
            }
            NewUserInfo.Id = UserInfo.Id;
            NewUserInfo.Name = UserInfo.Name;
            NewUserInfo.Account = UserInfo.Account;
            NewUserInfo.ImageUrl = UserInfo.ImageUrl;
            NewUserInfo.Role!.Name = UserInfo.Role;
          
            await _Db.SaveChangesAsync();

        }
    }
}
