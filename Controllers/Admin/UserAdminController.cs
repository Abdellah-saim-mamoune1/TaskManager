using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TaskManager.DTOs.User;
using TaskManager.Interfaces.User;

namespace TaskManager.Controllers.Admin
{
    [Route("api/admin/user")]
    [ApiController]
    public class UserAdminController(IUserAdminService UserAdminService) : ControllerBase
    {

        [HttpPost]
        public async Task<IActionResult> AddNewUserAsync(UserCreationDto form)
        {

            await UserAdminService.AddNewUserAsync(form);

            return Ok("User created successfully");

        }


        [HttpPut("role/{UserId},{RoleId}")]
        public async Task<IActionResult> UpdateUserRoleAsync(int UserId,int RoleId)
        {

            await UserAdminService.UpdateUserRoleAsync(UserId,RoleId);

            return Ok("Role updated successfully");

        }
    }
}
