using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TaskManager.DTOs;
using TaskManager.Interfaces;
using TaskManager.Interfaces.Tasks.User;

namespace TaskManager.Controllers.Tasks.User
{
    [Route("api/task/user")]
    [ApiController]
    public class TaskUserController(IUserTaskService _userTaskService) : ControllerBase
    {
        [HttpGet("{Id}")]
        public async Task<IActionResult> GetTaskAsync(int Id)
        {
            var data = await _userTaskService.GetTaskByIdAsync(Id);
            return Ok(data);
        }
        public async Task<IActionResult> UpdateTaskStatusAsync(int Id, TaskStatutDTO Task)
        {
            await _userTaskService.UpdateTaskStatusAsync(Id, Task);
            return Ok("Task updated successfully");
        }
    }
}
