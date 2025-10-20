using Microsoft.EntityFrameworkCore;
using TaskManager.Data;
using TaskManager.DTOs;
using TaskManager.Entities;
using TaskManager.Interfaces;

namespace TaskManager.Services
{
    public class UserAdminService(AppDbContext _db):IUserAdminService
    {
        public async System.Threading.Tasks.Task AddNewUserAsync(UserCreationDto form)
        {
            var User = new User
            {
                Account = form.Account,
                Name = form.Name,
                RoleId = 2 // User Role Id in database
            };

            _db.Add(User);
            await _db.SaveChangesAsync();
        }


        public async System.Threading.Tasks.Task UpdateUserRoleAsync(int UserId, int RoleId)
        {

            var User = await _db.Users.FirstAsync(u => u.Id == UserId);
            User.RoleId=RoleId;

            await _db.SaveChangesAsync();
        }



    }
}
