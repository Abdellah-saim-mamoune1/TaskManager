using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TaskManager.DTOs;
using TaskManager.DTOs.Task.Admin;
using TaskManager.DTOs.Tasks.Admin;
using TaskManager.Interfaces.Tasks.Admin;
using TaskManager.Services;

namespace TaskManager.Controllers.Tasks.Admin
{
    [Route("api/task/admin")]
    [ApiController]
    public class TaskAdminController(ITaskAdmin _TaskAdmin) : ControllerBase
    {

        [HttpPost]
        public async Task<IActionResult> CreateTaskAsync(TaskCreationDto form)
        {

            await _TaskAdmin.CreateAsync(form);

            return Ok("Task created successfully");

        }

        [HttpPut]
        public async Task<IActionResult> UpdateTaskAsync(TaskUpdateDto form)
        {

            await _TaskAdmin.CreateAsync(form);

            return Ok("Task updated successfully");

        }

        [HttpDelete("{TaskId}")]
        public async Task<IActionResult> DeleteTaskAsync(int TaskId)
        {

            await _TaskAdmin.DeleteAsync(TaskId);

            return Ok("Task deleted successfully");

        }
    }
}
