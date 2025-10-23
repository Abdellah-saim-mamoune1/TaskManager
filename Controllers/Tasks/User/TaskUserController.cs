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
        [HttpPut("{Id}/{TaskStatus}")]
        public async Task<IActionResult> UpdateTaskStatusAsync(int Id, TaskStatutDTO TaskStatus)
        {
            await _userTaskService.UpdateTaskStatusAsync(Id, TaskStatus);
            return Ok("Task updated successfully");
        }
    }
}
