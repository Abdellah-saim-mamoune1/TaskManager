using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TaskManager.DTOs.User;
using TaskManager.Interfaces.User;

namespace TaskManager.Controllers.User
{
    [Route("api/user/")]
    [ApiController]
    public class User1Controller(IUserManagementService UserManagmenetService) : ControllerBase
    {
        [HttpGet("{UserId}")]
        public async Task<IActionResult> GetInfoByIdAsync(int UserId)
        {
           var data= await UserManagmenetService.GetInfoByIdAsync(UserId);
            return Ok(data);
        }
        [HttpPut("{UserId}")]
        public async Task<IActionResult> UpdateInfoAsync(int UserId,UserInfoGetDto UserInfo)
        {
            await UserManagmenetService.UpdateInfoAsync(UserId, UserInfo);
            return Ok("The updating process was successful !! ");
        }
    }
}
