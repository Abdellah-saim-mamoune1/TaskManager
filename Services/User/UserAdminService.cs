using Microsoft.EntityFrameworkCore;
using TaskManager.Data;
using TaskManager.DTOs.User;
using TaskManager.Interfaces.User;

namespace TaskManager.Services.User
{
    public class UserAdminService(AppDbContext _db):IUserAdminService
    {
        public async Task AddNewUserAsync(UserCreationDto form)
        {
            var User = new Entities.User
            {
                Account = form.Account,
                Name = form.Name,
                ImageUrl=form.ImageUrl,
                RoleId = 2 // User Role Id in database
            };

            _db.Add(User);
            await _db.SaveChangesAsync();
        }


        public async Task UpdateUserRoleAsync(int UserId, int RoleId)
        {

            var User = await _db.Users.FirstAsync(u => u.Id == UserId);
            User.RoleId=RoleId;

            await _db.SaveChangesAsync();
        }



    }
}
